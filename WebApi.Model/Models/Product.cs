using WebApi.Model.Interfaces;

namespace WebApi.Model
{
    public class Product : BaseModel, ISoftDelete

    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public Nullable<Guid> ProductCategoryId { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
        public Nullable<DateTimeOffset> DeletedAt { get; set; }





        public ProductCategory ProductCategory { get; set; }
    }
}