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
            s.Add(new Survey { ID = 1, Name = "Survey1", Questions = new Survey.Question { ID = 1, Content = "...", Type = "date", Required = true }, Published = false });
            s.Add(new Survey { ID = 2, Name = "Survey2", Questions = new Survey.Question { ID = 2, Content = "...", Type = "text", Required = true }, Published = false });
            s.Add(new Survey { ID = 3, Name = "Survey3", Questions = new Survey.Question { ID = 3, Content = "...", Type = "text", Required = true }, Published = false });

            return View(s);
        }
    }
}
