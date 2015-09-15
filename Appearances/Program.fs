﻿open Model
open EventData
open AppearanceData
open System.Collections.Generic
open System.Xml.Linq

let imagePrefix = @"/storage/conf_images/"
let cssPrefix = @"/storage/"
//let imagePrefix = @"images/"
//let cssPrefix = ""

type AppearanceOrder = Forward | Reverse

type EventMonth = { event : Event; year : int; month: int }

type EventsWithAppearances = {
    key : EventMonth
    appearances : Appearance list
}

let findOrCreate (dict: Dictionary<'K, 'V>) (key:'K) (creator:unit->'V) : 'V =
    let ok, existing = dict.TryGetValue( key )
    if ok then 
        existing
    else
        let newEntry = creator()
        dict.Add( key, newEntry )
        newEntry

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

    let isFuture (ewa:EventsWithAppearances) = 
        let year, month = ewa.key.year, ewa.key.month
        year > now.Year || (year = now.Year && month >= now.Month )

    appearancesByEvent |> List.partition isFuture

let pastAppearances, upcomingAppearances = futureAndPastAppearances allAppearances


let xname str = XName.Get str

let embedInAnchor urlOpt node : XNode =
    match urlOpt with
    | Some( url ) -> XElement( xname "a", XAttribute( xname "href", url ), node ) :> XNode
    | None -> node

let cssClass cls = XAttribute( xname "class", cls )

let addAppearanceRows (table:XElement) (appearances: EventsWithAppearances list) order =
    let monthNames = [|"Jan"; "Feb"; "Mar"; "Apr"; "May"; "Jun"; "Jul"; "Aug"; "Sep"; "Oct"; "Nov"; "Dec"|]

    let sortIntoDirection l =
        match order with
        | AppearanceOrder.Forward -> l
        | AppearanceOrder.Reverse -> List.rev l

    let dict = new Dictionary<int, Dictionary<int, List<EventsWithAppearances>>>()
    for ewa in appearances do
        let yearEntry = findOrCreate dict ewa.key.year (fun unit -> new Dictionary<int, List<EventsWithAppearances>>() )
        let monthEntry = findOrCreate yearEntry ewa.key.month ( fun unit -> new List<EventsWithAppearances>() )
        monthEntry.Add ewa

    let years = dict.Keys |> Seq.toList |> List.sort |> sortIntoDirection

    for year in years do
        let row = XElement( xname "tr",
                    XElement( xname "td",
                        cssClass "year",
                        XAttribute( xname "colspan", "3" ),
                        sprintf "%d" year ) )
        table.Add( row )

        let yearEntry = dict.[year]

        let months = yearEntry.Keys |> Seq.toList |> List.sort |> sortIntoDirection

        for month in months do
            let monthEntry = yearEntry.[month]

            let appearancesThisMonth = monthEntry |> Seq.fold( fun a ewa -> a + ewa.appearances.Length ) 0

            let monthCell = XElement( xname "td",
                                cssClass "month",
                                XAttribute( xname "rowspan", appearancesThisMonth.ToString() ),
                                sprintf "%s" monthNames.[month-1] )

            let eventsForTheMonth = monthEntry 
                                    |> Seq.toList 
                                    |> List.sortBy( fun e -> e.appearances.[0].date ) 
                                    |> sortIntoDirection

            let mutable firstEvent = true
            for ewa in eventsForTheMonth do
                let event = ewa.key.event
                let eventCell = XElement( xname "td",
                                    cssClass "eventName",
                                    XAttribute( xname "rowspan", ewa.appearances.Length.ToString() ) )
                let nameBlock = embedInAnchor event.url (XText event.name )
                let nameDiv = XElement( xname "div", nameBlock )
                eventCell.Add( nameDiv )
                if event.location.IsSome then
                    let location = sprintf " (%s, %s)" event.location.Value.city event.location.Value.country
                    eventCell.Add( XElement( xname "div", cssClass "location", location ) )
                else if event.eventType = EventType.Podcast then
                    eventCell.Add( XElement( xname "div", cssClass "location", "(podcast)" ) )

                let mutable firstAppearance = true
                for a in ewa.appearances do
                    let appearanceCell = XElement( xname "td",
                                            cssClass "appearanceTitle" )
                    if a.imageName.IsSome then
                        let img = XElement( xname "img",
                                                XAttribute( xname "src", imagePrefix + a.imageName.Value ),
                                                cssClass "thumbnail" )
                        appearanceCell.Add( embedInAnchor a.videoUrl img )

                    appearanceCell.Add( embedInAnchor a.infoUrl (XText a.title) )

                    let suffix, talkClass = 
                        match a.appearanceType with
                        | AppearanceType.Keynote ->         "[keynote]", "keynote"
                        | AppearanceType.LightningTalk ->   "[lightning talk]", "lightning"
                        | AppearanceType.Panel ->           "[panel]", "panel"
                        | AppearanceType.Interview ->       "[podcast interview]", "interview"
                        | _ ->                              "", ""
                    if suffix <> "" then
                        appearanceCell.Add( " ", XElement( xname "div", cssClass ("type " + talkClass), suffix ) )


                    let row = XElement( xname "tr" )
                    if firstEvent then
                        row.Add( monthCell )
                        firstEvent <- false
                    if firstAppearance then
                        row.Add( eventCell )
                        firstAppearance <- false
                    row.Add( appearanceCell )
                    table.Add( row )


[<EntryPoint>]
let main argv = 

    let mutable pastTable = XElement( xname "table" )
    let mutable futureTable = XElement( xname "table" )

    addAppearanceRows pastTable pastAppearances AppearanceOrder.Reverse
    addAppearanceRows futureTable upcomingAppearances AppearanceOrder.Forward

    let futureTitle = XElement( xname "h1", "Upcoming appearances" )
    let pastTitle = XElement( xname "h1", "Past appearances" )

    let head = XElement( xname "head",
                XElement( xname "link",
                    XAttribute( xname "href", cssPrefix + "appearances.css" ),
                    XAttribute( xname "rel", "stylesheet" ),
                    XAttribute( xname "type", "text/css" ) ) )

    let xml = XElement( xname "html",
                head,
                XElement( xname "body",
                    futureTitle,
                    futureTable,
                    XElement( xname "br" ),
                    pastTitle,
                    pastTable ) )

    printf "%s\n" (xml.ToString())
    xml.Save( "/Development/Scratch/Appearances/index.html" )

    0 // return an integer exit code


