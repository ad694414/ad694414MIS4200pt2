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
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        

        public ICollection<Appointment> Appointment { get; set; }
    }
}