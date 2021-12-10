using System;
using System.Collections.Generic;
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

        public int ID { get; set; }

        public string Content  { get; set; }

        public QuestionType TypeId { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset LastModifiedAt { get; set; }

       public ICollection<QuestionOption> Options { get; set; }
    }
}
