using System;
using System.Runtime.InteropServices;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
           IToyFactory toyFactory = new WoodenToysFactory();
           Bear bear = toyFactory.GetBear();
           Cat cat = toyFactory.GetCat();
           Console.WriteLine("I've got {0} and {1}", bear.name, cat.name);

           IToyFactory anotherToyFactory = new TeddyToysFactory();
           Bear anotherBear = anotherToyFactory.GetBear();
           Cat anotherCat = anotherToyFactory.GetCat();
           Console.WriteLine("Here is {0} and {1}",anotherBear.name,anotherCat.name);

           Console.ReadLine();
        }
    }
}
