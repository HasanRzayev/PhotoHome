namespace PhotoHome.Models.Entity
{
    public class Picture : Entity
    {
        public Picture()
        {

        }

        public string ImageUrl { get; set; }
        public int LikeCount { get; set; }
        public int DownloadCount { get; set; }

        public string Description { get; set; }
        public string Title { get; set; }

        public virtual User user { get; set; }
        public string? user_id { get; set; }

        public virtual ICollection<Image_Like> Image_Likes { get; set; }
        public bool? Allow { get; set; }

 
        public virtual ICollection<Image_Tag> Image_Tags { get; set;  }
   
        public virtual Catagory catagory { get; set; }
        public int? catagory_id { get; set; }

       
    }
}
