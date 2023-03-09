using BSBookingQuery.Models;
using EF.Core.Repository.Interface.Repository;

namespace BSBookingQuery.Interface.Repository
{
    public interface Irepository : ICommonRepository<BookingModel>
    {
    }
}
