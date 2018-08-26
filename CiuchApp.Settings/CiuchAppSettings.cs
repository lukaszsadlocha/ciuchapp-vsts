using System.Configuration;

namespace CiuchApp.Settings
{
    public static class CiuchAppSettings
    {
        public static FolderSettingsSection GetSettings()
        {
            return ConfigurationManager.GetSection("FolderSettings") as CiuchApp.Settings.FolderSettingsSection;
        }
    }
}