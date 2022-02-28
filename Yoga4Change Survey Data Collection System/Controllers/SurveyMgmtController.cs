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

        public SurveyMgmtController(ISurveyRepository surveyRepository)
        {
            _surveyRepository = surveyRepository;
        }

        public ViewResult CreateSurvey()
        {
            return View();
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
