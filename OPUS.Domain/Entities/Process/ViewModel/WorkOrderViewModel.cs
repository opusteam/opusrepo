using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain
{
  public  class WorkOrderViewModel
    {
        public int FeasibilityId { get; set; }
        [DisplayName("From Cable Id")]
        public string FromCableId { get; set; }
        [DisplayName("To Cable Id")]
        public string ToCableId { get; set; }
        [DisplayName("From Core Color")]
        public string FromCoreColor { get; set; }
        [DisplayName("To Core Color")]
        public string ToCoreColor { get; set; }
        public DateTime ConfirmationDate { get; set; }
    }
}
