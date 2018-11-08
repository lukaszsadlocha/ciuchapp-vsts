using System.Configuration;
using System.Diagnostics;

namespace CiuchApp.Settings
{
    public interface ICiuchAppSettings
    {
        PhotoStorageFolder PhotoStorageFolder { get; set; }
        Urls Urls { get; set; }
    }

    public class CiuchAppSettings : ICiuchAppSettings
    {
        public CiuchAppSettings()
        {
            PhotoStorageFolder = new PhotoStorageFolder()
            {
                Mobile = new PathValue() { Name = @"CiuchAppPhotos" },
                Server = new PathValue() { Name = @"CiuchAppPhotos" }
            };
            Urls = new Urls()
            {
                LocalApiUrl = @"http://10.0.2.2:13121/api",
                RemoteApiUrl = @"http://10.0.2.2:13121/api"
                //LocalApiUrl = @"http://www.ciuchapp.lukaszsadlocha.pl/api",
                //RemoteApiUrl = @"http://www.ciuchapp.lukaszsadlocha.pl/api"
            };
        }

        public PhotoStorageFolder PhotoStorageFolder { get; set; }
        public Urls Urls { get; set; }
    }

    public class PhotoStorageFolder
    {
        public PathValue Mobile { get; set; }
        public PathValue Server { get; set; }
    }

    public class Urls
    {
        public string ApiUrl
        {
            get
            {
                if (Debugger.IsAttached)
                {
                    return LocalApiUrl;
                }
                return RemoteApiUrl;
            }
        }

        public string LocalApiUrl { get; set; }
        public string RemoteApiUrl { get; set; }
    }

    public class PathValue
    {
        public string Name { get; set; }
    }

}