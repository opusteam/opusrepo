using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain
{
    public class CancelReason
    {
        public int Id { get; set; }
        public string Reason { get; set; }
        public bool Published { get; set; }
    }
}
