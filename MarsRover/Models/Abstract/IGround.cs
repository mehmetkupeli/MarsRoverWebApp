using MarsRover.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRover.Models.Abstract
{
    public interface IGround
    {
        Position GroundPosition { get; }
    }
}
