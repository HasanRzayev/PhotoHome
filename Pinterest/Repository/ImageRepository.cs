using PhotoHome.Data;
using PhotoHome.Models.Entity;

namespace PhotoHome.Repository
{
    public class ImageRepository
    {

        private AppDbContext _base;
        public ImageRepository(AppDbContext context)
        {
            _base = context;
        }
        private const int pageSize = 10;
        public List<Picture> GetImage(int? pageNumber)
        {
            var numberOfRecordToskip = pageNumber * pageSize;
            return _base.Images.OrderBy(x => x.Id).Skip(Convert.ToInt32(numberOfRecordToskip)).Take(pageSize).ToList<Picture>();
        }
        public List<string> GetImages(int? pageNumber)
        {
            var numberOfRecordToskip = pageNumber * pageSize;
            List<string> imageList = new List<string>();
            var model = _base.Images.OrderBy(x => x.Id).Skip(Convert.ToInt32(numberOfRecordToskip)).Take(pageSize).ToList<Picture>();
            foreach (var image in model) imageList.Add(image.ImageUrl);
            return imageList;

        }
    }
}
