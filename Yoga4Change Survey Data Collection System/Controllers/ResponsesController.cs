using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Yoga4Change_Survey_Data_Collection_System.Repositories.Interfaces;

namespace Yoga4Change_Survey_Data_Collection_System.Controllers
{
    public class ResponsesController : Controller
    {
        private readonly IResponseRepository _responseRepository;
        public ResponsesController(IResponseRepository responseRepository)
        {
            _responseRepository = responseRepository;
        }
        public ViewResult Dashboard()
        {
            return View();
        }
        public async Task<ViewResult> CompleteSurveys()
        {
            var responseList = await _responseRepository.GetResponseListAsync();
            return View(responseList);
            
        }

    }
}

