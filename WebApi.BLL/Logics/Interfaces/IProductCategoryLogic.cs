using System;
using System.Collections.Generic;
using WebApi.Model;
using WebApi.Model.ViewModels.ProductCategoryController;

namespace WebApi.BLL.Logics.Interfaces
{
    public interface IProductCategoryLogic
    {
        IEnumerable<ProductCategory> Get();
        ProductCategoryPostOutputViewModel Add(ProductCategoryPostInputViewModel productCategory, User user);
        void Delete();
    }
}