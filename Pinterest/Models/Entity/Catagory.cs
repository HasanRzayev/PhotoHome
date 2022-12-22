namespace PhotoHome.Models.Entity
{
    public class Catagory:Entity
    {
        public string Name { get; set; }
        public virtual ICollection<Image> Images { get; set; }

    }
}
