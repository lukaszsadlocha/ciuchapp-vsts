using System;

namespace CiuchApp.ApiClient
{
    public interface IUriGenerator
    {
        void Set(string apiBaseUrl);
        Uri GetCacheUri();
        Uri GetDeepUri<T>(string baseController, int id);
        Uri GetUri<T>();
        object GetImageUri();
    }
}