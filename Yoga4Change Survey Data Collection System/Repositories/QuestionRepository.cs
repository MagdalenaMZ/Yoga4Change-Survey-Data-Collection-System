using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yoga4Change_Survey_Data_Collection_System.EntityFramework;
using Yoga4Change_Survey_Data_Collection_System.Models;
using Yoga4Change_Survey_Data_Collection_System.Repositories.Interfaces;

namespace Yoga4Change_Survey_Data_Collection_System.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly Y4CDbContext _context;
        public QuestionRepository(Y4CDbContext context)
        {
            _context = context;
        }

        public Task<List<Question>> GetQuestionListAsync()
        {
            return _context.Questions.ToListAsync();
        }


        public async Task<Question> AddQuestionAsync(Question question)
        {
            var entity = _context.Questions.Add(question);
            await _context.SaveChangesAsync();
            return entity.Entity;
        }

        public Task<int> DeleteQuestionAsync(int id)
        {
           var question = _context.Questions.Find(id);
           if (question != null) _context.Questions.Remove(question);
           return _context.SaveChangesAsync();
        }

        public Task<int> UpdateQuestionAsync(int id)
        {
            var question = _context.Questions.Find(id);
            _context.Entry(question).State = EntityState.Modified;
            return _context.SaveChangesAsync();
        }

        public Task<int> UpdateQuestionAsync(Question question)
        {
            _context.Entry(question).State = EntityState.Modified;
            return _context.SaveChangesAsync();
        }
    }
}
