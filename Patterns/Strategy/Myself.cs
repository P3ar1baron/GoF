using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Myself
    {
        private IWearingStrategy _wearingStrategy = new DefaultWearingStrategy();

        public void ChangeStrategy(IWearingStrategy wearingStrategy)
        {
            _wearingStrategy = wearingStrategy;
        }

        public void GoOutside()
        {
            var clothes = _wearingStrategy.GetClothes();
            var accessories = _wearingStrategy.GetAccessories();
            Console.WriteLine("Today {0}, {1}",clothes,accessories);
        }
    }
}
