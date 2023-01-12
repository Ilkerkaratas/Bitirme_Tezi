using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitylayer
{
    public class Work
    {

        [Key]
        public int WorkID { get; set; }

        public bool?  WorkStatus { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Title is too long.")]
        [MinLength(1,ErrorMessage ="Title is so short")]
        
        public string WorkTitle { get; set; }
        [Required ]
        public string WorkContent{ get; set; }
     
        public string WorkImage{ get; set; }
      
        public DateTime WorkDate{ get; set; }

        [Required]
        public int CategoryID { get; set; }
        public Category category { get; set; }
    }
}
