using Models;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repositories
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Order GetMostRecentService();
    }
}
