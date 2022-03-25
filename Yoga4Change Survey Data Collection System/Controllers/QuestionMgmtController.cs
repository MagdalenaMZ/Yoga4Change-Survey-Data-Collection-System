using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Yoga4Change_Survey_Data_Collection_System.Models;
using Yoga4Change_Survey_Data_Collection_System.Repositories;
using Yoga4Change_Survey_Data_Collection_System.Repositories.Interfaces;

namespace Yoga4Change_Survey_Data_Collection_System.Controllers
{
    [Authorize]
    public class QuestionMgmtController : Controller
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionMgmtController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        [HttpGet]
        public ViewResult AddQuestion()
        {
            return View();
        }

        [HttpPost]
        public async Task<ViewResult> AddQuestionAsync(Question question )
        {
            await _questionRepository.AddQuestionAsync(question);
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

    }
}

