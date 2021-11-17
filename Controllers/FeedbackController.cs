using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site.Controllers
{
    [ApiController]
    [Route("/Feedback")]
    public class FeedbackController : Controller
    {
        [HttpGet("GetFeedback")]
        public ActionResult GetFeedback()
        {
            return View();
        }

        [HttpPut("CreateFeedback")]
        public ActionResult CreateFeedback()
        {
            return View();
        }

        [HttpPut("UpdateFeedback")]
        public ActionResult UpdateFeedback()
        {
            return View();
        }

        [HttpDelete("DeleteFeedback")]
        public ActionResult DeliteFeedback()
        {
            return View();
        }

    }
}

