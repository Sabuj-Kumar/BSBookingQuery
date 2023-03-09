using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BSBookingQuery.Models
{
    public class BookingModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Enter Hotel Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter Location")]
        [Display(Name = "Location")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Enter Rating")]
        [Display(Name = "Rating")]
        public int Rating { get; set; }
        public ICollection<Comments> Comments { get; set; } 
    } 
}
