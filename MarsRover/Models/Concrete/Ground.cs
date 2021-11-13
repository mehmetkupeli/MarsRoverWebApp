using MarsRover.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRover.Models.Concrete
{
    public class Ground:IGround
    {
        public Position GroundPosition { get; set; }
        //Add Constructor 
        public Ground(Position position)
        {
            GroundPosition = position;
        }
    }
}
