using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRover.Controllers
{
    public class RoverController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult GetData()
        {
            return View();
        }
    }
}
