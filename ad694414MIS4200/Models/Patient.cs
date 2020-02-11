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
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }
        public DateTime patientSince { get; set; }
        public string symptomsId { get; set; }
        public ICollection<Appointment> Apppointment { get; set; }
    }
}