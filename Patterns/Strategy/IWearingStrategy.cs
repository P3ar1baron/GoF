using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    interface IWearingStrategy
    {
        string GetClothes();
        string GetAccessories();
    }
}
