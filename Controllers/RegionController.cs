using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site.Controllers
{

    [ApiController]
    [Route("/Region")]
    public class RegionController : Controller
    {
        [HttpGet("GetRegion")]
        public ActionResult GetRegion()
        {
            return View();
        }

        [HttpPut("CreateRegion")]
        public ActionResult CreateRegion()
        {
            return View();
        }

        [HttpPut("UpdateRegion")]
        public ActionResult UpdateBRegion()
        {
            return View();
        }

        [HttpDelete("DeleteRegion")]
        public ActionResult DeliteRegion()
        {
            return View();
        }
    }
}

