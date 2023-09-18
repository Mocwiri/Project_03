using Models;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repositories
{
    public interface IODetailsRepository : IGenericRepository<OrderDetail>
    {
        OrderDetail GetMostRecentService();
    }
}
