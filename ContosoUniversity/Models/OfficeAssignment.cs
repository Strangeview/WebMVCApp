using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {
        [Key]
        public int InstructorID { get; set; }
        [Display(Name ="Office Location")]
        [StringLength(50)]
        public string Location { get; set; }
        public Instructor Instructor { get; set; }
    }
}
