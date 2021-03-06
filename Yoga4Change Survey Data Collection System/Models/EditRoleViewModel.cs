using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Yoga4Change_Survey_Data_Collection_System.Models
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }

        public string Id { get; set; }

        [Required(ErrorMessage = "Role Name is required")]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }

        public List<string> Users { get; set; }
    }
}
