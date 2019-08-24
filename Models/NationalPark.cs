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
        public string UserName { get; set; }
        public int Rating { get; set; }
        public string NationalParkText { get; set; }

        public static Task<IRestResponse> GetResponseContentAsync(RestClient theClient, RestRequest theRequest)
        {
            var tcs = new TaskCompletionSource<IRestResponse>();
            theClient.ExecuteAsync(theRequest, response => {
                tcs.SetResult(response);
            });
            return tcs.Task;
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
    }
}