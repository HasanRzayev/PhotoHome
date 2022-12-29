namespace PhotoHome.Models.Entity
{
    public class Picture : Entity
    {
        public string ImageUrl { get; set; }
        public int LikeCount { get; set; }
        public int DownloadCount { get; set; }

        public string Description { get; set; }
        public string Title { get; set; }

        public AppUser user { get; set; }
        public string? user_id { get; set; }

        public Catagory catagory { get; set; }
        public int catagory_id { get; set; }
        public Picture()
        {

        }
    }
}
