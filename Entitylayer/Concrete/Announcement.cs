using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitylayer.Concrete
{
    public class Announcement
    {
        
        [Key]
        public int AnnouncementID { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "Title is too long.")]
        public string AnnouncementTitle { get; set; }
        [Required]
        public string AnnouncementDesc { get; set; }
        public bool AnnouncementStatus { get; set; }
    }
}
