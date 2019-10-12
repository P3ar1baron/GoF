using System;

namespace Bridge
{
    class ConcreteSlabWallCreator : IWallCreator
    {
        public void BuildWallWithWindow()
        {
            Console.WriteLine("Concrete slab wall with window");
        }

        public void BuildWallWithDoor()
        {
            Console.WriteLine("Concrete slab wall with door");
        }

        public void BuildWall()
        {
            Console.WriteLine("Concrete slab wall");
        }

        public void BuildRoof()
        {
            Console.WriteLine("Concrete slab roof");
        }
    }
}
