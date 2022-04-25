using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yoga4Change_Survey_Data_Collection_System.Models.Enums;

namespace Yoga4Change_Survey_Data_Collection_System.Models.ViewModel
{
    public class AddQuestionPostModel
    {
        public AddQuestionPostModel()
        {
            CreatedAt = DateTime.UtcNow;
            LastModifiedAt = DateTime.UtcNow;
        }
        public string Content { get; set; }

        public QuestionType TypeId { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset LastModifiedAt { get; set; }
        public bool Draft { get; set; }

        public List<string> QuestionsOptions { get; set; }

        public Question ToQuestion()
        {
            return new Question()
            {
                Content = Content,
                Draft = Draft,
                TypeId = TypeId,
                CreatedAt = CreatedAt,
                LastModifiedAt = LastModifiedAt
            };
        }
    }
}
