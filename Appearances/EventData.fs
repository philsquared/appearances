module EventData

open Model

let ndcLondon = {
        eventType = EventType.Conference
        name = "NDC London"
        location = Some { city = "London"; country = "UK" }
        url = Some "http://ndc-london.com"
    }
let ndcOslo = {
        eventType = EventType.Conference
        name = "NDC Oslo"
        location = Some { city = "Oslo"; country = "Norway" }
        url = Some "http://ndcoslo.com"
    }
let accu2016 = {
        eventType = EventType.Conference
        name = "Accu 2016"
        location = Some { city = "Bristol"; country = "UK" }
        url = Some "http://accu.org/index.php/conferences/accu_conference_2016"
    }
let accu2015 = {
        eventType = EventType.Conference
        name = "Accu 2015"
        location = Some { city = "Bristol"; country = "UK" }
        url = Some "http://accu.org/index.php/conferences/accu_conference_2015"
    }
let accu2014 = {
        eventType = EventType.Conference
        name = "Accu 2014"
        location = Some { city = "Bristol"; country = "UK" }
        url = Some "http://accu.org/index.php/conferences/accu_conference_2014"
    }
let accu2013 = {
        eventType = EventType.Conference
        name = "Accu 2013"
        location = Some { city = "Bristol"; country = "UK" }
        url = Some "http://accu.org/index.php/conferences/accu_conference_2013"
    }
let accu2012 = {
        eventType = EventType.Conference
        name = "Accu 2012"
        location = Some { city = "Oxford"; country = "UK" }
        url = Some "http://accu.org/index.php/conferences/accu_conference_2012"
    }
let accu2011 = {
        eventType = EventType.Conference
        name = "Accu 2011";
        location = Some { city = "Oxford"; country = "UK" }
        url = Some "http://accu.org/index.php/conferences/accu_conference_2011"
    }
let accu2010 = {
        eventType = EventType.Conference;
        name = "Accu 2010";
        location = Some { city = "Oxford"; country = "UK" }
        url = Some "http://accu.org/index.php/conferences/accu_conference_2010"
    }
let accu2009 = {
        eventType = EventType.Conference;
        name = "Accu 2009";
        location = Some { city = "Oxford"; country = "UK" }
        url = Some "http://accu.org/index.php/conferences/accu_conference_2009"
    }
let accu2007 = {
        eventType = EventType.Conference
        name = "Accu 2007"
        location = Some { city = "Oxford"; country = "UK" }
        url = Some "http://accu.org/index.php/conferences/accu_conference_2007"
    }
let accu2004 = {
        eventType = EventType.Conference
        name = "Accu 2004"
        location = Some { city = "Oxford"; country = "UK" }
        url = Some "http://accu.org/index.php/conferences/accu_conference_2004"
    }
let accuLondon = {
        eventType = EventType.Meetup
        name = "Accu London"
        location = Some { city = "London"; country = "UK" }
        url = None
    }
let functionalLondoners = {
        eventType = EventType.Meetup
        name = "F#unctional Londoners"
        location = Some { city = "London"; country = "UK" }
        url = Some "http://www.meetup.com/FSharpLondon"
    }
let seattleFsharpMeetup = {
        eventType = EventType.Meetup
        name = "Seattle F# Meetup"
        location = Some { city = "Redmond"; country = "USA" }
        url = Some "http://www.meetup.com/FSharpSeattle"
    }
let meetingCpp2014 = {
        eventType = EventType.Conference
        name = "MeetingC++"
        location = Some { city = "Berlin"; country = "Germany" }
        url = Some "http://meetingcpp.com/index.php/mcpp2014.html"
    }
let meetingCppLondon = {
        eventType = EventType.Meetup
        name = "MeetingC++ London"
        location = Some { city = "London"; country = "UK" }
        url = None
    }

let stretch2014 = {
        eventType = EventType.Conference
        name = "Stretch"
        location = Some { city = "Budapest"; country = "Hungary" }
        url = Some "http://stretchcon.com/2014"
    }
let lidg = {
        eventType = EventType.Meetup
        name = "London iOS Developer's Group"
        location = Some { city = "London"; country = "UK" }
        url = Some "https://www.linkedin.com/groups/London-iOS-Developer-Group-1798655/about"
    }
let norDevCon2014 = {
        eventType = EventType.Conference
        name = "NorDevCon"
        location = Some { city = "Norwich"; country = "UK" }
        url = Some "http://www.nordevcon.com/nordevcon2014"
    }
let norDevCon2016 = {
        eventType = EventType.Conference
        name = "NorDevCon"
        location = Some { city = "Norwich"; country = "UK" }
        url = Some "http://www.nordevcon.com"
    }
let bcsEdinburgh = {
        eventType = EventType.Meetup
        name = "BCS Edinburgh"
        location = Some { city = "Edinburgh"; country = "UK" }
        url = Some "http://edinburgh.bcs.org/events"
    }
let agileOnTheBeach2013 = {
        eventType = EventType.Conference
        name = "Agile On The Beach"
        location = Some { city = "Falmouth"; country = "UK" }
        url = Some "http://agileonthebeach.com/2013-programme"
    }
let norDevMeetup = {
        eventType = EventType.Meetup
        name = "NorDev"
        location = Some { city = "Norwich"; country = "UK" }
        url = Some "http://www.meetup.com/Norfolk-Developers-NorDev"
    }
let scanDev2013 = {
        eventType = EventType.Conference
        name = "Scandinavian Developers Conference"
        location = Some { city = "Gothenburg"; country = "Sweden" }
        url = Some "http://www.scandevconf.se/2013/"
    }
let syncConf = {
        eventType = EventType.Conference
        name = "SyncConf"
        location = Some { city = "Norwich"; country = "UK" }
        url = None
    }
let mobileEast2012 = {
        eventType = EventType.Conference
        name = "Mobile East"
        location = Some { city = "Cambridge"; country = "UK" }
        url = Some "http://mobileeast.net/me2012/"
    }
let softwareEast2010 = {
        eventType = EventType.Conference
        name = "Software East"
        location = Some { city = "Cambridge"; country = "UK" }
        url = Some "http://www.linkedin.com/groups/Software-East-3874685?home=&gid=3874685&trk=anet_ug_hm"
    }
let stackOverflow = {
        eventType = EventType.Conference
        name = "Stackoverflow DevDays"
        location = Some { city = "London"; country = "UK" }
        url = Some "http://www.levelofindirection.com/journal/2009/10/29/stackoverflow-devdays-london.html"
    }
let cppCast = {
        eventType = EventType.Podcast
        name = "CppCast"
        location = None
        url = Some "http://cppcast.com"
    }
let cppCon2015 = {
        eventType = EventType.Conference
        name = "CppCon 2015"
        location = Some { city = "Bellevue, Washington"; country = "USA" }
        url = Some "http://cppcon.com"
    }
let aylesburyTesters = {
        eventType = EventType.Meetup
        name = "Aylesbury Testers"
        location = Some { city = "Aylesbury"; country = "UK" }
        url = Some "http://www.meetup.com/SoftwareTestingClub/events/223732954/?a=ro2_gnl&gj=ro2_e&rv=ro2_e&_af=event&_af_eid=223732954&https=off"
    }
