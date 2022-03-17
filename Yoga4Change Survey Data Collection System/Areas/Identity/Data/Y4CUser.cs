using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Yoga4Change_Survey_Data_Collection_System.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the Y4CUser class
    public class Y4CUser : IdentityUser
    {
        internal IEnumerable<IdentityRole> identityRoles;
        public string FullName { get; set; }
        
    }
}
