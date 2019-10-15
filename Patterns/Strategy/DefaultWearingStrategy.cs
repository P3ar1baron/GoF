using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class DefaultWearingStrategy : IWearingStrategy
    {
        public string GetClothes()
        {
            return "def";
        }

        public string GetAccessories()
        {
            return "default";
        }
    }
}
