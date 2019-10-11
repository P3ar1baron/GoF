using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class CalendarPrototypeChild : CalendarPrototype
    {
        public override CalendarPrototype Clone()
        {
            var copy = (CalendarEvent)base.Clone();

            //var copiedAttendees = (Attendee[])Attendees.Clone();
            // copy.Priority = (Priority)Priority.Clone();

            return copy;
        }
    }
}
