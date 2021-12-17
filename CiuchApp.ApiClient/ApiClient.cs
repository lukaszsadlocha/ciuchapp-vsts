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
        private readonly string _apiBaseUrl;
        private readonly IUriGenerator _uriGenerator;

        public ApiClient(ICiuchAppSettings settings, IUriGenerator urlGenerator)
        {
            _settings = settings;
            _apiBaseUrl = _settings.Urls.ApiUrl;
            _uriGenerator = urlGenerator;
            urlGenerator.Set(_apiBaseUrl);
        }

        public async Task<CacheContext> GetCacheAsync()
        {
            Uri restApiUri = _uriGenerator.GetCacheUri();
            
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.Timeout = new TimeSpan(0, 0, 10);
                    var response = await httpClient.GetAsync(restApiUri);
                    response.EnsureSuccessStatusCode();
                    var result = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<CacheContext>(result);
                }
            }
            catch
            {
                throw new Exception($"Cound not connect to ApiUrl: {restApiUri}. Check if page works fine");
            }
        }

        public List<T> GetList<T>(int id = 0, string baseController = "")
        {
            Uri restApiUri;
            if (id != 0 && !string.IsNullOrEmpty(baseController))
            {
                restApiUri = _uriGenerator.GetDeepUri<T>(baseController, id);
            }
            else
            {
                restApiUri = _uriGenerator.GetUri<T>();
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

        public bool Add<T>(T item) where T : CiuchAppBaseModel
        {
            if (item.IsValid<T>(newItem: true))
            {
                var restApiUri = _uriGenerator.GetUri<T>();

                using (var httpClient = new HttpClient())
                {
                    var values = item.ToKeyValuePairs<T>(newItem: true);
                    var content = new FormUrlEncodedContent(values);

                    var result = httpClient.PostAsync(restApiUri, content).Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var response = result.Content.ReadAsStringAsync().Result;
                        //there should be id of newly added item in the resposne
                        item.Id = int.Parse(response);
                        return true;
                    }
                    else
                        return false;
                }
            }
            throw new FormatException("Model is not valid to be added");
        }

        public bool Update<T>(T item) where T : CiuchAppBaseModel
        {
            if (item.IsValid<T>(newItem: false))
            {
                var restApiUri = _uriGenerator.GetUri<T>();

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
            var uri = _uriGenerator.GetImageUri();

            var file = localFilePath;

            //read file into upfilebytes array
            var upfilebytes = File.ReadAllBytes(file);

            //create new HttpClient and MultipartFormDataContent and add our file, and StudentId
            HttpClient client = new HttpClient
            {
                Timeout = new TimeSpan(0, 20, 0)
            };
            MultipartFormDataContent content = new MultipartFormDataContent();
            ByteArrayContent baContent = new ByteArrayContent(upfilebytes);
            content.Add(baContent, "File", fileName);

            //upload MultipartFormDataContent content async and store response in response var
            var response = client.PostAsync(uri.ToString(), content);

            //read response result as a string async into json var
            return response.Result.IsSuccessStatusCode;
        }



        public List<Piece> GetPieces()
        {
            throw new NotImplementedException();
        }
    }
}
