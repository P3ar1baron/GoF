﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bulder
{
    class GamingLaptopBuilder : LaptopBuilder
    {
        public override void SetMonitorResolution()
        {
            Laptop.MonitorResolution = "1900x1200";
        }

        public override void SetProcessor()
        {
            Laptop.Processor = "Core 2 Duo, 3.2 GHz";
        }

        public override void SetMemory()
        {
            Laptop.Memory = "6144 Mb";
        }

        public override void SetHDD()
        {
            Laptop.HDD = "500 Gb";
        }

        public override void SetBattery()
        {
            Laptop.Battery = "6 lbs";
        }


    }
}
