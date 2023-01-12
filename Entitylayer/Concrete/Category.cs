using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entitylayer
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Name is too long.")]
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        [Required]
        public string CategoryDescription { get; set; }

        public List<Work> works { get; set; }
    }
}
