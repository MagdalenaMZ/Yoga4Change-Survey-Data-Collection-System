
using System.ComponentModel.DataAnnotations;


namespace Yoga4Change_Survey_Data_Collection_System.Models.Enums
{
    public enum QuestionType
    {
        [Display(Name = "Open Ended")]
        Open_Ended = 1,

        [Display(Name = "Yes/No")]
        Yes_No = 2,

        [Display(Name = "Date")]
        Date_Time = 3,

        [Display(Name = "Radio Button")]
        Radio_Button = 4,

        [Display(Name = "Checkbox")]
        Checkbox = 5,

        [Display(Name = "Dropdown")]
        Dropdown = 6,

        [Display(Name = "Likert Scale")]
        LikertScale = 7
    }

}
