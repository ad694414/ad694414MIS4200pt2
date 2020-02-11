using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ad694414MIS4200.Models
{
    public class Appointment
    {
        [Key]
        public int appointmentId { get; set; }
        public string description { get; set; }
        public DateTime appointmentDate { get; set; }
        public int doctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        public int patientId { get; set; }
        public virtual Patient Patient { get; set; }
    }
}