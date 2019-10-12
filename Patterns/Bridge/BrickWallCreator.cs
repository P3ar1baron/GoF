namespace Bridge
{
    class BrickWallCreator : IWallCreator
    {
        public void BuildWallWithWindow()
        {
            System.Console.WriteLine("Brick wall with window");
        }

        public void BuildWallWithDoor()
        {
            System.Console.WriteLine("Brick wall with door");
        }

        public void BuildWall()
        {
            System.Console.WriteLine("Brick wall");
        }

        public void BuildRoof()
        {
            System.Console.WriteLine("Brick roof");
        }
    }
}
