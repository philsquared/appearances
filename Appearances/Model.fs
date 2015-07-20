module Model

type EventType = Conference | Meetup | Podcast
type AppearanceType = Keynote | Talk | LightningTalk | MiniTalk | Panel | Interview

type Location = {
    city : string;
    country : string;
}

type Event = {
    eventType : EventType;
    name : string;
    location : Location option;
    url : string option;
}

type Appearance = {
    event : Event;
    appearanceType : AppearanceType;
    title : string;
    infoUrl : string option;
    videoUrl : string option;
    imageName : string option;
    date : System.DateTime;
}
