using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yoga4Change_Survey_Data_Collection_System.Models.ViewModel
{
    public class AddSurveyViewModel
    {
        public IEnumerable<Question> Questions { get; set; }
        public Survey Survey { get; set; }
    }
}
