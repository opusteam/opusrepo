using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain
{
   public class ContactViewModel
    {
        [Required]
        [StringLength(160, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public string Phone { get; set; }
        public string Fax { get; set; }
        [Required]
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
