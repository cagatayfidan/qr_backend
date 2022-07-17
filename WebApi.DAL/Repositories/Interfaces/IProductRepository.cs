using WebApi.Model;

namespace WebApi.DAL.Repositories.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Product GetByIdWithCategory(Guid id);
        List<Product> GetProductByUser(User user);
    }
}