using Data;
using Models;

namespace EcoPower_Logistics.Repositories
{
    public class ProductRepository
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

    }
}
 