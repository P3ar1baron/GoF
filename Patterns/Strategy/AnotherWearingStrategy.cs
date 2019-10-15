using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class AnotherWearingStrategy : IWearingStrategy
    {
        public string GetClothes()
        {
            return "other";
        }

        public string GetAccessories()
        {
            return "other";
        }
    }
}
