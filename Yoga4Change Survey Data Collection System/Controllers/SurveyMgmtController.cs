using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Yoga4Change_Survey_Data_Collection_System.Models;

namespace Yoga4Change_Survey_Data_Collection_System.Controllers
{
    public class SurveyMgmtController : Controller
    {
        [HttpPost]
        public ViewResult CreateSurvey()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Surveys()
        {
            var s = new List<Survey>();
            s.Add(new Survey { ID = 1, Name = "", Questions = new Survey.Question { ID = 1, Content = "", Type = "", Required = true }, Published = false });
            s.Add(new Survey { ID = 2, Name = "", Questions = new Survey.Question { ID = 2, Content = "", Type = "", Required = true }, Published = false });
            s.Add(new Survey { ID = 3, Name = "", Questions = new Survey.Question { ID = 3, Content = "", Type = "", Required = true }, Published = false });

            return View(s);
        }
    }
}
