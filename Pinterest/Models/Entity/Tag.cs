namespace PhotoHome.Models.Entity
{
    public class Tag:Entity
    {

        public string Name { get; set; }

        public ICollection<Image_Tag> Image_Tags { get; set; }

        public string? Image_url { get; set; }

    }
}
