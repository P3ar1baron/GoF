using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var me = new Myself();
            me.ChangeStrategy(new AnotherWearingStrategy());
            me.GoOutside();
        }
    }
}
