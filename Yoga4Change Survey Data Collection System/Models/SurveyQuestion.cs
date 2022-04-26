using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Yoga4Change_Survey_Data_Collection_System.Models
{
    public class SurveyQuestion
    {
        public SurveyQuestion()
        {

        }

        [Key]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Survey ID")]
        public int SurveyId { get; set; }

        [Required]
        [Display(Name = "Question ID")]
        public int QuestionId { get; set; }

        [Display(Name = "Order in Survey")]
        public int OrderInSurvey { get; set; }

        public Survey Survey { get; set; }
        public Question Question { get; set; }
    }
}
