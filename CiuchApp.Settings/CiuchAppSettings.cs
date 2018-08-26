using System.Configuration;

namespace CiuchApp.Settings
{
    public static class CiuchAppSettingsFactory
    {
        public static CiuchAppSettings GetSettings()
        {
            return new CiuchAppSettings()
            {
                LocalPhotoStorageFolder = new LocalPhotoStorageFolder()
                {
                    Path = @"C:/XamarinData"
                }
            };
        }
    }
}