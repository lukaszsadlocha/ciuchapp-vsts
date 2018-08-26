using System.Configuration;

namespace CiuchApp.Settings
{
    public class FolderSettingsSection : ConfigurationSection
    {
        [ConfigurationProperty("FolderSettings")]
        public LocalPhotoStorageFolder DellFeatures
        {
            get
            {
                return (LocalPhotoStorageFolder)this["LocalPhotoStorageFolder"];
            }
            set
            {
                value = (LocalPhotoStorageFolder)this["LocalPhotoStorageFolder"];
            }
        }
    }

    public class LocalPhotoStorageFolder : ConfigurationElement
    {
        [ConfigurationProperty("Path", DefaultValue = 00000, IsRequired = true)]
        public string Path
        {
            get
            {
                return (string)this["Path"];
            }
            set
            {
                value = (string)this["Path"];
            }
        }
    }
}






    //public class DellFeatures : ConfigurationElement
    //{
    //    [ConfigurationProperty("ProductNumber", DefaultValue = 00000, IsRequired = true)]
    //    public int ProductNumber
    //    {
    //        get
    //        {
    //            return (int)this["ProductNumber"];
    //        }
    //        set
    //        {
    //            value = (int)this["ProductNumber"];
    //        }
    //    }

//    [ConfigurationProperty("ProductName", DefaultValue = "DELL", IsRequired = true)]
//    public string ProductName
//    {
//        get
//        {
//            return (string)this["ProductName"];
//        }
//        set
//        {
//            value = (string)this["ProductName"];
//        }
//    }

//    [ConfigurationProperty("Color", IsRequired = false)]
//    public string Color
//    {
//        get
//        {
//            return (string)this["Color"];
//        }
//        set
//        {
//            value = (string)this["Color"];
//        }
//    }
//    [ConfigurationProperty("Warranty", DefaultValue = "1 Years", IsRequired = false)]
//    public string Warranty
//    {
//        get
//        {
//            return (string)this["Warranty"];
//        }
//        set
//        {
//            value = (string)this["Warranty"];
//        }
//    }
//}

//public class ProductSettings : ConfigurationSection
//{
//    [ConfigurationProperty("DellSettings")]
//    public DellFeatures DellFeatures
//    {
//        get
//        {
//            return (DellFeatures)this["DellSettings"];
//        }
//        set
//        {
//            value = (DellFeatures)this["DellSettings"];
//        }
//    }
//}



//<FolderSettings>
//  <LocalPhotoStorageFolder Path = "kupa dupa siki" />
//</ FolderSettings >
