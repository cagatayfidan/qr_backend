using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using WebApi.DAL.Repositories.Interfaces;
using WebApi.Model;

namespace WebApi.DAL.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(MsSQLContext context, IDistributedCache distributedCache) : base(context, distributedCache)
        {
        }

        public Product GetByIdWithCategory(Guid id)
        {
            return dbSet.AsNoTracking().Where(x => x.Id == id).Include(x => x.ProductCategory).FirstOrDefault();
        }
        public List<Product> GetProductByUser(User user)
        {
            return dbSet.Where(x => x.UserId == user.Id).ToList();
        }
    }
}