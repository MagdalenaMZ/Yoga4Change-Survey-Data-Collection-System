using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yoga4Change_Survey_Data_Collection_System.Models
{
    public partial class CompletedSurveysModels
    {
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public string ResponseStatus { get; set; }
        public int Progress { get; set; }
        public int Duration { get; set; }
        public bool Finished { get; set; }
        public int RecordedDate { get; set; }
        public string ResponseID { get; set; }
        public string RecipientLastName { get; set; }
        public string RecipientFirstName { get; set; }
        public Nullable<int> RecipientEmail { get; set; }
        public Nullable<int> ExternalReference { get; set; }
        public int LocationLongitude { get; set; }
        public string LocationLatititude { get; set; }
        public string DistributionChannel { get; set; }
        public string UserLanguage { get; set; }
        public int MyProperty { get; set; }


    }
}



  