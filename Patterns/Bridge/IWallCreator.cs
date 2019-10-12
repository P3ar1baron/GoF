using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    interface IWallCreator
    {
        void BuildWallWithDoor();
        void BuildWall();
        void BuildWallWithWindow();
        void BuildRoof();
    }
}
