namespace WebApi.Model.ViewModels.ProductController
{
    public class ProductPostOutputViewModel
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public ProductPostOutputProductCategoryViewModel ProductCategory { get; set; }
        public string Description { get; set; }
    }
    public class ProductPostOutputProductCategoryViewModel
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
    }
}
