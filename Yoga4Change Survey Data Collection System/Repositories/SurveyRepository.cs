using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yoga4Change_Survey_Data_Collection_System.EntityFramework;
using Yoga4Change_Survey_Data_Collection_System.Models;
using Yoga4Change_Survey_Data_Collection_System.Repositories.Interfaces;

namespace Yoga4Change_Survey_Data_Collection_System.Repositories
{
    public class SurveyRepository : ISurveyRepository
    {
        private readonly Y4CDbContext _context;
        public SurveyRepository(Y4CDbContext context)
        {
            _context = context;
        }

        public Task<List<Survey>> GetSurveyListAsync()
        {
            return _context.Surveys.ToListAsync();
        }

        public Task<int> AddSurveyAsync(Survey survey)
        {
            _context.Surveys.AddAsync(survey);
            return _context.SaveChangesAsync();
        }

        public Task<int> DeleteSurveyAsync(int id)
        {
            var survey = _context.Surveys.Find(id);
            if (survey != null) _context.Surveys.Remove(survey);
            return _context.SaveChangesAsync();
        }
    }
}
