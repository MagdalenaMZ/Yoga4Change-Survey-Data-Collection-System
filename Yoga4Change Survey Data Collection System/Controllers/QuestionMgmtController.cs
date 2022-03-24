using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var questionEdit = await _dbContext.Questions.Include(x => x.QuestionsOptions).FirstOrDefaultAsync(q => q.ID == id);

            return View(new UpdateQuestionModel(questionEdit));
        }

        [HttpPost]
        public async Task<ViewResult> UpdateQuestionAsync(UpdateQuestionModel question)
        {
            if (!ModelState.IsValid)
            {
                // TO DO - ERROR
                return View("QuestionBank");
            }

            var existingQuestion = await _dbContext.Questions.FirstOrDefaultAsync(q => q.ID == question.ID);

            // TO DO if existing question == null ----> error

            if (existingQuestion.TypeId == QuestionType.Checkbox || existingQuestion.TypeId == QuestionType.Dropdown || existingQuestion.TypeId == QuestionType.LikertScale || existingQuestion.TypeId == QuestionType.Radio_Button)
            {
                var existingChoices = await _dbContext.QuestionsOptions.Where(c => c.QuestionId == existingQuestion.ID).ToListAsync();

                _dbContext.QuestionsOptions.RemoveRange(existingChoices);
                await _dbContext.SaveChangesAsync();
            }

            existingQuestion.Content = question.Content;
            existingQuestion.TypeId = question.TypeId;
            existingQuestion.LastModifiedAt = DateTime.UtcNow;


            _dbContext.Questions.Update(existingQuestion);
            await _dbContext.SaveChangesAsync();

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
                            QuestionId = existingQuestion.ID,
                            Content = optionText,
                            OrderInQuestion = i
                        };

                        choices.Add(choice);
                    }
                }
                _dbContext.QuestionsOptions.AddRange(choices);
                await _dbContext.SaveChangesAsync();
            }
                return View("SuccessUpdate");
            
        }

        public async Task<ViewResult> DuplicateQuestionAsync(int id)
        {
            var toCopy = await _dbContext.Questions.FirstOrDefaultAsync(q => q.ID == id);
            var options = await _dbContext.QuestionsOptions.Where(c => c.QuestionId == toCopy.ID).OrderBy(n => n.OrderInQuestion).ToListAsync();
            var newQuestion = new Question
            {
                Content = toCopy.Content,
                TypeId = toCopy.TypeId,
                CreatedAt = DateTime.Now,
                LastModifiedAt = DateTime.Now,
                QuestionsOptions = toCopy.QuestionsOptions
             };
                _dbContext.Questions.Add(newQuestion);
            _dbContext.QuestionsOptions.AddRange(options);

            await _dbContext.SaveChangesAsync();
            return View("SuccessAdd");
        }

    }
}

