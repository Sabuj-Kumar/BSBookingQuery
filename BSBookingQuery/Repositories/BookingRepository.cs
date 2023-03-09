using BSBookingQuery.Data;
using BSBookingQuery.Interface.Repository;
using BSBookingQuery.Models;
using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;

namespace BSBookingQuery.Repositories
{
    public class BookingRepository : CommonRepository<BookingModel>, Irepository
    {
        public BookingRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
        }
    }
}
