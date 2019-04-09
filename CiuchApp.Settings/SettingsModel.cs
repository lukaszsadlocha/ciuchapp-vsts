using System;
using System.Configuration;
using System.Diagnostics;

namespace CiuchApp.Settings
{
    public interface ICiuchAppSettings
    {
        PhotoStorageFolder PhotoStorageFolder { get; set; }
        Urls Urls { get; set; }
        ExcelSettings Excel { get; set; }
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
                LocalUrl = @"http://10.0.2.2:13121",
                RemoteUrl = @"http://10.0.2.2:13121"
                //LocalApiUrl = @"http://www.ciuchapp.lukaszsadlocha.pl/api",
                //RemoteApiUrl = @"http://www.ciuchapp.lukaszsadlocha.pl/api"
            };
            Excel = new ExcelSettings()
            {
                //$"CiuchApp_KPC_Excel_{DateTime.Now.ToString("yyyyMMddHHmmss")}.xlsx";
                kpcFileName = "CiuchApp_KPC_Excel_{0}.{1}",
                dateTimeAppendinxFormat = "yyyyMMddHHmmss",
                excelExtension = "xlsx",
                FolderName = "ExcelFiles"
            };
        }

        public PhotoStorageFolder PhotoStorageFolder { get; set; }
        public Urls Urls { get; set; }
        public ExcelSettings Excel { get; set; }
    }

    public class ExcelSettings
    {
        internal string kpcFileName;
        internal string dateTimeAppendinxFormat;
        internal string excelExtension;

        public string FolderName { get; set; }

        public string KpcFileName
        {
            get
            {
                return string.Format(kpcFileName, DateTime.Now.ToString(dateTimeAppendinxFormat), excelExtension);
            }
        }
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

        public string LocalUrl { get; set; }

        public string RemoteUrl { get; set; }

        public string LocalApiUrl
        {
            get
            {
                return $"{LocalUrl}/api";
            }
        }

        public string RemoteApiUrl
        {
            get
            {
                return $"{RemoteUrl}/api";
            }
        }
    }

    public class PathValue
    {
        public string Name { get; set; }
    }

}