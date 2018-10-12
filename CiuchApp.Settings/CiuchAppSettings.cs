using System.Configuration;

namespace CiuchApp.Settings
{
    public static class CiuchAppSettingsFactory
    {
        public static CiuchAppSettings GetSettings()
        {
            var settings = new CiuchAppSettings()
            {
                PhotoStorageFolder = new PhotoStorageFolder()
                {
                    Mobile = new PathValue() { Name = @"CiuchAppPhotos" },
                    Server = new PathValue() { Name = @"CiuchAppPhotos" }
                },
                ApiUrls = new ApiUrls()
                {
                    ApiBaseUrlDevelopment = @"http://10.0.2.2:13121/api"
                }
            };

            return settings;
        }
    }
}