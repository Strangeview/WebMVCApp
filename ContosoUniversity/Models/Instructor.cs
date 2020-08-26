using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        [Required,StringLength(50,MinimumLength =3),Display(Name ="Last Name")]
        public string LastName { get; set; }
        [Required,StringLength(50,MinimumLength =3),Display(Name ="First Name"),Column("FirstName")]
        public string FirstMidName { get; set; }
        [Display(Name ="Hire Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dddd}", ApplyFormatInEditMode = true)]
        public DateTime HireDate { get; set; }
        [Display(Name ="Full Name")]
        public string FullName
        {
            get
            {
                return FirstMidName + "," + LastName;
            }
        }
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
        public OfficeAssignment OfficeAssignment { get; set; } 
    }
}
