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

let makeElement name (children : obj seq) = 
    System.Xml.Linq.XElement( System.Xml.Linq.XName.op_Implicit(name), children )

let XAttr name value = System.Xml.Linq.XAttribute( System.Xml.Linq.XName.op_Implicit(name), value.ToString() ) :> obj

let embedInAnchor urlOpt node : obj =
    match urlOpt with
    | Some url -> makeElement "a" [XAttr "href" url; node] :> obj
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
                                sprintf "%d" year
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

            let monthCell = makeElement "td"
                                [
                                    cssClass "month"
                                    XAttr "rowspan" appearancesThisMonth
                                    sprintf "%s" monthNames.[month-1] :> obj
                                ]

            let eventsForTheMonth = monthEntry 
                                    |> Seq.toList 
                                    |> List.sortBy( fun e -> e.appearances.[0].date ) 
                                    |> orderAppearance

            let mutable firstEvent = true
            for ewa in eventsForTheMonth do
                let event = ewa.key.event
                let nameBlock = embedInAnchor event.url event.name
                let nameDiv = makeElement "div" [nameBlock]
                let eventCellChildren = 
                    seq {
                        yield cssClass "eventName"
                        yield nameDiv :> obj
                        yield XAttr "rowspan" ewa.appearances.Length
                        if event.location.IsSome then
                            let location = sprintf " (%s, %s)" event.location.Value.city event.location.Value.country
                            yield makeElement "div" [cssClass "location"; location ] :> obj
                        else if event.eventType = EventType.Podcast then
                            yield makeElement "div" [cssClass "location"; "(podcast)" ] :> obj
                    }

                let eventCell = makeElement "td" eventCellChildren

                let appearanceElements =
                    let mutable firstAppearance = true
                    ewa.appearances 
                    |> List.map( fun a ->
                                    let suffix, talkClass = 
                                        match a.appearanceType with
                                        | Keynote ->         "[keynote]", "keynote"
                                        | LightningTalk ->   "[lightning talk]", "lightning"
                                        | Panel ->           "[panel]", "panel"
                                        | Interview ->       "[podcast interview]", "interview"
                                        | _ ->               "", ""

                                    let appearanceNodes =
                                        seq {
                                            yield cssClass "appearanceTitle"
                                            if a.imageName.IsSome then
                                                let img = makeElement "img" [XAttr "src" (imagePrefix + a.imageName.Value); cssClass "thumbnail"]
                                                yield embedInAnchor a.videoUrl img
                                            yield embedInAnchor a.infoUrl a.title
                                            if suffix <> "" then
                                                yield " " :> obj
                                                yield makeElement "div" [cssClass ("type " + talkClass); suffix] :> obj
                                        }
                                    let rowNodes =
                                        seq {
                                            if firstEvent then
                                                firstEvent <- false
                                                yield monthCell :> obj
                                            if firstAppearance then
                                                firstAppearance <- false
                                                yield eventCell :> obj
                                            yield makeElement "td" appearanceNodes :> obj
                                         }
                                    makeElement "tr" rowNodes )
                    |> List.rev

                rows := appearanceElements @ !rows

    !rows |> List.rev


[<EntryPoint>]
let main argv = 

    let upcomingAppearances, pastAppearances = futureAndPastAppearances allAppearances

    // !TBD: makeAppearanceRows return seq of objects?
    let pastTable = makeElement "table" (makeAppearanceRows pastAppearances AppearanceOrder.Reverse |> Seq.map( fun o -> o :> obj ) )
    let futureTable = makeElement "table" (makeAppearanceRows upcomingAppearances AppearanceOrder.Forward |> Seq.map( fun o -> o :> obj ))

    let futureTitle = makeElement "h1" ["Upcoming appearances"]
    let pastTitle = makeElement "h1" ["Past appearances"]

    let head = makeElement "head"
                [
                    makeElement "link"
                        [
                            XAttr "href" (cssPrefix + "appearances.css")
                            XAttr "rel" "stylesheet"
                            XAttr "type" "text/css"
                        ]
                ]

    let xml = makeElement "html"
                [
                    head
                    makeElement "body" 
                        [
                            futureTitle
                            futureTable
                            makeElement "br" []
                            pastTitle
                            pastTable
                        ]
                ]

    printf "%s\n" (xml.ToString())
    xml.Save( "/Development/Scratch/Appearances/output/index.html" )

    0 // return an integer exit code


