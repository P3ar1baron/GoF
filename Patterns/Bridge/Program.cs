using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var brickWallCreator = new BrickWallCreator();
            var concreteSlabWallCreator = new ConcreteSlabWallCreator();

            var buildingCompany = new BuildingCompany();
            buildingCompany.BuildFoundation();

            buildingCompany.WallCreator = concreteSlabWallCreator;
            buildingCompany.BuildRoom();

            buildingCompany.WallCreator = brickWallCreator;
            buildingCompany.BuildRoom();
            buildingCompany.BuildRoom();

            buildingCompany.BuildRoof();

            Console.ReadLine();

        }
    }
}
