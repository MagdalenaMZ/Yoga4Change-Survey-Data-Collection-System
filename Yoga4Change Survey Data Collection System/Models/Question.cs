using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Yoga4Change_Survey_Data_Collection_System.Models.Enums;


namespace Yoga4Change_Survey_Data_Collection_System.Models
{
    public class Question
    {
        public Question()
        {
            CreatedAt = DateTime.Now;
            LastModifiedAt = DateTime.Now;
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

        public virtual ICollection<QuestionOption> QuestionsOptions { get; set; }

    }
}
