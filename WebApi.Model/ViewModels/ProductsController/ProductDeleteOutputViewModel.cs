namespace WebApi.Model.ViewModels.ProductController
{
    public class ProductDeleteOutputViewModel
    {
        public string Name { get; set; }
        public DateTimeOffset DeletedAt { get; set; }
    }
}
