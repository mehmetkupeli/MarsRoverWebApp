using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRover.Models.Abstract
{
    public interface IPosition
    {
        int PosX { get; set; }
        int PosY { get; set; }
    }
}
