using PhotoHome.Data;
using PhotoHome.Models.Entity;
using System.Security.Claims;
using static System.Net.Mime.MediaTypeNames;

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
        public List<string> GetImages(int? pageNumber,string id)
        {
            var numberOfRecordToskip = pageNumber * pageSize;
            List<string> imageList = new List<string>();
            var model = _base.Images.OrderBy(x => x.Id).Skip(Convert.ToInt32(numberOfRecordToskip)).Take(pageSize).ToList<Picture>();
           
            foreach (var item in model)
            {
                var image_id=_base.Images.First(a=>a.Id==item.Id).Id;   
                if(_base.Image_Likes.FirstOrDefault(a=>a.user_id==id && a.Image_Id==image_id)==null) imageList.Add(item.ImageUrl);

            }
          
            return imageList;

        }
        public List<string> GetImages(int? pageNumber)
        {
            var numberOfRecordToskip = pageNumber * pageSize;
            List<string> imageList = new List<string>();
            var model = _base.Images.OrderBy(x => x.Id).Skip(Convert.ToInt32(numberOfRecordToskip)).Take(pageSize).ToList<Picture>();

            foreach (var item in model)
            {
               imageList.Add(item.ImageUrl);
            }

            return imageList;

        }
    }
}
