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
        private const int pageSize = 20;
        public List<Picture> GetImage(int? pageNumber)
        {
            var numberOfRecordToskip = pageNumber * pageSize;
           
            return _base.Images.OrderBy(x => x.Id).Skip(Convert.ToInt32(numberOfRecordToskip)).Take(pageSize).ToList<Picture>();
            
        }
    }
}
