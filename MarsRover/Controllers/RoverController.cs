using MarsRover.Enums;
using MarsRover.Models.Concrete;
using Microsoft.AspNetCore.Http;
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
            var t = TempData["Data"];
            return View();
        }
        public IActionResult GetData(IFormCollection datas)
        {
            int gx = int.Parse(datas["GroundX"]);
            int gy = int.Parse(datas["GroundY"]);
            Ground ground = new Ground(new Position(gx, gy));
           
            int roverX = int.Parse(datas["PositionX"]);
            int roverY = int.Parse(datas["PositionY"]);

            int roverDrInt = int.Parse(datas["Direction"]);
            Directions roverDr = (Directions)roverDrInt;
            Rover rover = new Rover(ground, new Position(roverX, roverY), roverDr);
            string commands = datas["Command"];
            rover.Process(commands);
            TempData["Data"] = rover.ToString();

            return RedirectToAction("Home", "Rover");
        }
    }
}
