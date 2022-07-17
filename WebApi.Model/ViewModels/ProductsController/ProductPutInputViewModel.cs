namespace WebApi.Model.ViewModels.ProductController
{
    public class ProductPutInputViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public ProductPutInputCategoryViewModel ProductCategory { get; set; }
    }
    public class ProductPutInputCategoryViewModel
    {
        public Guid Id { get; set; }
    }
}
