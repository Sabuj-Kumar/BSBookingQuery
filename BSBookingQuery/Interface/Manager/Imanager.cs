using BSBookingQuery.Models;
using EF.Core.Repository.Interface.Manager;

namespace BSBookingQuery.Interface.Manager
{
    public interface Imanager:ICommonManager<BookingModel>
    {
        BookingModel GetById(int id);
        ICollection<BookingModel> GetByName(string name);
        ICollection<BookingModel> GetByLocation(string name);
        ICollection<BookingModel> GetByRating(int rating);

        /*ICollection<BookingModel> GetAllContainsFilterData(string location);*/
        /*ICollection<BookingModel> GetPagingData(int page, int pageSize);*/
    }
}
