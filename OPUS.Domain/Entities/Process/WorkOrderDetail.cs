using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain
{
    public class WorkOrderDetail
    {
        public int Id { get; set; }
        public int WorkOrderId { get; set; }
        public string FromCableId { get; set; }
        public string ToCableId { get; set; }
        public string FromCoreColor { get; set; }
        public string ToCoreColor { get; set; }
    }
}
