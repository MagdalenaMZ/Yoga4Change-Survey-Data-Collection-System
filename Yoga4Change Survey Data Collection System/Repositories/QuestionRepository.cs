﻿using Microsoft.EntityFrameworkCore;
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

        public Task<int> AddQuestionAsync(Question question)
        {
            _context.Questions.AddAsync(question);
            return _context.SaveChangesAsync();
        }

        public Task<int> DeleteQuestionAsync(int id)
        {
           var question = _context.Questions.Find(id);
           if (question != null) _context.Questions.Remove(question);
           return _context.SaveChangesAsync();
        }
    }
}