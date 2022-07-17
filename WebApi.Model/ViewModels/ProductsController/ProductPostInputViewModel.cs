namespace WebApi.Model.ViewModels.ProductController
{
    public class ProductPostInputViewModel
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Nullable<Guid> ProductCategoryId { get; set; }
        public string Description { get; set; }
    }
}
