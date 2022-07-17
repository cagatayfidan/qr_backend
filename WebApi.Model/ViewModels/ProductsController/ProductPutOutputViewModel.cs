namespace WebApi.Model.ViewModels.ProductController
{
    public class ProductPutOutputViewModel
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public ProductPutOutputCategoryViewModel ProductCategory { get; set; }
    }
    public class ProductPutOutputCategoryViewModel
    {
        public Guid Id { get; set; }
    }
}
