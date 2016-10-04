using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain
{
    public class WorkOrder
    {
        public int Id { get; set; }
        public int FeasibilityId { get; set; }
        public string Remarks { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
    }
}
