﻿using CiuchApp.Domain;
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
        readonly string apiBaseUrl;
        public ApiClient()
        {
            apiBaseUrl = CiuchAppSettingsFactory.GetSettings().ApiUrls.ApiBaseUrlDevelopment;
        }

        public List<T> GetList<T>(int id = 0, string baseController="")
        {
            Uri restApiUri;
            if (id!=0 && !string.IsNullOrEmpty(baseController))
            {
                restApiUri = new Uri($@"{apiBaseUrl}/{baseController}/{id}/{GetNameOfController<T>()}");
            }
            else
            {
                restApiUri = new Uri(apiBaseUrl + GetNameOfController<T>());
            }

            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetAsync(restApiUri).Result;
                var result = response.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject<List<T>>(result);
            }
        }

        public bool Add<T>(T item) where T : CiuchAppModelBase
        {
            if(item.IsValid<T>(newItem: true))
            {
                string nameOfController = GetNameOfController<T>();
                Uri restApiUri = new Uri(apiBaseUrl + nameOfController);

                using (var httpClient = new HttpClient())
                {
                    var values = item.ToKeyValuePairs<T>(newItem: true);
                    var content = new FormUrlEncodedContent(values);

                    httpClient.PostAsync(restApiUri, content);
                    var response = httpClient.GetAsync(restApiUri).Result;
                    var result = response.Content.ReadAsStringAsync().Result;
                }
                return true;
            }
            return false;
        }

        public bool Update<T>(T item) where T : CiuchAppModelBase
        {
            if(item.IsValid<T>(newItem: false))
            {
                string nameOfController = GetNameOfController<T>();
                Uri restApiUri = new Uri(apiBaseUrl + nameOfController);

                using (var httpClient = new HttpClient())
                {
                    var values = item.ToKeyValuePairs<T>(newItem: false);
                    var content = new FormUrlEncodedContent(values);

                    httpClient.PutAsync(restApiUri, content);
                    var response = httpClient.GetAsync(restApiUri).Result;
                    var result = response.Content.ReadAsStringAsync().Result;
                }
                return true;
            }
            return false;
        }


        public List<Piece> GetPiecesByBusinessTripId(int id)
        {
            return GetList<Piece>(id, "BusinessTrips");
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
