using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Yoga4Change_Survey_Data_Collection_System.Models
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
            Claims = new List<string>();
            Roles = new List<IdentityRole>();
        }

        public string Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public List<string> Claims { get; set; }

        public IList<IdentityRole> Roles { get; set; }


    }
}

