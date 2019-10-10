using System;

namespace Bulder
{
    class Program
    {
        static void Main(string[] args)
        {
            var gamingBuilder = new GamingLaptopBuilder();
            var shopForYou = new BuyLaptop();
            shopForYou.SetLaptopBuilder(gamingBuilder);
            shopForYou.ConstructLaptop();
            Laptop laptop = shopForYou.GetLaptop();
            Console.WriteLine($"Here are characteristics : memory {0}",laptop.Memory);
            Console.ReadKey();
        }
    }
}
