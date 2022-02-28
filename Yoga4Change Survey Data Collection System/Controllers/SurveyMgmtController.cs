using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yoga4Change_Survey_Data_Collection_System.Models;
using Yoga4Change_Survey_Data_Collection_System.Repositories.Interfaces;

namespace Yoga4Change_Survey_Data_Collection_System.Controllers
{
    public class SurveyMgmtController : Controller
    {
        private readonly ISurveyRepository _surveyRepository;
        private readonly IQuestionRepository _questionRepository;

        public SurveyMgmtController(ISurveyRepository surveyRepository, IQuestionRepository questionRepository)
        {
            _surveyRepository = surveyRepository;
            _questionRepository = questionRepository;
        }

        public ViewResult CreateSurvey()
        {
            return View();
        }

        //temporary: delete this after testing along with Create view
        public async Task<ViewResult> CreateAsync()
        {
            var questionList = await _questionRepository.GetQuestionListAsync();
            return View(questionList);
        }

        public async Task<ViewResult> AddSurveyAsync(Survey survey)
        {
            await _surveyRepository.AddSurveyAsync(survey);
            return View("SuccessAdd");
        }

        public async Task<ViewResult> SurveyListAsync()
        {
            var surveyList = await _surveyRepository.GetSurveyListAsync();
            return View(surveyList);
        }

        public async Task<ViewResult> DeleteSurveyAsync(int id)
        {
            await _surveyRepository.DeleteSurveyAsync(id);
            return View("SuccessDelete");
        }

        [HttpGet]
        public ViewResult Surveys()
        {
            

            return View();
        }
    }
}
