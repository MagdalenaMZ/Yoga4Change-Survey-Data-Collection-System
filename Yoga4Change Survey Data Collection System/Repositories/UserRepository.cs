using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yoga4Change_Survey_Data_Collection_System.Areas.Identity.Data;
using Yoga4Change_Survey_Data_Collection_System.Repositories.Interfaces;

namespace Yoga4Change_Survey_Data_Collection_System.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly Y4CIdentityContext _context;
        public UserRepository(Y4CIdentityContext context)
        {
            _context = context;
        }

        public Task<Y4CUser> FindByIdAsync(string id)
        {
            return _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

         public Task<List<IdentityRole>> GetRoleListAsync()
         {
             return _context.Roles.ToListAsync();
         }

        
    }
}
