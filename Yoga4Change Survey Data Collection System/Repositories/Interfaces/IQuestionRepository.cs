﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Yoga4Change_Survey_Data_Collection_System.Models;

namespace Yoga4Change_Survey_Data_Collection_System.Repositories.Interfaces
{
    public interface IQuestionRepository
    {
        Task<List<Question>> GetQuestionListAsync();
        Task<int> AddQuestionAsync(Question question);
        Task<int> DeleteQuestionAsync(int id);
    }

}