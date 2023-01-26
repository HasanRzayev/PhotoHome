




namespace PhotoHome.Models.Entity
{
    public class Image_Tag:Entity
    {
        public int Tag_Id { get; set; }
        public int Image_Id { get; set; }

        public Picture Image { get; set; }
        public Tag Tag { get; set; }

    }
}
