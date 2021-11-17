using Microsoft.AspNetCore.Mvc;
using site.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site.Controllers
{
    [ApiController]
    [Route("/River")]
    public class RiverController : Controller
    {

        [HttpGet("GetRiver")]
        public ViewResult GetRiver()
        {
            return View();
        }

        private readonly IRiver _riverId;

        public RiverController(IRiver riverId)
        {
            _riverId = riverId;
        }

        [HttpPut("UpdateRiver")]
        public ViewResult UpdateRiver()
        {
            var riverId = _riverId.GetRiverId;
            return View(riverId);
        }

        [HttpDelete("DeleteRiver")]
        public ViewResult DeleteRiver()
        {
            var riverId = _riverId.GetRiverId;
            return View(riverId);
        }

    }
}

