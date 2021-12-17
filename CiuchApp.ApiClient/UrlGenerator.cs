using System;

namespace CiuchApp.ApiClient
{
    public class UriGenerator : IUriGenerator
    {
        private string _apiBaseUrl;

        public void Set(string apiBaseUrl)
        {
            _apiBaseUrl = apiBaseUrl;
        }

        public Uri GetCacheUri() => new Uri($@"{_apiBaseUrl}/Cache");

        public Uri GetImageUri() => new Uri($@"{_apiBaseUrl}/Images");

        Uri IUriGenerator.GetDeepUri<T>(string baseController, int id) => 
            new Uri($@"{_apiBaseUrl}/{baseController}/{id}/{GetNameOfController<T>()}");

        public Uri GetUri<T>() => 
            new Uri($@"{_apiBaseUrl}/{GetNameOfController<T>()}");

        private string GetNameOfController<T>()
        {
            string nameOfClass = typeof(T).Name;

            return nameOfClass.EndsWith("y") ?
                $"{nameOfClass.Substring(0, nameOfClass.Length - 1)}ies" :
                $"{nameOfClass}s";
        }

        object IUriGenerator.GetImageUri()
        {
            throw new NotImplementedException();
        }
    }
}