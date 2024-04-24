using HotelListing.API.Data;
using HotelListing.API.Contracts;

namespace HotelListing.API.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
        }   
    }
}
