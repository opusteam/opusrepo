using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Client Name")]
        public string Name { get; set; }

        [DisplayName("Short Name")]
        public string ShortName { get; set; }

        [DisplayName("Business Type")]
        [Required]
        public int BusinessTypeId { get; set; }

        public DateTime RegDate { get; set; }

        [DisplayName("Office Address")]
        [DataType(DataType.MultilineText)]
        public string OfficeAddress { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public string Fax { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Url)]
        [DisplayName("Web Site")]
        public string WebSite { get; set; }
        public string City { get; set; }
        public string Region { get; set; }

        [DisplayName("Postal Code")]
        public string PostalCode { get; set; }

        [DisplayName("Billing Department")]
        public string BillingDepartment { get; set; }

        [DisplayName("Vat No")]
        public string VatNo { get; set; }

        public IList<ContactDetail> ContactDetails { get; set; }

        [DataType(DataType.MultilineText)]
        public string Note { get; set; }

        [DisplayName("KAM Name")]
        public string KamId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

       
    }
}
