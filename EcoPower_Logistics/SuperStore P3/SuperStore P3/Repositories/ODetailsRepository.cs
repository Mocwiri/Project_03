using Data;
using Models;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repositories
{
    public class ODetailsRepository : GenericRepository<OrderDetail>, IODetailsRepository
    {
        public ODetailsRepository(SuperStoreContext context) : base(context)
        {
        }

        public OrderDetail GetMostRecentService()
        {
            return _context.OrderDetails.OrderByDescending(service => service.Order).FirstOrDefault();
        }


    }
}
