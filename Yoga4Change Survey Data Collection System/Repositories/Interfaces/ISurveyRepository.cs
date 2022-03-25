using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yoga4Change_Survey_Data_Collection_System.Models;

namespace Yoga4Change_Survey_Data_Collection_System.Repositories.Interfaces
{
    public interface ISurveyRepository
    {
        Task<List<Survey>> GetSurveyListAsync();
        Task<int> AddSurveyAsync(Survey survey);
        Task<int> EditSurveyAsync(int id);
        Task<int> DeleteSurveyAsync(int id);
    }
}
