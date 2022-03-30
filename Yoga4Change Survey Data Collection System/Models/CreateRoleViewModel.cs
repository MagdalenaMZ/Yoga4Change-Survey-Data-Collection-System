using System.ComponentModel.DataAnnotations;

namespace Yoga4Change_Survey_Data_Collection_System.Models
{
    public class CreateRoleViewModel
    {
        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }
    }
}
