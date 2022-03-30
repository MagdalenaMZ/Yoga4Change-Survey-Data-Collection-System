using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Yoga4Change_Survey_Data_Collection_System.Models;

namespace Yoga4Change_Survey_Data_Collection_System.Models
{
    public class Survey
    {
        public Survey()
        {

        }

        [Key]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        //[Display(Name = "Questions")]
        //public List<Question> Questions { get; set; }

        [Display(Name = "IsPublished")]
        public bool Published { get; set; }

        //public Question Questions { get; set; }
        
        /* subclass is unnecessary
        public class Question
        {
            public int ID { get; set; }
            public string Content { get; set; }
            public string Type { get; set; }
            public bool Required { get; set; }
            //NOTE: required property should be changeable on a per-survey basis e.g., a question can be required in one survey but optional in another
        }
        */
    }
}
