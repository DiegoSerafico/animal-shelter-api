using System.ComponentModel.DataAnnotations;
using System;

namespace AnimalShelter.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Species { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [Required]
        [Range(0, Double.PositiveInfinity)]
        public int Age { get; set; }
    }
}