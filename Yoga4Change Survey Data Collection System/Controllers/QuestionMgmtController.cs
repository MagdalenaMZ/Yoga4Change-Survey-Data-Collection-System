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
    public class QuestionMgmtController : Controller
    {

        [HttpGet]
        public ViewResult AddQuestion()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddQuestion(Question question )
        {
            Repository.AddQuestion(question);
            return View("Success");
        }
        public ViewResult QuestionBank()
        {
            var questionList = new List<Question>();
            var question1 = new Question
            {
                ID = 1,
                Content = "Are you currently a student of Yoga 4 Change?",
                Type = "Yes/No",
                Required = "Required"
            };
            var question2 = new Question
            {
                ID = 2,
                Content = "How did you hear about Yoga 4 Change first time?",
                Type = "Open ended",
                Required = "Optional"
            };
            var question3 = new Question
            {
                ID = 3,
                Content = "In which facility did you attend Yoga 4 Change classes?",
                Type = "Dropdown",
                Required = "Required"
            };

            questionList.Add(question1);
            questionList.Add(question2);
            questionList.Add(question3);
            return View(questionList);
        }
    }
}

