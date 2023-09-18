using Models;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repositories
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Customer GetMostRecentService();
    }
}
