using System;
using System.Collections.Generic;
using WebApi.Model;
using WebApi.Model.ViewModels.ProductController;

namespace WebApi.BLL.Logics.Interfaces
{
    public interface IProductLogic
    {
        List<ProductGetOutputViewModel> Get(User user);
        ProductPostOutputViewModel Register(ProductPostInputViewModel products, User currentUser);
        ProductPutOutputViewModel Update(ProductPutInputViewModel product);
        ProductDeleteOutputViewModel Delete(ProductDeleteInputViewModel product);
    }
}