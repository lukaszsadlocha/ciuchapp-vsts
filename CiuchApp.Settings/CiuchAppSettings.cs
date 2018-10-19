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
                Urls = new Urls()
                {
                    LocalApiUrl = @"http://10.0.2.2:13121/api",
                    RemoteApiUrl = @"http://www.ciuchapp.lukaszsadlocha.pl/api"
                }
            };

            return settings;
        }
    }
}