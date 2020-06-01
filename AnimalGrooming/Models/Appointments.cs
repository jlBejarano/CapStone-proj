using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalGrooming.Models
{
    public class Appointments
    {
        [Key]

        public int AppointmentId { get; set; }
        public string AppointmentName { get; set; }
    }
}
