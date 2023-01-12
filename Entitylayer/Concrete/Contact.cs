using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitylayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "Name is too long.")]
        public string ContactName { get; set; }
        [Required]
        [EmailAddress]
        public string ContactEmail{ get; set; }
        [Required]
        [Phone]
        public string ContactPhone{ get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Company name is too long.")]
        public string ContactCompanyName { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Subject is too long.")]
        public string ContactSubject { get; set; }
        [Required]
        public string ContacMessage { get; set; }
        public bool ContactStatus { get; set; }
    }
}
