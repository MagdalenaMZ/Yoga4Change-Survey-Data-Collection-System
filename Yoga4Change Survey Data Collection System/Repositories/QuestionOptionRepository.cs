using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yoga4Change_Survey_Data_Collection_System.EntityFramework;
using Yoga4Change_Survey_Data_Collection_System.Models;
using Yoga4Change_Survey_Data_Collection_System.Repositories.Interfaces;

namespace Yoga4Change_Survey_Data_Collection_System.Repositories
{
    public class QuestionOptionRepository : IQuestionOptionRepository
    {
        private readonly Y4CDbContext _context;
        public QuestionOptionRepository(Y4CDbContext context)
        {
            _context = context;
        }
        public Task<List<QuestionOption>> GetQuestionOptionListAsync(int ID)
        {
            return _context.QuestionsOptions.Where(x => x.ID == ID).ToListAsync();
        }

        public Task<int> AddQuestionOptionAsync(QuestionOption questionOption)
        {
            _context.QuestionsOptions.Add(questionOption);
            return _context.SaveChangesAsync();
        }
    }
}
