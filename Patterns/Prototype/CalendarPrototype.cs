using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class CalendarPrototype
    {
        public virtual CalendarPrototype Clone()
        {
            var copyOfType = (CalendarPrototype)this.MemberwiseClone();
            return copyOfType;
        }
    }
}
