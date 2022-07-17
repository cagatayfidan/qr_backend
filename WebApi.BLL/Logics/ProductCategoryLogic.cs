using System;
using System.Collections.Generic;
using AutoMapper;
using WebApi.BLL.Logics.Interfaces;
using WebApi.DAL.Repositories.Interfaces;
using WebApi.Model;
using WebApi.Model.ViewModels.ProductCategoryController;

namespace WebApi.BLL.Logics
{
    public class ProductCategoryLogic : BaseLogic, IProductCategoryLogic
    {
        public ProductCategoryLogic(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }

        public ProductCategoryPostOutputViewModel Add(ProductCategoryPostInputViewModel model, User currentUser)
        {
            ProductCategory newProductCategory = new ProductCategory()
            {
                Name = model.Name,
                UserId = currentUser.Id
            };

            this._unitOfWork.ProductCategory.Insert(newProductCategory);
            this._unitOfWork.Save();
            return _mapper.Map<ProductCategoryPostOutputViewModel>(newProductCategory);
        }


        public void Delete()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductCategory> Get()
        {
            throw new NotImplementedException();
        }

    }
}
