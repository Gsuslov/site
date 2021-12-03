using Microsoft.AspNetCore.Mvc;
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
             

    }
}

