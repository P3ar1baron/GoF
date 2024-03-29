﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Bulder
{
    abstract class LaptopBuilder
    {
        protected Laptop Laptop { get; private set; }

        public void CreateNewLaptop()
        {
            Laptop = new Laptop();
        }

        public Laptop GetMyLaptop()
        {
            return Laptop;
        }

        public abstract void SetMonitorResolution();
        public abstract void SetProcessor();
        public abstract void SetMemory();
        public abstract void SetHDD();
        public abstract void SetBattery();


    }
}
