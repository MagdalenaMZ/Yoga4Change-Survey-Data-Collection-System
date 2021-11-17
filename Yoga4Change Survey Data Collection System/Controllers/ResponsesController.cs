using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Yoga4Change_Survey_Data_Collection_System.Models;

namespace Yoga4Change_Survey_Data_Collection_System.Controllers
{
    public class ResponsesController : Controller
    {
        private readonly ILogger<ResponsesController> _logger;

        public ResponsesController(ILogger<ResponsesController> logger)
        {
            _logger = logger;
        }
        public IActionResult CompleteSurveys()
        {
            return View("~/Views/Responses/CompleteSurveys.cshtml");
        }

        public IActionResult Dashboard()
        {
            return View("~/Views/Responses/Dashboard.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Responses()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

