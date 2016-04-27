using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore.ViewModels
{
    public class TripViewModel
    {
        public int ID { get; set; }
        [Required]
        [StringLength(255, MinimumLength = 5, ErrorMessage = "Invalid! Name must have at least 5 characters and 255 maximum!")]
        public string Name { get; set; }
        public DateTime DateCreated = DateTime.Now;
        private IEnumerable<StopViewModel> Stops;




    }
}
