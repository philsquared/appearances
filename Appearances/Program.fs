open Model
open EventData
open AppearanceData

let imagePrefix = @"../storage/conf_images/"
let cssPrefix = @"../storage/"

type AppearanceOrder = Forward | Reverse

type EventMonth = { event : Event; year : int; month: int }

type EventsWithAppearances = {
    key : EventMonth
    appearances : Appearance list
}

let futureAndPastAppearances (appearances : Appearance list) =

    let appearancesByEvent = 
        appearances
        |> List.fold( fun (m:Map<EventMonth, Appearance list>) a -> 
                        let key = { event = a.event; year = a.date.Year; month = a.date.Month }
                        let newList = match m.TryFind key with 
                                        | Some existing -> a :: existing
                                        | None -> [a]
                        m.Add (key, newList) ) Map.empty
        |> Seq.map( fun e -> { key = e.Key; appearances = e.Value } )
        |> Seq.toList

    //let now = System.DateTime.Parse "2015-05-05"
    let now = System.DateTime.Now

    let isFuture ewa = 
        let firstDate = ewa.appearances.[ewa.appearances.Length-1].date
        firstDate > now

    appearancesByEvent |> List.partition isFuture

// h/t Phil Trelford - http://trelford.com/blog/post/F-XML-Comparison-(XElement-vs-XmlDocument-vs-XmlReaderXmlWriter-vs-Discriminated-Unions).aspx
type XElement (name:string, [<System.ParamArray>] values:obj []) = 
    inherit System.Xml.Linq.XElement
        (System.Xml.Linq.XName.op_Implicit(name), values) 

let makeElement name (children : obj seq) = 
    System.Xml.Linq.XElement( System.Xml.Linq.XName.op_Implicit(name), children )

let XAttr name value = System.Xml.Linq.XAttribute( System.Xml.Linq.XName.op_Implicit(name), value.ToString() )
let XText value = System.Xml.Linq.XText( value.ToString() )

let embedInAnchor urlOpt node : System.Xml.Linq.XNode =
    match urlOpt with
    | Some( url ) -> XElement( "a", XAttr "href" url, node ) :> System.Xml.Linq.XNode
    | None -> node

let cssClass cls = XAttr "class" cls

let makeAppearanceRows (appearances: EventsWithAppearances list) order =
    let rows : System.Xml.Linq.XElement list ref = ref []
    let monthNames = [|"Jan"; "Feb"; "Mar"; "Apr"; "May"; "Jun"; "Jul"; "Aug"; "Sep"; "Oct"; "Nov"; "Dec"|]

    let orderAppearance l =
        match order with
        | AppearanceOrder.Forward -> l
        | AppearanceOrder.Reverse -> List.rev l

    let yearToAppearances = appearances |> List.groupBy (fun a -> a.key.year)
    let years = yearToAppearances |> List.map fst |> List.sort |> orderAppearance
    let appearancesByYear = yearToAppearances |> Map.ofList

    for year in years do
        let row = makeElement "tr"
                    [   
                        makeElement "td"
                            [
                                cssClass "year"
                                XAttr "colspan" "3"
                                XText (sprintf "%d" year)
                            ]
                     ]
        rows := row :: !rows

        let yearEntry = appearancesByYear.[year]

        let monthsToEvents = yearEntry |> List.groupBy (fun ewa -> ewa.key.month )
        let eventsByMonth = monthsToEvents |> Map.ofList
        let months = monthsToEvents |> List.map fst |> List.sort |> orderAppearance

        for month in months do
            let monthEntry = eventsByMonth.[month]

            let appearancesThisMonth = monthEntry |> Seq.fold( fun a ewa -> a + ewa.appearances.Length ) 0

            let monthCell = XElement( "td",
                                cssClass "month",
                                XAttr "rowspan" appearancesThisMonth,
                                sprintf "%s" monthNames.[month-1] )

            let eventsForTheMonth = monthEntry 
                                    |> Seq.toList 
                                    |> List.sortBy( fun e -> e.appearances.[0].date ) 
                                    |> orderAppearance

            let mutable firstEvent = true
            for ewa in eventsForTheMonth do
                let event = ewa.key.event
                let eventCell = XElement( "td",
                                    cssClass "eventName",
                                    XAttr "rowspan" ewa.appearances.Length )
                let nameBlock = embedInAnchor event.url (XText event.name )
                let nameDiv = XElement( "div", nameBlock )
                eventCell.Add( nameDiv )
                if event.location.IsSome then
                    let location = sprintf " (%s, %s)" event.location.Value.city event.location.Value.country
                    eventCell.Add( XElement( "div", cssClass "location", location ) )
                else if event.eventType = EventType.Podcast then
                    eventCell.Add( XElement( "div", cssClass "location", "(podcast)" ) )

                let mutable firstAppearance = true
                for a in ewa.appearances do
                    let suffix, talkClass = 
                        match a.appearanceType with
                        | AppearanceType.Keynote ->         "[keynote]", "keynote"
                        | AppearanceType.LightningTalk ->   "[lightning talk]", "lightning"
                        | AppearanceType.Panel ->           "[panel]", "panel"
                        | AppearanceType.Interview ->       "[podcast interview]", "interview"
                        | _ ->                              "", ""

                    let appearanceNodes : obj list =
                        [cssClass "appearanceTitle"]
                        @
                        if a.imageName.IsSome then
                            let img = makeElement "img" [XAttr "src" (imagePrefix + a.imageName.Value); cssClass "thumbnail"]
                            [embedInAnchor a.videoUrl img]
                        else
                            []
                        @
                        [embedInAnchor a.infoUrl (XText a.title)]
                        @
                        if suffix <> "" then
                            [ XText " "; makeElement "div" [cssClass ("type " + talkClass); suffix] ]
                        else
                            []                        
                    let appearanceCell = makeElement "td" appearanceNodes

                    let rowNodes : obj list =
                        if firstEvent then
                            firstEvent <- false
                            [monthCell]
                         else
                            []
                        @
                        if firstAppearance then
                            firstAppearance <- false
                            [eventCell]
                        else
                            []
                    let row = makeElement "tr" (rowNodes @ [appearanceCell])

                    rows := row :: !rows

    !rows |> List.rev

let addAppearanceRows (table:XElement) (appearances: EventsWithAppearances list) order =
    let rows = makeAppearanceRows appearances order
    for row in rows do
        table.Add row


[<EntryPoint>]
let main argv = 

    let pastTable = XElement( "table" )
    let futureTable = XElement( "table" )

    let upcomingAppearances, pastAppearances = futureAndPastAppearances allAppearances
    addAppearanceRows pastTable pastAppearances AppearanceOrder.Reverse
    addAppearanceRows futureTable upcomingAppearances AppearanceOrder.Forward

    let futureTitle = XElement( "h1", "Upcoming appearances" )
    let pastTitle = XElement( "h1", "Past appearances" )

    let head = XElement( "head",
                XElement( "link",
                    XAttr "href" (cssPrefix + "appearances.css"),
                    XAttr "rel" "stylesheet",
                    XAttr "type" "text/css" ) )

    let xml = XElement( "html",
                head,
                XElement( "body",
                    futureTitle,
                    futureTable,
                    XElement( "br" ),
                    pastTitle,
                    pastTable ) )

    printf "%s\n" (xml.ToString())
    xml.Save( "/Development/Scratch/Appearances/output/index.html" )

    0 // return an integer exit code


