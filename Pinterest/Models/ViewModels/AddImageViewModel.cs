using PhotoHome.Models.Entity;

namespace PhotoHome.Models.ViewModels
{
    public class AddImageViewModel
    {

        public string Description { get; set; }
        public string Title { get; set; }

        public IFormFile ImageUrl { get; set; }
        public int LikeCount { get; set; }
        public int DownloadCount { get; set; }
        public int user_id { get; set; }
        public int catagory_id { get; set; }

        public string[] Tags { get; set; }
        public AddImageViewModel()
        {

        }


        //public static implicit operator Picture(AddImageViewModel model)
        //{
        //    return new Picture() { Title = model.Title, Description = model.Description, DownloadCount = model.DownloadCount, LikeCount = model.LikeCount, ImageUrl = model.ImageUrl.FileName, catagory_id = model.catagory_id, user_id = model.user_id };
        //}

        //public static implicit operator AddImageViewModel(Image model)
        //{
        //    return new AddImageViewModel() { Title = model.Title, Description = model.Description, DownloadCount = model.DownloadCount, LikeCount = model.LikeCount, ImageUrl = (model.ImageUrl), catagory_id = model.catagory_id, user_id = model.user_id };
        //}


    }


}
