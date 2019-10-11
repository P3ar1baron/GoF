using System;

namespace Prototype
{
     class CalendarEvent : CalendarPrototype
    {
        public Attendee[] Attendees { get; set; }
        public Priority Priority { get; set; }
        public DateTime StartDateAndTime { get; set; }
    }
}
