using Microsoft.AspNetCore.Identity;

namespace PhotoHome.Models.Entity
{
    public class AppUser : IdentityUser
    {
        public virtual ICollection<Image> Images { get; set; }

        public int MyProperty { get; set; }

    }
}
