using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AS_DojoSurveyModel.Models;

namespace AS_DojoSurveyModel.Controllers
{
    public class HomeController : Controller
    {
    
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("Result")] ///this is the route?
        public IActionResult PostMethod(User newUser)
        {
            return View("Result", newUser);
        }
        
    }
}
