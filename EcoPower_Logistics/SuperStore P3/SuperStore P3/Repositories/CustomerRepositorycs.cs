using Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repositories
{
    public class CustomerRepositorycs : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepositorycs(SuperStoreContext context) : base(context)
        {
        }

        public Customer GetMostRecentService()
        {
            return _context.Customers.OrderByDescending(service => service.CustomerName).FirstOrDefault();
        }

    }
}
