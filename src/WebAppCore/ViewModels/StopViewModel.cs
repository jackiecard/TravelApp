using System;
using System.ComponentModel.DataAnnotations;

namespace WebAppCore.ViewModels
{
    public class StopViewModel
    {
        public int ID { get; set; }
        [Required]
        [StringLength(255, MinimumLength = 5, ErrorMessage = "Invalid! Name must have at least 5 characters and 255 maximum!")]
        public string Name { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public DateTime ArrivalDate { get; set; }
    }
}