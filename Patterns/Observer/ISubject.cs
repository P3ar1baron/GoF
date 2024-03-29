﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface ISubject
    {
        void AttachObserver(IObserver observer);
        void DetachObserver(IObserver observer);
        void Notify();
    }
}
