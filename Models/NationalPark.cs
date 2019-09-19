using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace parks_mvc.Models
{
    public class NationalPark
    {
        public int NationalParkId {get; set;}
        public int StateId { get; set; }
        public string ParkName { get; set; }
        public double AvgRating { get; set; }

        public ICollection<Review> Reviews { get; set; }
        
        public static Task<IRestResponse> GetResponseContentAsync(RestClient theClient, RestRequest theRequest)
        {
            var tcs = new TaskCompletionSource<IRestResponse>();
            theClient.ExecuteAsync(theRequest, response => {
                tcs.SetResult(response);
            });
            return tcs.Task;
        }

        // Display all the NationalParks
        public static List<NationalPark> GetNationalParks()
        {
            var client = new RestClient("http://localhost:5000/api/");
            var request = new RestRequest("nationalParks", Method.GET);
            var response = new RestResponse();

            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(response.Content);
            var nationalParkList = JsonConvert.DeserializeObject<List<NationalPark>>(jsonResponse.ToString());
            return nationalParkList;
        }

        // Add new NationalPark
        public static void PostNationalPark(NationalPark nationalPark)
        {
            var client = new RestClient("http://localhost:5000/api/");
            var request = new RestRequest("nationalParks", Method.POST);
            request.AddJsonBody(nationalPark);
            var response = new RestResponse();

            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
        }

        // Display Particular National Park
        public static NationalPark GetPaticularNationalPark(int id)
        {
            var client= new RestClient("http://locathost:5000/api");
            var request = new RestRequest("nationalParks/" +id, Method.GET);
            var response = new RestResponse();
            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
        JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(response.Content);
        var thisNationalPark = JsonConvert.DeserializeObject<NationalPark>(jsonResponse.ToString());
        return thisNationalPark;
        }

         // Delete particular NationalPark
        public static void DeleteNationalPark(int id)
        {
            var client = new RestClient("http://localhost:5000/api/");
            var request = new RestRequest("nationalParks/"+id, Method.DELETE);
            var response = new RestResponse();

            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
        }

        // Editing a particular NationalPark
        public static void EditNationalPark(int id, NationalPark nationalPark)
        {
            var client = new RestClient("http://localhost:5000/api/");
            var request = new RestRequest("nationalParks/"+id, Method.PUT);
            request.AddJsonBody(nationalPark);
            var response = new RestResponse();

            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
        }
    }
}