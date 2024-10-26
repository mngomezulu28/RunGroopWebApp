using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

namespace RunGroopWebApp.Helpers
{
    public class CloudinarySettings
    {
        public string CloudName { get; set; }
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }

        internal Task DestroyAsync(DeletionParams deleteParams)
        {
            throw new NotImplementedException();
        }

        internal Task<ImageUploadResult> UploadAsync(ImageUploadParams uploadParams)
        {
            throw new NotImplementedException();
        }

        public static implicit operator CloudinarySettings(Cloudinary v)
        {
            throw new NotImplementedException();
        }
    }
}
