namespace PhotoHome.Models.Entity
{
    public class Catagory:Entity
    {
        public Catagory()
        {
                
        }

        public string Name { get; set; }
        public virtual ICollection<Picture> Images { get; set; }
    }
}
