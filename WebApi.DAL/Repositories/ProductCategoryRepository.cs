using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using WebApi.DAL.Repositories.Interfaces;
using WebApi.Model;

namespace WebApi.DAL.Repositories
{
    public class ProductCategoryRepository : GenericRepository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(MsSQLContext context, IDistributedCache distributedCache) : base(context, distributedCache)
        {
        }

        public ProductCategory GetCategoryById(Guid id)
        {
            return dbSet.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
        }
    }
}