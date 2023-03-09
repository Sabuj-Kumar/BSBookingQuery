using BSBookingQuery.Data;
using BSBookingQuery.Interface.Manager;
using BSBookingQuery.Interface.Repository;
using BSBookingQuery.Models;
using BSBookingQuery.Repositories;
using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;

namespace BSBookingQuery.Managers
{
    public class BookingManager : CommonManager<BookingModel>, Imanager
    {
        public BookingManager(ApplicationDBContext dbContex) : base(new BookingRepository(dbContex))
        {
        }

        BookingModel Imanager.GetById(int id)
        {
            return GetFirstOrDefault(c => c.Id == id);
        }

        ICollection<BookingModel> Imanager.GetByLocation(string location)
        {
            return Get(c => c.Location.ToLower() == location.ToLower());
        }

        ICollection<BookingModel> Imanager.GetByName(string name)
        {
            return Get(c => c.Name.ToLower() == name.ToLower());
        }

        ICollection<BookingModel> Imanager.GetByRating(int rating)
        {
            return Get(c => c.Rating == rating);
        }
    }
}
