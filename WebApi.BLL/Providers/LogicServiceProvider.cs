using WebApi.BLL.Logics;
using WebApi.BLL.Logics.Interfaces;

namespace Microsoft.Extensions.DependencyInjection {
    public static class LogicServiceProvider
    {
        public static IServiceCollection RegisterLogicLayer(this IServiceCollection services)
        {
            services.AddTransient<IUserLogic, UserLogic>();
            services.AddTransient<IAuthLogic, AuthLogic>();
            services.AddTransient<IProductLogic, ProductLogic>();
            services.AddTransient<IRefreshTokenLogic, RefreshTokenLogic>();
            services.AddTransient<IProductCategoryLogic, ProductCategoryLogic>();
            return services;
        }
    }
}