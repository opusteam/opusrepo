using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OPUS.Domain
{
    public class FinalPlan
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int FeasibilityId { get; set; }
        public string LinkId { get; set; }
        public string FromPOCSite { get; set; }
        public string ToPOCSite { get; set; }
        public string FromCoreId { get; set; }
        public string ToCoreId { get; set; }
        public string LinkBudget { get; set; }       
        public string Remarks { get; set; }
    }
}
