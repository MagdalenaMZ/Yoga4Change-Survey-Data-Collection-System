using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yoga4Change_Survey_Data_Collection_System.Areas.Identity.Data;

namespace Yoga4Change_Survey_Data_Collection_System.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<Y4CUser> FindByIdAsync(string id);
        Task<List<IdentityRole>> GetRoleListAsync();


    }
}
