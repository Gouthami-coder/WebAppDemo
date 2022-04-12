using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Appointment
    {
        public int id { get; set; }

        [ForeignKey("pat")]

        public int patient_id { get; set; }
        public Patient pat { get; set; }

        [ForeignKey("doc")]

        public int doctor_id { get; set; }
        public Doctor doc { get; set; }
        public DateTime date { get; set; }
        public int appointTime { get; set; }


    }
}