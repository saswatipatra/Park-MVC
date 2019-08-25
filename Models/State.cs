using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.EntityFrameworkCore;

namespace parks_mvc.Models
{
    public class State
    {
        public int StateId {get; set;}
        public string StateName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
      

        public ICollection<NationalPark> NationalParks { get; set; }

        public static Task<IRestResponse> GetResponseContentAsync(RestClient theClient, RestRequest theRequest)
        {
            var tcs = new TaskCompletionSource<IRestResponse>();
            theClient.ExecuteAsync(theRequest, response => {
                tcs.SetResult(response);
            });
            return tcs.Task;
        }

        // Display first page of States
        public static List<State> GetStates()
        {
            var client = new RestClient("http://localhost:5000/api/");
            var request = new RestRequest("states", Method.GET);
            var response = new RestResponse();

            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(response.Content);
            var StateList = JsonConvert.DeserializeObject<List<State>>(jsonResponse.ToString());
            return StateList;
        }

        // Display next page of States
        public static List<State> GetNextStates()
        {
            var client = new RestClient("http://localhost:5000/api/");
            var request = new RestRequest("states/next", Method.GET);
            var response = new RestResponse();

            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(response.Content);
            var StateList = JsonConvert.DeserializeObject<List<State>>(jsonResponse.ToString());
            return StateList;
        }

        // Display prev page of States
        public static List<State> GetPrevStates()
        {
            var client = new RestClient("http://localhost:5000/api/");
            var request = new RestRequest("states/prev", Method.GET);
            var response = new RestResponse();

            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(response.Content);
            var StateList = JsonConvert.DeserializeObject<List<State>>(jsonResponse.ToString());
            return StateList;
        }

        // Display particular State 
        public static State GetPaticularStates(int id)
        {
            var client = new RestClient("http://localhost:5000/api/");
            var request = new RestRequest("states/" + id, Method.GET);
            var response = new RestResponse();

            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(response.Content);
            var thisState = JsonConvert.DeserializeObject<State>(jsonResponse.ToString());
            return thisState;
        }

        // Add new State
        public static void PostState(State state)
        {
            var client = new RestClient("http://localhost:5000/api/");
            var request = new RestRequest("states", Method.POST);
            request.AddJsonBody(state);
            var response = new RestResponse();

            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
        }

        // Delete particular State
        public static void DeleteState(int id)
        {
            var client = new RestClient("http://localhost:5000/api/");
            var request = new RestRequest("states/"+id, Method.DELETE);
            var response = new RestResponse();

            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
        }

        // Editing a particular State
        public static void EditState(int id, State state)
        {
            var client = new RestClient("http://localhost:5000/api/");
            var request = new RestRequest("states/"+id, Method.PUT);
            request.AddJsonBody(state);
            var response = new RestResponse();

            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
        }


        
    }
}