using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Yoga4Change_Survey_Data_Collection_System.Models.Enums;


namespace Yoga4Change_Survey_Data_Collection_System.Models
{
    public class Question
    {
        public Question()
        {
            CreatedAt = DateTime.UtcNow;
            LastModifiedAt = DateTime.UtcNow;
        }
        [Key]

        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Question")]
        public string Content  { get; set; }

        [Display(Name = "Type")]
        public QuestionType TypeId { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedAt { get; set; }

        [Display(Name = "Modified")]
        public DateTimeOffset LastModifiedAt { get; set; }

        public ICollection<QuestionOption> Options { get; set; }
    }
}
