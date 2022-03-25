using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yoga4Change_Survey_Data_Collection_System.Models.Enums;

namespace Yoga4Change_Survey_Data_Collection_System.Models.ViewModel
{
    public class UpdateQuestionModel
    {
        public UpdateQuestionModel()
        {
            CreatedAt = DateTime.UtcNow;
            LastModifiedAt = DateTime.UtcNow;
        }

        public UpdateQuestionModel(Question question)
        {
            ID = question.ID;
            Content = question.Content;
            TypeId = question.TypeId;
            CreatedAt = question.CreatedAt;
            LastModifiedAt = question.LastModifiedAt;
            QuestionsOptions = question.QuestionsOptions.Select(x => x.Content).ToList();
        }

        public int ID { get; set; }
        public string Content { get; set; }

        public QuestionType TypeId { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset LastModifiedAt { get; set; }

        public List<string> QuestionsOptions { get; set; }

    }
}
