using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yoga4Change_Survey_Data_Collection_System.Models
{
    public class Repository
    {
        private static List<Question> questions = new List<Question>();
        public static IEnumerable<Question> Questions
        {
            get
            {
                return questions;
            }
        }
        public static void AddQuestion(Question question)
        {
            questions.Add(question);
        }
    }
}
