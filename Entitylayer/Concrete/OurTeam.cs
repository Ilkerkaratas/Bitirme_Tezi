using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitylayer.Concrete
{
    public   class OurTeam
    {
        [Key]
        public int OurTeamID { get; set; }
        public bool OurTeamStatus { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "Name is too long.")]
        
        public string OurTeamName { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Job is too long.")]
        public string OurTeamJob { get; set; }
        public string OurTeamImage { get; set; }
        [Required]        
        public string OurTeamDescription { get; set; }
        
        [EmailAddress]
        public string OurTeamMail { get; set; }

        public string OurTeamLinkedIn { get; set; }
        public string OurTeamInstagram { get; set; }


        
    }
}
