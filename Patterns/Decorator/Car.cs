using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Car
    {
        protected String BrandName { get; set; }
        public virtual void Go()
        {
            Console.WriteLine("I'm" + BrandName + " and I'm on my way...");
        }
    }
}
