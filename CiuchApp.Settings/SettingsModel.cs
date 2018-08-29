using System.Configuration;

namespace CiuchApp.Settings
{
    public class CiuchAppSettings
    {
        public LocalPhotoStorageFolder LocalPhotoStorageFolder { get; set; }
        public ApiUrls ApiUrls { get; set; }
    }

    public class LocalPhotoStorageFolder
    {
        public string Path { get; set; }
    }

    public class ApiUrls
    {
        public string ApiBaseUrlDevelopment { get; set; }
    }

}