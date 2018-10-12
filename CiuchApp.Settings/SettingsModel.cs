using System.Configuration;

namespace CiuchApp.Settings
{
    public class CiuchAppSettings
    {
        public PhotoStorageFolder PhotoStorageFolder { get; set; }
        public ApiUrls ApiUrls { get; set; }
    }

    public class PhotoStorageFolder
    {
        public  PathValue Mobile { get; set; }
        public PathValue Server { get; set; }
    }

    public class ApiUrls
    {
        public string ApiBaseUrlDevelopment { get; set; }
    }

    public class PathValue
    {
        public string Name { get; set; }
    }

}