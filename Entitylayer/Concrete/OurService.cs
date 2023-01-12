using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitylayer.Concrete
{
    public class OurService
    {
        [Key]
        public int OurServiceID { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "Name is too long.")]
        public string OurServiceName { get; set; }
        [Required]
        public string OurServiceDesc { get; set; }
        public string OurServiceimg { get; set; }
        public bool OurServiceStatus { get; set; }
    }
}
