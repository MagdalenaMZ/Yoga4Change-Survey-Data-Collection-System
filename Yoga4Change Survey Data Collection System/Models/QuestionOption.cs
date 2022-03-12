using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yoga4Change_Survey_Data_Collection_System.Models
{
    public class QuestionOption
    {
        public QuestionOption()
        {
            CreatedAt = DateTime.UtcNow;
            LastModifiedAt = DateTime.UtcNow;
        }
        public int ID { get; set; }

        public string Content { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset LastModifiedAt { get; set; }

        public int QuestionId { get; set; }

        public int OrderInQuestion { get; set; }

        public virtual Question Question { get; set; }

    }
}
