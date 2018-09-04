using CiuchApp.Domain;
using CiuchApp.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CiuchApp.ApiClient
{
    public class ApiClient
    {
        string apiBaseUrl;
        public ApiClient()
        {
            apiBaseUrl = CiuchAppSettingsFactory.GetSettings().ApiUrls.ApiBaseUrlDevelopment;
        }

        public List<T> GetList<T>()
        {
            string nameOfController = GetNameOfController<T>();
            Uri restApiUri = new Uri(apiBaseUrl + nameOfController);

            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetAsync(restApiUri).Result;
                var result = response.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject<List<T>>(result);
            }
        }

        public void Add<T>(T newItem) where T : CiuchAppModelBase
        {
            string nameOfController = GetNameOfController<T>();
            Uri restApiUri = new Uri(apiBaseUrl + nameOfController);

            using (var httpClient = new HttpClient())
            {
                var values = newItem.ToKeyValuePairs<T>();
                var content = new FormUrlEncodedContent(values);

                httpClient.PostAsync(restApiUri, content);
                var response = httpClient.GetAsync(restApiUri).Result;
                var result = response.Content.ReadAsStringAsync().Result;
            }
        }


        public List<Piece> GetClothesByBusinessTripId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Piece> GetPieces()
        {
            throw new NotImplementedException();
        }

        private string GetNameOfController<T>()
        {
            string nameOfClass = typeof(T).Name;
            string nameOfController = "";
            if (nameOfClass.EndsWith("y"))
            {
                nameOfController = nameOfClass.Substring(0, nameOfClass.Length - 1) + "ies";
            }
            else
            {
                nameOfController = nameOfClass + "s";
            }

            return nameOfController;
        }

        //public async Task<List<BusinessTrip>> GetBusinessTripsAsync()
        //{

        //    var RestUrl = @"http://10.0.2.2:13121/api/BusinessTrips";
        //    var uri = new Uri(string.Format(RestUrl, string.Empty));
        //    var client = new HttpClient();
        //    var response = await client.GetAsync(uri);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var content = await response.Content.ReadAsStringAsync();
        //        return await Task.Run(() => JsonConvert.DeserializeObject<List<BusinessTrip>>(content));

        //    }
        //    return null;
        //}
    }
}
