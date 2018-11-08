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
    public class ApiClient : IApiClient
    {
        private readonly ICiuchAppSettings _settings;
        private readonly string apiBaseUrl;

        public ApiClient(ICiuchAppSettings settings)
        {
            _settings = settings;
            apiBaseUrl = _settings.Urls.ApiUrl;
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
            catch
            {
                throw new Exception($"Cound not connect to ApiUrl: {restApiUri}. Check if page works fine");
            }
        }

        public bool Add<T>(T item) where T : CiuchAppModelBase
        {
            if (item.IsValid<T>(newItem: true))
            {
                string nameOfController = GetNameOfController<T>();
                Uri restApiUri = new Uri($@"{apiBaseUrl}/{nameOfController}");

                using (var httpClient = new HttpClient())
                {
                    var values = item.ToKeyValuePairs<T>(newItem: true);
                    var content = new FormUrlEncodedContent(values);

                    var result = httpClient.PostAsync(restApiUri, content).Result;
                    if (result.IsSuccessStatusCode)
                        return true;
                    else
                        return false;
                }
            }
            throw new FormatException("Model is not valid to be added");
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

                    var result = httpClient.PutAsync(restApiUri, content).Result;
                    if (result.IsSuccessStatusCode)
                        return true;
                    else
                        return false;
                }
            }
            throw new FormatException("Model is not valid to be updated");
        }


        public List<Piece> GetPiecesByBusinessTripId(int id)
        {
            return GetList<Piece>(id, "BusinessTrips");
        }

        //public bool UploadImage(Stream fileStream, string fileName)
        //{
        //    HttpContent fileStreamContent = new StreamContent(fileStream);
        //    fileStreamContent.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data") { Name = "file", FileName = fileName };
        //    fileStreamContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
        //    using (var client = new HttpClient())
        //    using (var formData = new MultipartFormDataContent())
        //    {
        //        formData.Add(fileStreamContent);
        //        var response = client.PostAsync(apiBaseUrl + "Images", formData).Result;
        //        return response.IsSuccessStatusCode;
        //    }
        //}

        public bool UploadImage(string localFilePath, string fileName)
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
            return response.Result.IsSuccessStatusCode;
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
