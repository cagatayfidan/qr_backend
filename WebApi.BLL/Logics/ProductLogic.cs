using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using WebApi.BLL.Logics.Interfaces;
using WebApi.DAL.Repositories.Interfaces;
using WebApi.Model;
using WebApi.Model.ViewModels.ProductController;

namespace WebApi.BLL.Logics
{
    public class ProductLogic : BaseLogic, IProductLogic
    {
        public ProductLogic(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }

        public ProductPostOutputViewModel Register(ProductPostInputViewModel model, User currentUser)
        {
            Product newProduct = new Product()
            {
                Name = model.Name,
                Price = model.Price,
                Description = model.Description,
                ProductCategoryId = model.ProductCategoryId,
                UserId = currentUser.Id
            };

            this._unitOfWork.Product.Insert(newProduct);
            this._unitOfWork.Save();
            Product result = this._unitOfWork.Product.GetByIdWithCategory(newProduct.Id);
            return _mapper.Map<ProductPostOutputViewModel>(result);
        }

        public ProductPutOutputViewModel Update(ProductPutInputViewModel product)
        {
            Product currentProduct = this._unitOfWork.Product.GetByID(product.Id);
            currentProduct.Name = product.Name;
            currentProduct.Description = product.Description;
            currentProduct.Price = product.Price;
            currentProduct.ProductCategoryId = product.ProductCategory.Id;
            this._unitOfWork.Product.Update(currentProduct);
            this._unitOfWork.Save();
            return _mapper.Map<ProductPutOutputViewModel>(currentProduct);
        }
        public ProductDeleteOutputViewModel Delete(ProductDeleteInputViewModel product)
        {
            Product entity = _unitOfWork.Product.GetByID(product.Id);
            _unitOfWork.Product.Delete(product.Id);
            _unitOfWork.Save();
            return _mapper.Map<ProductDeleteOutputViewModel>(entity);
        }

        public List<ProductGetOutputViewModel> Get(User user)
        {
            IEnumerable<Product> products = _unitOfWork.Product.GetProductByUser(user);
            Console.Write(products);
            return _mapper.Map<List<ProductGetOutputViewModel>>(products.ToList());
        }
    }
}
