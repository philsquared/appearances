module AppearanceData

open Model
open EventData


let allAppearances = [
    {
        event = ndcOslo;
        appearanceType = AppearanceType.Talk;
        title = "Test Driven C++ with Catch";
        infoUrl = Some("http://ndcoslo.oktaset.com/t-31328");
        videoUrl = Some("https://vimeo.com/131632252");
        imageName = Some("ndcoslo2015.jpg");
        date = System.DateTime.Parse( "2015-06-18" );
    };
    {
        event = functionalLondoners;
        appearanceType = AppearanceType.LightningTalk;
        title = "Facket - a package manager written in F#";
        infoUrl = Some( "http://www.meetup.com/FSharpLondon/events/222073642/?a=uc1_vm&read=1&_af=event&_af_eid=222073642" );
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2015-06-04" );
    };
    {
        event = accu2015;
        appearanceType = AppearanceType.Talk;
        title = "Seeking Simplicity";
        infoUrl = Some("http://accu.org/index.php/conferences/accu_conference_2015/accu2015_sessions#simplicity");
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2015-04-23" );
    };
    {
        event = accu2015;
        appearanceType = AppearanceType.MiniTalk;
        title = "The Stand Up";
        infoUrl = Some( "http://accu.org/index.php/conferences/accu_conference_2015/accu2015_sessions#the_stand-up" );
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2015-04-13" );
    };
    {
        event = stretch2014;
        appearanceType = AppearanceType.Talk;
        title = "Mens Sana In Corpore Sano - A Healthy Mind in a Healthy Body";
        infoUrl = None;
        videoUrl = Some( "http://www.ustream.tv/recorded/56107221" );
        imageName = Some( "stretch2014.jpg" );
        date = System.DateTime.Parse( "2014-12-04" );
    };
    {
        event = meetingCpp2014;
        appearanceType = AppearanceType.Talk;
        title = "Test Driven C++ with Catch";
        infoUrl = Some( "http://meetingcpp.com/index.php/tv14/items/2.html" );
        videoUrl = Some( "https://www.youtube.com/watch?v=C2LcIp56i-8" );
        imageName = Some( "meetingcpp2014.jpg" );
        date = System.DateTime.Parse( "2014-12-05" );
    };
    {
        event = functionalLondoners;
        appearanceType = AppearanceType.Talk;
        title = "Functional Scripting (or getting F# in through the backdoor)";
        infoUrl = Some( "http://www.meetup.com/FSharpLondon/events/197905052/?_af_eid=197905052&_af=event&a=uc1_te" );
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2014-08-14" );
    };
    {
        event = lidg;
        appearanceType = AppearanceType.Talk;
        title = "Why are you not testing your code?";
        infoUrl = Some( "http://lanyrd.com/2014/lidg63" );
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2014-05-07" );
    };
    {
        event = accu2014;
        appearanceType = AppearanceType.Talk;
        title = "Mens Sana In Corpore Sano";
        infoUrl = Some( "http://accu.org/index.php/conferences/accu_conference_2015/accu2015_sessions#the_stand-up" );
        videoUrl = Some("http://www.infoq.com/presentations/neat-fit");
        imageName = Some("accu2014.jpg");
        date = System.DateTime.Parse( "2014-04-13" );
    };
    {
        event = accu2014;
        appearanceType = AppearanceType.LightningTalk;
        title = "Lies, damned lies and double-blind randomised controlled trials";
        infoUrl = None;
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2014-04-12" );
    };
    {
        event = norDevCon2014;
        appearanceType = AppearanceType.Talk;
        title = "Agile & Mobile - do they work together as well as they sound?";
        infoUrl = Some( "http://www.nordevcon.com/nordevcon2014/" );
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2014-02-26" );
    };

    {
        event = meetingCppLondon;
        appearanceType = AppearanceType.Talk;
        title = "Catch - A natural fit for automated testing in C++ and Objective-C";
        infoUrl = Some( "https://twitter.com/jpetrise/status/411224551331495937/photo/1" );
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2013-12-12" );
    };
    {
        event = bcsEdinburgh;
        appearanceType = AppearanceType.Talk;
        title = "Catch - A natural fit for automated testing in C++ and Objective-C";
        infoUrl = Some( "http://edinburgh.bcs.org/events/2012-13/131106.htm" );
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2013-11-06" );
    };    
    {
        event = agileOnTheBeach2013;
        appearanceType = AppearanceType.Talk;
        title = "Agile and Mobile - do they work together as well as they sound?";
        infoUrl = Some( "http://agileonthebeach.com/2013-programme/2013-videos-and-presentations" );
        videoUrl = None;
        imageName = Some( "aotb2013.jpg" );
        date = System.DateTime.Parse( "2013-09-05" );
    }; 
    {
        event = agileOnTheBeach2013;
        appearanceType = AppearanceType.LightningTalk;
        title = "NLP is the Agile of psychotherapy";
        infoUrl = None;
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2013-09-05" );
    };
    {
        event = norDevMeetup;
        appearanceType = AppearanceType.Talk;
        title = "Is it really worth TDDing iOS apps?";
        infoUrl = Some("http://www.meetup.com/Norfolk-Developers-NorDev/events/119849182/?a=cr1_grp&rv=cr1&_af_eid=119849182&_af=event");
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2013-07-10" );
    };
    {
        event = accu2013;
        appearanceType = AppearanceType.Talk;
        title = "Catch - A natural fit for automated testing in C++ and Objective-C";
        infoUrl = Some("http://accu.org/index.php/conferences/accu_conference_2013/accu2013_sessions#catch_-_a_natural_fit_for_automated_testing_in_c_c_and_objective-c");
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2013-04-12" );
    };
    {
        event = accu2013;
        appearanceType = AppearanceType.LightningTalk;
        title = "C++ Extension methods";
        infoUrl = Some("http://www.slideshare.net/phil_nash/c-extension-methods-18678294");
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2013-04-11" );
    };
    {
        event = scanDev2013;
        appearanceType = AppearanceType.Panel;
        title = "Pitfalls when using Test Driven Development & how to avoid them";
        infoUrl = None;
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2013-03-5" );
    };
    {
        event = scanDev2013;
        appearanceType = AppearanceType.Talk;
        title = "Developing iOS Apps for Fun and Profit";
        infoUrl = Some("http://www.scandevconf.se/2013/conference/speakers/phil-nash/?backlnk=dp&tgday=togglewrap2");
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2013-03-4" );
    };
    {
        event = scanDev2013;
        appearanceType = AppearanceType.Talk;
        title = "Catch - Automated Testing in C, C++ and Objective-C was never so natural";
        infoUrl = Some("http://www.scandevconf.se/2013/conference/speakers/phil-nash/?backlnk=dp&tgday=togglewrap2");
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2013-03-4" );
    };
    {
        event = syncConf;
        appearanceType = AppearanceType.Talk;
        title = "Developing iOS Apps for Fun and Profit";
        infoUrl = None;
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2013-02-14" );
    };
    {
        event = accuLondon;
        appearanceType = AppearanceType.MiniTalk;
        title = "These things are sent to test us";
        infoUrl = Some("http://www.eventbrite.com/e/accu-london-jan-2013-modern-testing-tickets-5265792126");
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2013-01-31" );
    };
    {
        event = accuLondon;
        appearanceType = AppearanceType.Talk;
        title = "Why do we need yet another automated testing framework for C++?";
        infoUrl = Some("http://www.eventbrite.com/e/why-do-we-need-yet-another-testing-framework-for-c-and-objective-c-tickets-3800820356");
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2012-07-11" );
    };
    {
        event = mobileEast2012;
        appearanceType = AppearanceType.Talk;
        title = "Is it really possible to TDD iOS apps?";
        infoUrl = Some("http://mobileeast.net/me2012/sessioninfo.php?session=4");
        videoUrl = Some("http://www.infoq.com/presentations/TDD-iOS");
        imageName = Some("MobileEast2012.jpg");
        date = System.DateTime.Parse( "2012-06-29" );
    };
    {
        event = accu2012;
        appearanceType = AppearanceType.Keynote;
        title = "The Congruent Programmer";
        infoUrl = Some("http://accu.org/index.php/conferences/accu_conference_2012/accu2012_sessions#The%20Congruent%20Programmer");
        videoUrl = Some("https://skillsmatter.com/skillscasts/3358-phil-nash-the-congruent-programmer");
        imageName = Some("accu2012.jpg");
        date = System.DateTime.Parse( "2012-04-26" );
    };
    {
        event = accu2012;
        appearanceType = AppearanceType.LightningTalk;
        title = "Why I do what I do";
        infoUrl = None;
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2012-04-26" );
    };
    {
        event = accu2011;
        appearanceType = AppearanceType.LightningTalk;
        title = "Beyond xUnit - what's the Catch?";
        infoUrl = Some("http://accu.org/index.php/conferences/accu_conference_2011/accu2011_sessions#Lightning%20talks");
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2011-04-15" );
    };
    {
        event = lidg;
        appearanceType = AppearanceType.Talk;
        title = "We don't need no stinking garbage collection";
        infoUrl = Some("http://www.linkedin.com/groupItem?view=&srchtype=discussedNews&gid=1798655&item=25830206&type=member&trk=EML_anet_qa_ttle-dDhOon0JumNFomgJt7dBpSBA&fromEmail=&ut=2wB1yGtaXuemg1");
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2010-08-04" );
    };
    {
        event = softwareEast2010;
        appearanceType = AppearanceType.Talk;
        title = "iPhone development - what next?";
        infoUrl = None;
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2010-06-21" );
    };
    {
        event = accu2010;
        appearanceType = AppearanceType.LightningTalk;
        title = "The iPad";
        infoUrl = None;
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2010-04-10" ); // !TBD find exact date
    };
    {
        event = stackOverflow;
        appearanceType = AppearanceType.Talk;
        title = "iPhone Development Jump Start";
        infoUrl = None;
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2009-10-10" ); // !TBD find exact date
    };
    {
        event = lidg;
        appearanceType = AppearanceType.Talk;
        title = "Saxing up XML - a more elegant way to handle XML in your iPhone development";
        infoUrl = None;
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2009-06-10" ); // !TBD find exact date
    };
    {
        event = accu2009;
        appearanceType = AppearanceType.Talk;
        title = "Objective-C in 90 minutes";
        infoUrl = Some("http://accu.org/index.php/conferences/accu_conference_2009/accu2009_sessions#Objective-C%20in%2090%20minutes");
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2009-06-10" ); // !TBD find exact date
    };
    {
        event = accu2007;
        appearanceType = AppearanceType.Talk;
        title = "The other 99 percent";
        infoUrl = Some("http://accu.org/index.php/conferences/accu_conference_2007/accu2007_sessions#The%20other%2099%20percent");
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2007-04-10" ); // !TBD find exact date
    };
    {
        event = accu2004;
        appearanceType = AppearanceType.Talk;
        title = "Organic Programming";
        infoUrl = Some("http://accu.org/index.php/conferences/2004/speakers2004");
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2004-04-10" ); // !TBD find exact date
    };

    {
        event = cppCast;
        appearanceType = AppearanceType.Interview;
        title = "Test-driven C++ Using Catch";
        infoUrl = Some("http://cppcast.com/2015/05/phil-nash");
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2015-05-27" );
    };

    {
        event = cppCon2015;
        appearanceType = AppearanceType.Talk;
        title = "Test-driven C++ With Catch";
        infoUrl = None; // !TBD Update
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2015-09-24" ); // !TBD Update
    };

    {
        event = aylesburyTesters;
        appearanceType = AppearanceType.Talk;
        title = "Test-driven C++ With Catch";
        infoUrl = Some("http://www.meetup.com/SoftwareTestingClub/events/223732954/");
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2015-11-17" );
    };
    {
        event = accuLondon;
        appearanceType = AppearanceType.Talk;
        title = "{TBA: Something about F#}";
        infoUrl = None; // !TBD Update
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2015-09-17" ); // !TBD: update
    };
    {
        event = functionalLondoners;
        appearanceType = AppearanceType.Talk;
        title = "Seeking Simplicity";
        infoUrl = None; // !TBD Update
        videoUrl = None;
        imageName = None;
        date = System.DateTime.Parse( "2015-10-08" ); // !TBD: update
    };
]

