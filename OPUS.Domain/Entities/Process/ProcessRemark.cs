using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain
{
    public class ProcessRemark
    {
        public int Id { get; set; }
        public int FeasibilityId { get; set; }
        public string Remarksfor { get; set; }
        public string Remarks { get; set; }
        public string Remarksby { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
