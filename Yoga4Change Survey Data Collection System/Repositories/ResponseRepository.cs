using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yoga4Change_Survey_Data_Collection_System.EntityFramework;
using Yoga4Change_Survey_Data_Collection_System.Models;
using Yoga4Change_Survey_Data_Collection_System.Repositories.Interfaces;

namespace Yoga4Change_Survey_Data_Collection_System.Repositories
{
    public class ResponseRepository : IResponseRepository
    {
        private readonly Y4CDbContext _context; 
        public ResponseRepository(Y4CDbContext context)
        {
            _context = context;
        }

        public Task<List<Response>> GetResponseListAsync()
        {
            return _context.Responses.ToListAsync();
        }
    }
}
