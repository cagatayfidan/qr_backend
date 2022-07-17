using WebApi.Model;
using WebApi.Model.ViewModels.ProductCategoryController;
using WebApi.Model.ViewModels.ProductController;
using WebApi.Model.ViewModels.UserController;

namespace AutoMapper.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, GetOutputViewModel>().ReverseMap();
            CreateMap<User, RegisterOutputViewModel>().ReverseMap();

            CreateMap<Product, ProductGetOutputViewModel>().ReverseMap();
            CreateMap<Product, ProductPutOutputViewModel>();
            CreateMap<Product, ProductPostOutputViewModel>();
            CreateMap<Product, ProductDeleteOutputViewModel>();

            CreateMap<ProductCategory, ProductCategoryPostOutputViewModel>().ReverseMap();
        }
    }
}