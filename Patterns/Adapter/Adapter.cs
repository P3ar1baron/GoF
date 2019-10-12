using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Adapter : INewElectricitySystem
    {
        readonly OldElectricitySystem _adaptee;
        public Adapter(OldElectricitySystem adaptee)
        {
            _adaptee = adaptee;
        }
        public string MatchWideSocket()
        {
            return _adaptee.MatchThinSocket();
        }
    }
}
