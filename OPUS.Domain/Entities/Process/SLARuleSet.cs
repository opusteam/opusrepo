using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain
{
    public class SLARuleSet
    {
        public int Id { get; set; }
        public string InitiatorDepartment { get; set; }
        public string ResponsibleDepartment { get; set; }
        public string SLAKey { get; set; }
        public double SLAValueInHours { get; set; }
        public string SLAKeyDescription { get; set; }
        public string ProcessName { get; set; }

    }
}
