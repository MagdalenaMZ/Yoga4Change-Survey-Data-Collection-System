using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//using Yoga4Change_Survey_Data_Collection_System.Models.Enums;

namespace Yoga4Change_Survey_Data_Collection_System.Models
{
    public class Response
    {
        public Response()
        {
            
        }
        [Key]
        [Display(Name ="ID")]
        public int Response_ID { get; set; }
        [Display(Name = "Question ID")]
        public int Question_ID { get; set; }
        [Display(Name = "Survey ID")]
        public int Survey_ID { get; set; }
        [Display(Name = "Response Content")]
        public string Response_Content { get; set; }
        
      // public virtual List<ResponseOption> Options { get; set; }
    }
}



  