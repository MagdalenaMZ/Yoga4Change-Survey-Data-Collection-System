using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Yoga4Change_Survey_Data_Collection_System.Models;

namespace Yoga4Change_Survey_Data_Collection_System.Controllers
{
    [Authorize]
    public class SurveyMgmtController : Controller
    {
        public ViewResult CreateSurvey()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Surveys()
        {
            var s = new List<Survey>();
            s.Add(new Survey { ID = 1, Name = "Survey1", Questions = new Survey.Question { ID = 1, Content = "question1", Type = "date", Required = true }, Published = false });
            s.Add(new Survey { ID = 2, Name = "Survey2", Questions = new Survey.Question { ID = 1, Content = "question1", Type = "open-ended", Required = true }, Published = false });
            s.Add(new Survey { ID = 3, Name = "Survey3", Questions = new Survey.Question { ID = 1, Content = "question1", Type = "open-ended", Required = false }, Published = false });
            s.Add(new Survey { ID = 4, Name = "Survey4", Questions = new Survey.Question { ID = 1, Content = "question1", Type = "open-ended", Required = false }, Published = false });
            s.Add(new Survey { ID = 5, Name = "Survey5", Questions = new Survey.Question { ID = 1, Content = "question1", Type = "open-ended", Required = false }, Published = false });
            s.Add(new Survey { ID = 6, Name = "Survey6", Questions = new Survey.Question { ID = 1, Content = "question1", Type = "open-ended", Required = false }, Published = false });
            s.Add(new Survey { ID = 7, Name = "Survey7", Questions = new Survey.Question { ID = 1, Content = "question1", Type = "open-ended", Required = false }, Published = false });
            s.Add(new Survey { ID = 8, Name = "Survey8", Questions = new Survey.Question { ID = 1, Content = "question1", Type = "open-ended", Required = false }, Published = false });
            s.Add(new Survey { ID = 9, Name = "Survey9", Questions = new Survey.Question { ID = 1, Content = "question1", Type = "open-ended", Required = false }, Published = false });
            s.Add(new Survey { ID = 10, Name = "Survey10", Questions = new Survey.Question { ID = 1, Content = "question1", Type = "open-ended", Required = false }, Published = false });

            return View(s);
        }
    }
}
