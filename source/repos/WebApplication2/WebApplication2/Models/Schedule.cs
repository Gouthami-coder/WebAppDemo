using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Schedule
    {
        public int id { get; set; }
        public string sch { get; set; }

        [ForeignKey("doc")]
        public int doctor_id { get; set; }
        public Doctor doc { get; set; }
        public DateTime timestamp { get; set; }



    }
}