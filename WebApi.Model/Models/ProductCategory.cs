using WebApi.Model.Interfaces;

namespace WebApi.Model
{
    public class ProductCategory : BaseModel, ISoftDelete

    {
        public ProductCategory()
        {
            this.Product = new HashSet<Product>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Nullable<DateTimeOffset> DeletedAt { get; set; }
        public User User { get; set; }
        public Nullable<Guid> UserId { get; set; }



        public ICollection<Product> Product { get; set; }
    }
}