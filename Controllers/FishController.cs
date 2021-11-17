using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site.Controllers
{
    [ApiController]
    [Route("/Fish")]
    public class FishController : Controller
    {
        [HttpGet("GetFish")]
        public ActionResult GetFish()
        {
            return View();
        }

        [HttpPut("CreateFish")]
        public ActionResult CreateFish()
        {
            return View();
        }

        [HttpPut("UpdateFish")]
        public ActionResult UpdateFish()
        {
            return View();
        }

        [HttpDelete("DeleteBait")]
        public ActionResult DeliteFish()
        {
            return View();
        }


    }
}

