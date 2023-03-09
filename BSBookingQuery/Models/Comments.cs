using System.ComponentModel.DataAnnotations;

namespace BSBookingQuery.Models
{
    public class Comments
    {
       
        [Key]
        public int Id { get; set; } 
        public string UserComments { get; set; }
        public int BookingModelId { get; set; }
        public BookingModel BookingModel { get; set; }
    }
}
