using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [StringLength(50), Display(Name = "Last Name"), Required]
        public string LastName { get; set; }
        [Required, StringLength(50, MinimumLength = 3), Column("FirstName"), Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dddd}",ApplyFormatInEditMode =true)]
        [Display(Name ="Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        public string FullName
        {
            get
            {
                return FirstMidName + " " + LastName;
            }
        }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
