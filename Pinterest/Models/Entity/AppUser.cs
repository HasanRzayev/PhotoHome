

using Microsoft.AspNetCore.Identity;

namespace PhotoHome.Models.Entity
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Picture> Images { get; set; }
    }
}
