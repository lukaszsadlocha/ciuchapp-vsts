using System.Configuration;
using System.Diagnostics;

namespace CiuchApp.Settings
{
    public class CiuchAppSettings
    {
        public PhotoStorageFolder PhotoStorageFolder { get; set; }
        public Urls Urls { get; set; }
    }

    public class PhotoStorageFolder
    {
        public  PathValue Mobile { get; set; }
        public PathValue Server { get; set; }
    }

    public class Urls
    {
        public string ApiUrl
        {
            get
            {
                if(Debugger.IsAttached)
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