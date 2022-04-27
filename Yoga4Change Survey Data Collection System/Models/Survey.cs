using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Yoga4Change_Survey_Data_Collection_System.Models.ViewModel;

namespace Yoga4Change_Survey_Data_Collection_System.Models
{
    public class Survey
    {
        public Survey()
        {
            //AddSurveyViewModel questionBank = new AddSurveyViewModel();

            //Questions.Add(questionBank.Questions.FirstOrDefault());

            //Debug.WriteLine(Questions.FirstOrDefault()); these lines are for debugging or could be used to populate a new survey with questions automatically
        }

        [Key]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Questions")]
        public ICollection<SurveyQuestion> Questions { get; set; }

        [Display(Name = "IsPublished")]
        public bool Published { get; set; }
    }
}
