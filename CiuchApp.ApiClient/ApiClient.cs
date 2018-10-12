using CiuchApp.Domain;
using CiuchApp.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

        public List<T> GetList<T>(int id = 0, string baseController = "")
        {
            Uri restApiUri;
            if (id != 0 && !string.IsNullOrEmpty(baseController))
            {
                restApiUri = new Uri($@"{apiBaseUrl}/{baseController}/{id}/{GetNameOfController<T>()}");
            }
            else
            {
                restApiUri = new Uri($@"{apiBaseUrl}/{GetNameOfController<T>()}");
            }

            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = httpClient.GetAsync(restApiUri).Result;
                    var result = response.Content.ReadAsStringAsync().Result;

                    return JsonConvert.DeserializeObject<List<T>>(result);
                }
            }
            catch (TimeoutException e)
            {
                //Todo: timeout execption
                return null;
            }
        }

        public T Add<T>(T item) where T : CiuchAppModelBase
        {
            if (item.IsValid<T>(newItem: true))
            {
                string nameOfController = GetNameOfController<T>();
                Uri restApiUri = new Uri($@"{apiBaseUrl}/{nameOfController}");

                using (var httpClient = new HttpClient())
                {
                    var values = item.ToKeyValuePairs<T>(newItem: true);
                    var content = new FormUrlEncodedContent(values);

                    httpClient.PostAsync(restApiUri, content);
                    var response = httpClient.GetAsync(restApiUri).Result;
                    var result = response.Content.ReadAsStringAsync().Result;

                }
                return item;
            }
            return item;
        }

        public bool Update<T>(T item) where T : CiuchAppModelBase
        {
            if (item.IsValid<T>(newItem: false))
            {
                string nameOfController = GetNameOfController<T>();
                Uri restApiUri = new Uri($@"{apiBaseUrl}/{nameOfController}");

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

        public bool UploadImage(Stream fileStream, string fileName)
        {
            HttpContent fileStreamContent = new StreamContent(fileStream);
            fileStreamContent.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data") { Name = "file", FileName = fileName };
            fileStreamContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            {
                formData.Add(fileStreamContent);
                var response = client.PostAsync(apiBaseUrl + "Images", formData).Result;
                return response.IsSuccessStatusCode;
            }
        }

        public void UploadImage(string localFilePath, string fileName)
        {
            var url = apiBaseUrl + "/Images";
            var file = localFilePath;

            //read file into upfilebytes array
            var upfilebytes = File.ReadAllBytes(file);

            //create new HttpClient and MultipartFormDataContent and add our file, and StudentId
            HttpClient client = new HttpClient();
            client.Timeout = new TimeSpan(0, 20, 0);
            MultipartFormDataContent content = new MultipartFormDataContent();
            ByteArrayContent baContent = new ByteArrayContent(upfilebytes);
            content.Add(baContent, "File", fileName);


            //upload MultipartFormDataContent content async and store response in response var
            var response = client.PostAsync(url, content);

            //read response result as a string async into json var
            var responsestr = response.Result;

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
