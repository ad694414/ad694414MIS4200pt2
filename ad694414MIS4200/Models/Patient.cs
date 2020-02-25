using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ad694414MIS4200.Models
{
    public class Patient
    {
        [Key]
        public int patientId { get; set; }

        public string fullName { get { return lastName + " , " + firstName; } }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Patient first name is required")]
        [StringLength(20)]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [StringLength(20)]
        public string lastName { get; set; }

        [Display(Name = "Most used email")]
        [Required]
        [EmailAddress(ErrorMessage = "enter your most frequently used email")]
        public string Email { get; set; }

        [Display(Name = "Mobile Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage = "Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string Phone { get; set; }

        [Display(Name = "When were you born?")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }

        [Display(Name = "When did you join the organization?")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime patientSince { get; set; }

        [Display(Name = "Symptoms")]
        [Required]
        [StringLength(50)]
        public string symptomsId { get; set; }

        public ICollection<Appointment> Apppointment { get; set; }
    }
}