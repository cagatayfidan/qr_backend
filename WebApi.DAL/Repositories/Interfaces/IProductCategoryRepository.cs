using WebApi.Model;

namespace WebApi.DAL.Repositories.Interfaces
{
    public interface IProductCategoryRepository : IGenericRepository<ProductCategory>
    {
        ProductCategory GetCategoryById(Guid id);
    }
}