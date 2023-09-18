using Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(SuperStoreContext context) : base(context)
        {
        }

        public Order GetMostRecentService()
        {
            return _context.Orders.OrderByDescending(service => service.OrderDate).FirstOrDefault();
        }
    }
}
