namespace DanubeJourney.Web.Controllers
{
    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;

    public class ImagesController
    {
        private readonly Cloudinary cloudinary;

        public ImagesController(Cloudinary cloudinary)
        {
            this.cloudinary = cloudinary;
        }

        public ImageUploadResult Upload(ImageUploadParams parameters)
        {
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(@"E:\Users\Genadi\Pictures\Saved Pictures\borkata.jpg"),
            };
            var uploadResult = this.cloudinary.Upload(uploadParams);
            return uploadResult;
        }
    }
}
