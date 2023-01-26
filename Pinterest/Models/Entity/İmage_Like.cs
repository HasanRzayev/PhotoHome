namespace PhotoHome.Models.Entity
{
    public class Image_Like
    {
        public string user_id { get; set; }
        public int Image_Id { get; set; }

        public Picture Image { get; set; }
        public User user { get; set; }
    }
}
