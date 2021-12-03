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
    public class SurveyMgmtController : Controller
    {
        public ViewResult CreateSurvey()
        {
            return View();
        }
    }
}
