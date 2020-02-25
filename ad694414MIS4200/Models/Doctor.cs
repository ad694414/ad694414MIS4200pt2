using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ad694414MIS4200.Models
{
    public class Doctor
    {
        [Key]
        public int doctorId { get; set; }

        public string fullName { get { return lastName + " , " + firstName; } }

        [Display (Name ="First Name")]
        [Required(ErrorMessage ="Doctor first name is required")]
        [StringLength(20)]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [StringLength(20)]
        public string lastName { get; set; }

        [Display (Name ="Most used email")]
        [Required]
        [EmailAddress(ErrorMessage ="enter your most frequently used email")]
        public string email { get; set; }

        [Display (Name = "Mobile Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage ="Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }
        

        public ICollection<Appointment> Appointment { get; set; }
    }
}