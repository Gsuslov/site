using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site.Controllers
{
    [ApiController]
    [Route("/Bait")]
    public class BaitController : ControllerBase
    {
        [HttpGet("GetBait")]
        public string GetBait()
        {
            return "MyBait";
        }

        [HttpPut("CreateBait")]
        public ActionResult CreateBait()
        {
            return View();
        }

        [HttpPut("UpdateBait")]
        public ActionResult UpdateBait()
        {
            return View();
        }

        [HttpDelete("DeleteBait")]
        public ActionResult DeliteBait()
        {
            return View();
        }

    }
}
