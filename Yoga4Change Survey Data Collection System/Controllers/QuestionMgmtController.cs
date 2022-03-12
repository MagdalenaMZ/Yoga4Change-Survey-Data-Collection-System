using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yoga4Change_Survey_Data_Collection_System.EntityFramework;
using Yoga4Change_Survey_Data_Collection_System.Models;
using Yoga4Change_Survey_Data_Collection_System.Models.Enums;
using Yoga4Change_Survey_Data_Collection_System.Models.ViewModel;
using Yoga4Change_Survey_Data_Collection_System.Repositories.Interfaces;

namespace Yoga4Change_Survey_Data_Collection_System.Controllers
{
    public class QuestionMgmtController : Controller
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IQuestionOptionRepository _questionOptionRepository;
        private readonly Y4CDbContext _dbContext;

        public QuestionMgmtController(IQuestionRepository questionRepository, IQuestionOptionRepository questionOptionRepository, Y4CDbContext dbContext)
        {
            _questionRepository = questionRepository;
            _questionOptionRepository = questionOptionRepository;
            _dbContext = dbContext;
        }

        [HttpGet]
        public ViewResult AddQuestion()
        {
            return View();
        }

        [HttpPost]
        public async Task<ViewResult> AddQuestionAsync(AddQuestionPostModel question)
        {
            var entity = await _questionRepository.AddQuestionAsync(question.ToQuestion());
 
            if (question.QuestionsOptions != null && (question.TypeId != QuestionType.Open_Ended || question.TypeId != QuestionType.Yes_No || question.TypeId != QuestionType.Date_Time))
            {
                var choices = new List<QuestionOption>();

                for (var i = 0; i < question.QuestionsOptions.Count; i++)
                {
                    var optionText = question.QuestionsOptions[i];
                    if (optionText != null)
                    {
                        var choice = new QuestionOption
                        {
                            QuestionId = entity.ID,
                            Content = optionText,
                            OrderInQuestion = i
                        };

                        choices.Add(choice);
                    }
                }             
                _dbContext.QuestionsOptions.AddRange(choices);
                await _dbContext.SaveChangesAsync();
            }
            return View("SuccessAdd");
        }
        public async Task<ViewResult> QuestionBankAsync()
        {

            var questionList = await _questionRepository.GetQuestionListAsync();
            return View(questionList);
        }

        public async Task<ViewResult> DeleteQuestionAsync(int id)
        {
            await _questionRepository.DeleteQuestionAsync(id);
            return View("SuccessDelete");
        }

        [HttpGet]
        public async Task<ViewResult> UpdateQuestionAsync(int id)
        {
            var questionEdit = await _dbContext.Questions.FirstOrDefaultAsync(q => q.ID == id);
            return View(questionEdit);
        }

        [HttpPost]
        public async Task<ViewResult> UpdateQuestionAsync(Question question)
        {
            if (ModelState.IsValid)
            {
                await _questionRepository.UpdateQuestionAsync(question);
                return View("SuccessUpdate");

            }
            else
            {
                return View(question);
            }
        }

    }
}

