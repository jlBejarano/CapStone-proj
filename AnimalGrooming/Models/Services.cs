using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalGrooming.Models
{
    public class Services
    {
        [Key]
        public int ServiceId { get; set; }
        public string ServiceType { get; set; }
        public int ServicePrice { get; set; }
    }
}
