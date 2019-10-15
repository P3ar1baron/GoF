using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class SkiRent
    {
        public int RentBoots(int feetSize,
                             int skierLevel)
        {
            return 20;
        }

        public int RentSki(int weight,
                           int skierLevel)
        {
            return 40;
        }

        public int RentRole(int height)
        {
            return 5;
        }
    }
}
