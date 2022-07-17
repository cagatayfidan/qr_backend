using WebApi.Model.Interfaces;

namespace WebApi.Model
{
    public class User : BaseModel, ISoftDelete

    {
        public User()
        {
            this.ProductCategory = new HashSet<ProductCategory>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<DateTimeOffset> DeletedAt { get; set; }



        public ICollection<ProductCategory> ProductCategory { get; set; }

    }
}