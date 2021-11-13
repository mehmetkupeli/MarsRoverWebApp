using MarsRover.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRover.Models.Concrete
{
    public class Position : IPosition
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        //Add Constructor 
        public Position(int x, int y)
        {
            PosX = x;
            PosY = y;
        }
    }
}
