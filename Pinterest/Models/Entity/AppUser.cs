

namespace PhotoHome.Models.Entity
{
    public class User : Entity
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Role { get; set; }
        public virtual ICollection<Picture> Images { get; set; }



    }
}
