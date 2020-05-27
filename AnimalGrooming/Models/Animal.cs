using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalGrooming.Models
{
    public class Animal
    {
        [Key]
        public int AnimalWeight { get; set; }
        public string AnimalBreed { get; set; }
        public int Age { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
