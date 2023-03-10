

using Microsoft.AspNetCore.Identity;

namespace PhotoHome.Models.Entity
{
    public class User : IdentityUser
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string? Message { get; set; }
        public string? About { get; set; }

        public string? ImageUrl { get; set; }
        public virtual ICollection<Picture> Created_Images { get; set; }
        public virtual ICollection<Image_Like> Image_Likes { get; set; }


    }
}
