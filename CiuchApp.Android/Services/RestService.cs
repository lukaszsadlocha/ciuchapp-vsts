using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CiuchApp.Domain;
using Newtonsoft.Json;

namespace CiuchApp.Android.Services
{
    public class RestService
    {
        private Uri restApiUri;

        public RestService()
        {
            var RestUrl = @"http://10.0.2.2:13121/api/BusinessTrips";
            restApiUri = new Uri(string.Format(RestUrl, string.Empty));
        }

        public List<BusinessTrip> GetBusinessTrips()
        {
            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetAsync(restApiUri).Result;
                var result = response.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject<List<BusinessTrip>>(result);
            }

        }
        public async Task<List<BusinessTrip>> GetBusinessTripsAsync()
        {

            var RestUrl = @"http://10.0.2.2:13121/api/BusinessTrips";
            var uri = new Uri(string.Format(RestUrl, string.Empty));
            var client = new HttpClient();
            var response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return await Task.Run(() => JsonConvert.DeserializeObject<List<BusinessTrip>>(content));

            }
            return null;
        }

        internal List<Piece> GetClothesByBusinessTripId(int id)
        {
            throw new NotImplementedException();
        }

        internal List<Piece> GetPieces()
        {
            throw new NotImplementedException();
        }
    }
}