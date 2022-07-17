using Microsoft.Extensions.Caching.Distributed;
using WebApi.DAL.Repositories.Interfaces;

namespace WebApi.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private MsSQLContext context;
        private IDistributedCache distributedCache;
        public UnitOfWork(MsSQLContext _context, IDistributedCache _distributedCache)
        {
            context = _context;
            distributedCache = _distributedCache;
        }

        private UserRepository userRepository;
        private ProductRepository productsRepository;
        private RefreshTokenRepository refreshTokenRepository;
        private ProductCategoryRepository productCategoryRepository;
        public IUserRepository User
        {
            get
            {

                if (this.userRepository == null)
                {
                    this.userRepository = new UserRepository(context, distributedCache);
                }
                return userRepository;
            }
        }

        public IRefreshTokenRepository RefreshToken
        {
            get
            {

                if (this.refreshTokenRepository == null)
                {
                    this.refreshTokenRepository = new RefreshTokenRepository(context);
                }
                return refreshTokenRepository;
            }
        }

        public IProductRepository Product
        {
            get
            {

                if (this.productsRepository == null)
                {
                    this.productsRepository = new ProductRepository(context, distributedCache);
                }
                return productsRepository;
            }
        }
        public IProductCategoryRepository ProductCategory
        {
            get
            {

                if (this.productCategoryRepository == null)
                {
                    this.productCategoryRepository = new ProductCategoryRepository(context, distributedCache);
                }
                return productCategoryRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}