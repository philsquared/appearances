﻿module AppearanceData

open Model
open EventData


let allAppearances = [
    {
        event = appDevCon2017
        appearanceType = AppearanceType.Talk
        title = "Test Driving Swift To The Max";
        infoUrl = Some "http://appdevcon.nl/session/phil-nash-test-driving-swift-to-the-max/"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2017-03-17"
    }    
    {
        event = iosCon2017
        appearanceType = AppearanceType.Talk
        title = "Test Driving Swift To The Max - with or without the tests!";
        infoUrl = Some "https://skillsmatter.com/conferences/8180-ioscon-2017-the-conference-for-ios-and-swift-developers#program"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2017-03-31"
    }
    {
        event = meetingCpp2016
        appearanceType = AppearanceType.Talk
        title = "Functional C++ For Fun and Profit";
        infoUrl = Some "https://meetingcpp.com/index.php/tv16/items/19.html"
        videoUrl = Some "https://www.youtube.com/watch?v=X6bXoOlNw0M"
        imageName = Some "meetingcpp2016.jpg"
        date = System.DateTime.Parse "2016-11-18"
    }
    {
        event = bcsEdinburgh
        appearanceType = AppearanceType.Talk
        title = "Swift for the curious"
        infoUrl = Some "http://edinburgh.bcs.org/events/2016/161005.htm"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2016-11-05"
    }
    {
        event = norDevMeetup
        appearanceType = AppearanceType.Talk
        title = "Swift for the curious"
        infoUrl = Some "http://www.meetup.com/Norfolk-Developers-NorDev/events/232490441/"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2016-09-07"
    }
    {
        event = qCon2016
        appearanceType = AppearanceType.Talk
        title = "Mens Sana In Corpore Sano - Optimising Mind & Body";
        infoUrl = Some "http://qconlondon.com/presentation/mens-sana-corpore-sano-optimising-mind-body"
        videoUrl = Some "https://www.infoq.com/presentations/health-mind-body"
        imageName = Some "qcon2016.jpg"
        date = System.DateTime.Parse "2016-03-08"
    }
    {
        event = accu2017
        appearanceType = AppearanceType.Talk
        title = "Functional C++ For Fun and Profit"
        infoUrl = None
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2017-04-26" // update when date known
    }
    {
        event = accu2016
        appearanceType = AppearanceType.Talk
        title = "Swift for the curious"
        infoUrl = Some "http://accu.org/index.php/conferences/accu_conference_2016/accu2016_sessions#Swift_for_the_Curious"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2016-04-20"
    }
    {
        event = ndcLondon
        appearanceType = AppearanceType.Talk
        title = "Seeking Simplicity"
        infoUrl = Some "http://ndc-london.com/talk/phil-nash"
        videoUrl = Some "https://vimeo.com/157716613"
        imageName = Some "functional2015-simplicity.jpg"
        date = System.DateTime.Parse "2016-01-13"
    }
    {
        event = ndcOslo
        appearanceType = AppearanceType.Talk
        title = "Test Driven C++ with Catch"
        infoUrl = Some "http://ndcoslo.oktaset.com/t-31328"
        videoUrl = Some "https://vimeo.com/131632252"
        imageName = Some "ndcoslo2015.jpg"
        date = System.DateTime.Parse "2015-06-18"
    }
    {
        event = functionalLondoners
        appearanceType = AppearanceType.LightningTalk
        title = "Facket - a package manager written in F#";
        infoUrl = Some "http://www.meetup.com/FSharpLondon/events/222073642/?a=uc1_vm&read=1&_af=event&_af_eid=222073642"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2015-06-04"
    }
    {
        event = accu2015
        appearanceType = AppearanceType.Talk
        title = "Seeking Simplicity"
        infoUrl = Some "http://accu.org/index.php/conferences/accu_conference_2015/accu2015_sessions#simplicity"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2015-04-23"
    }
    {
        event = accu2015
        appearanceType = AppearanceType.MiniTalk
        title = "The Stand Up"
        infoUrl = Some "http://accu.org/index.php/conferences/accu_conference_2015/accu2015_sessions#the_stand-up"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2015-04-13"
    }
    {
        event = stretch2014
        appearanceType = AppearanceType.Talk
        title = "Mens Sana In Corpore Sano - A Healthy Mind in a Healthy Body";
        infoUrl = None
        videoUrl = Some "http://www.ustream.tv/recorded/56107221"
        imageName = Some "stretch2014.jpg"
        date = System.DateTime.Parse "2014-12-04"
    }
    {
        event = meetingCpp2014;
        appearanceType = AppearanceType.Talk
        title = "Test Driven C++ with Catch"
        infoUrl = Some "http://meetingcpp.com/index.php/tv14/items/2.html"
        videoUrl = Some "https://www.youtube.com/watch?v=C2LcIp56i-8"
        imageName = Some "meetingcpp2014.jpg"
        date = System.DateTime.Parse "2014-12-05"
    }
    {
        event = functionalLondoners
        appearanceType = AppearanceType.Talk
        title = "Functional Scripting (or getting F# in through the backdoor)"
        infoUrl = Some "http://www.meetup.com/FSharpLondon/events/197905052/?_af_eid=197905052&_af=event&a=uc1_te"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2014-08-14"
    }
    {
        event = lidg
        appearanceType = AppearanceType.Talk
        title = "Why are you not testing your code?"
        infoUrl = Some "http://lanyrd.com/2014/lidg63"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2014-05-07"
    }
    {
        event = accu2014
        appearanceType = AppearanceType.Talk
        title = "Mens Sana In Corpore Sano"
        infoUrl = Some "http://accu.org/index.php/conferences/accu_conference_2015/accu2015_sessions#the_stand-up"
        videoUrl = Some "http://www.infoq.com/presentations/neat-fit"
        imageName = Some "accu2014.jpg"
        date = System.DateTime.Parse "2014-04-13"
    }
    {
        event = accu2014
        appearanceType = AppearanceType.LightningTalk
        title = "Lies, damned lies and double-blind randomised controlled trials"
        infoUrl = None
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2014-04-12"
    }
    {
        event = norDevCon2014
        appearanceType = AppearanceType.Talk
        title = "Agile & Mobile - do they work together as well as they sound?"
        infoUrl = Some "http://www.nordevcon.com/nordevcon2014/"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2014-02-26"
    }
    {
        event = meetingCppLondon
        appearanceType = AppearanceType.Talk
        title = "Catch - A natural fit for automated testing in C++ and Objective-C"
        infoUrl = Some "https://twitter.com/jpetrise/status/411224551331495937/photo/1"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2013-12-12"
    }
    {
        event = bcsEdinburgh
        appearanceType = AppearanceType.Talk
        title = "Catch - A natural fit for automated testing in C++ and Objective-C"
        infoUrl = Some "http://edinburgh.bcs.org/events/2012-13/131106.htm"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2013-11-06"
    }
    {
        event = agileOnTheBeach2013
        appearanceType = AppearanceType.Talk
        title = "Agile and Mobile - do they work together as well as they sound?"
        infoUrl = Some "http://agileonthebeach.com/2013-programme/2013-videos-and-presentations"
        videoUrl = None
        imageName = Some "aotb2013.jpg"
        date = System.DateTime.Parse "2013-09-05"
    }
    {
        event = agileOnTheBeach2013
        appearanceType = AppearanceType.LightningTalk
        title = "NLP is the Agile of psychotherapy"
        infoUrl = None
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2013-09-05"
    }
    {
        event = norDevMeetup
        appearanceType = AppearanceType.Talk
        title = "Is it really worth TDDing iOS apps?"
        infoUrl = Some "http://www.meetup.com/Norfolk-Developers-NorDev/events/119849182/?a=cr1_grp&rv=cr1&_af_eid=119849182&_af=event"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2013-07-10"
    }
    {
        event = accu2013
        appearanceType = AppearanceType.Talk
        title = "Catch - A natural fit for automated testing in C++ and Objective-C"
        infoUrl = Some "http://accu.org/index.php/conferences/accu_conference_2013/accu2013_sessions#catch_-_a_natural_fit_for_automated_testing_in_c_c_and_objective-c"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2013-04-12"
    }
    {
        event = accu2013
        appearanceType = AppearanceType.LightningTalk
        title = "C++ Extension methods"
        infoUrl = Some "http://www.slideshare.net/phil_nash/c-extension-methods-18678294"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2013-04-11"
    }
    {
        event = scanDev2013
        appearanceType = AppearanceType.Panel
        title = "Pitfalls when using Test Driven Development & how to avoid them"
        infoUrl = None
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2013-03-5"
    }
    {
        event = scanDev2013
        appearanceType = AppearanceType.Talk
        title = "Developing iOS Apps for Fun and Profit"
        infoUrl = Some "http://www.scandevconf.se/2013/conference/speakers/phil-nash/?backlnk=dp&tgday=togglewrap2"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2013-03-4"
    }
    {
        event = scanDev2013
        appearanceType = AppearanceType.Talk
        title = "Catch - Automated Testing in C, C++ and Objective-C was never so natural"
        infoUrl = Some "http://www.scandevconf.se/2013/conference/speakers/phil-nash/?backlnk=dp&tgday=togglewrap2"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2013-03-4"
    }
    {
        event = syncConf
        appearanceType = AppearanceType.Talk
        title = "Developing iOS Apps for Fun and Profit"
        infoUrl = None
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2013-02-14"
    }
    {
        event = accuLondon
        appearanceType = AppearanceType.MiniTalk
        title = "These things are sent to test us"
        infoUrl = Some "http://www.eventbrite.com/e/accu-london-jan-2013-modern-testing-tickets-5265792126"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2013-01-31"
    }
    {
        event = accuLondon
        appearanceType = AppearanceType.Talk
        title = "Why do we need yet another automated testing framework for C++?"
        infoUrl = Some "http://www.eventbrite.com/e/why-do-we-need-yet-another-testing-framework-for-c-and-objective-c-tickets-3800820356"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2012-07-11"
    }
    {
        event = mobileEast2012
        appearanceType = AppearanceType.Talk
        title = "Is it really possible to TDD iOS apps?"
        infoUrl = Some "http://mobileeast.net/me2012/sessioninfo.php?session=4"
        videoUrl = Some "http://www.infoq.com/presentations/TDD-iOS"
        imageName = Some "MobileEast2012.jpg"
        date = System.DateTime.Parse "2012-06-29"
    }
    {
        event = accu2012
        appearanceType = AppearanceType.Keynote
        title = "The Congruent Programmer"
        infoUrl = Some "http://accu.org/index.php/conferences/accu_conference_2012/accu2012_sessions#The%20Congruent%20Programmer"
        videoUrl = Some "https://skillsmatter.com/skillscasts/3358-phil-nash-the-congruent-programmer"
        imageName = Some "accu2012.jpg"
        date = System.DateTime.Parse "2012-04-26"
    }
    {
        event = accu2012
        appearanceType = AppearanceType.LightningTalk
        title = "Why I do what I do"
        infoUrl = None
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2012-04-26"
    }
    {
        event = accu2011
        appearanceType = AppearanceType.LightningTalk
        title = "Beyond xUnit - what's the Catch?"
        infoUrl = Some "http://accu.org/index.php/conferences/accu_conference_2011/accu2011_sessions#Lightning%20talks"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2011-04-15"
    }
    {
        event = lidg
        appearanceType = AppearanceType.Talk
        title = "We don't need no stinking garbage collection"
        infoUrl = Some "http://www.linkedin.com/groupItem?view=&srchtype=discussedNews&gid=1798655&item=25830206&type=member&trk=EML_anet_qa_ttle-dDhOon0JumNFomgJt7dBpSBA&fromEmail=&ut=2wB1yGtaXuemg1"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2010-08-04"
    }
    {
        event = softwareEast2010
        appearanceType = AppearanceType.Talk
        title = "iPhone development - what next?"
        infoUrl = None
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2010-06-21"
    }
    {
        event = accu2010
        appearanceType = AppearanceType.LightningTalk
        title = "The iPad"
        infoUrl = None
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2010-04-16"
    }
    {
        event = stackOverflow
        appearanceType = AppearanceType.Talk
        title = "iPhone Development Jump Start"
        infoUrl = Some "http://www.levelofindirection.com/journal/2009/10/29/stackoverflow-devdays-london.html"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2009-10-28"
    }
    {
        event = lidg
        appearanceType = AppearanceType.Talk
        title = "Saxing up XML - a more elegant way to handle XML in your iPhone development"
        infoUrl = None
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2009-06-03"
    }
    {
        event = accu2009
        appearanceType = AppearanceType.Talk
        title = "Objective-C in 90 minutes"
        infoUrl = Some "http://accu.org/index.php/conferences/accu_conference_2009/accu2009_sessions#Objective-C%20in%2090%20minutes"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2009-04-23"
    }
    {
        event = accu2007
        appearanceType = AppearanceType.Talk
        title = "The other 99 percent"
        infoUrl = Some "http://accu.org/index.php/conferences/accu_conference_2007/accu2007_sessions#The%20other%2099%20percent"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2007-04-14"
    }
    {
        event = accu2004
        appearanceType = AppearanceType.Talk
        title = "Organic Programming"
        infoUrl = Some "http://accu.org/index.php/conferences/2004/speakers2004"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2004-04-16"
    }
    {
        event = cppCast
        appearanceType = AppearanceType.Interview
        title = "Test-driven C++ Using Catch"
        infoUrl = Some "http://cppcast.com/2015/05/phil-nash"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2015-05-27"
    }
    {
        event = cppCon2015
        appearanceType = AppearanceType.Talk
        title = "Test-driven C++ With Catch"
        infoUrl = Some "http://cppcon2015.sched.org/event/a7e0138f6d94017d27e0a8f5b127c23d#.Vets-rSA3FI"
        videoUrl = Some "https://www.youtube.com/watch?v=gdzP3pAC6UI"
        imageName = Some "cppcon2015.jpg"
        date = System.DateTime.Parse "2015-09-22"
    }
    {
        event = cppCon2015
        appearanceType = AppearanceType.LightningTalk
        title = "The Stand-Up"
        infoUrl = None
        videoUrl = Some "https://t.co/redirect?url=https%3A%2F%2Ft.co%2FqoR33ZMLhq%3Fcn%3DcmVwbHk%253D&t=1&cn=cmVwbHk%3D&sig=f61dcdc62d9b5a16d80972c5e3fac9f42f22b41a&iid=169956e6c3ab4531a25e5614e3ac1f69&uid=19881648&nid=27+228"
        imageName = Some "cppcon2015-thestandup.jpg"
        date = System.DateTime.Parse "2015-09-22"
    }
    {
        event = aylesburyTesters
        appearanceType = AppearanceType.Talk
        title = "Test Driven C++ with Catch - the state of testing in the world of C++"
        infoUrl = Some "http://www.meetup.com/SoftwareTestingClub/events/223732954/"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2015-11-17"
    }
    {
        event = accuLondon
        appearanceType = AppearanceType.Talk
        title = "WTF?: What’s This F# (I keep hearing about)?"
        infoUrl = Some "http://www.meetup.com/ACCULondon/events/225137940/"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2015-09-17"
    }
    {
        event = seattleFsharpMeetup
        appearanceType = AppearanceType.Talk
        title = "Seeking Simplicity"
        infoUrl = Some "http://www.meetup.com/FSharpSeattle/events/225449811/?a=co2_grp&gj=co2&rv=co2"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2015-09-24"
    }
    {
        event = functionalLondoners
        appearanceType = AppearanceType.Talk
        title = "Seeking Simplicity"
        infoUrl = Some "http://www.meetup.com/FSharpLondon/events/223918135/t/ra1_te/"
        videoUrl = Some "https://skillsmatter.com/skillscasts/6810-seeking-simplicity-with-phil-nash"
        imageName = Some "functional2015-simplicity.jpg"
        date = System.DateTime.Parse "2015-10-08"
    }
    {
        event = functionalLondoners
        appearanceType = AppearanceType.LightningTalk
        title = "The Stand Up"
        infoUrl = None
        videoUrl = Some "https://skillsmatter.com/skillscasts/6810-seeking-simplicity-with-phil-nash"
        imageName = Some "functional2015-thestandup.jpg"
        date = System.DateTime.Parse "2015-10-08"
    }
    {
        event = norDevCon2016
        appearanceType = AppearanceType.Talk
        title = "Seeking Simplicity"
        infoUrl = Some "http://www.nordevcon.com/sessions/#philnash"
        videoUrl = Some "https://youtu.be/ySR8eALeRNU"
        imageName = Some "nordevcon2016.jpg"
        date = System.DateTime.Parse "2016-02-27"
    }
    {
        event = norDevCon2017
        appearanceType = AppearanceType.Talk
        title = "Test Driving Swift To The Max - with or without the tests"
        infoUrl = Some "http://www.nordevcon.com/nordevcon2017/#swiftmax"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2017-02-25"
    }
    {
        event = accuBristol
        appearanceType = AppearanceType.Talk
        title = "Functional C++ For Fun and Profit"
        infoUrl = Some "https://www.meetup.com/ACCU-Bristol/events/235098264"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2016-11-15"
    }
    {
        event = accuLondon
        appearanceType = AppearanceType.Talk
        title = "Functional C++ For Fun and Profit"
        infoUrl = Some "https://skillsmatter.com/meetups/8480-accu-london-meeup"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2016-11-30"
    }
    {
        event = accuOxford
        appearanceType = AppearanceType.Talk
        title = "Functional C++ For Fun and Profit"
        infoUrl = Some "http://www.meetup.com/ACCU-Oxford/events/233349127"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2016-11-29"
    }
    {
        event = spbMeetup
        appearanceType = AppearanceType.Talk
        title = "Functional C++ For Fun and Profit"
        infoUrl = Some "http://www.meetup.com/St-Petersburg-CPP-User-Group/events/234305828/"
        videoUrl = Some "https://www.youtube.com/watch?v=YgcUuYCCV14"
        imageName = Some "spb-fcpp2016.jpg"
        date = System.DateTime.Parse "2016-11-23"
    }
    {
        event = munichCppUserGroup
        appearanceType = AppearanceType.Talk
        title = "Functional C++ For Fun and Profit"
        infoUrl = Some "https://www.meetup.com/MUCplusplus/events/235593620/"
        videoUrl = None
        imageName = None
        date = System.DateTime.Parse "2016-12-20"
    }
]

