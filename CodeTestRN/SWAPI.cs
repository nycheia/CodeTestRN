using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace CodeTestRN
{
    public class SWAPI
    {
        private readonly RestClient _client;

        public SWAPI()
        {
            _client = new RestClient("https://swapi.dev/");
        }

        /*[HttpGet("{id}")]
        public async Task<RestResponse<T>> ExecuteAsync(RestRequest request)
        {

            var request = new RestRequest("api/people/{id}");
            var response = await _client.GetJsonAsync<TResponse>(request);

            _client.
            /*var response = await _client.ExecuteGetAsync(request);

            if(response.ErrorException != null)
            {
                throw response.ErrorException;
            }

            return ;
        }*/

        public void GetPeople()
        {
            var request = new RestRequest(_client + "api/people/1");
            var response = _client.GetAsync(request);
            Console.WriteLine(response.Result.ToString());
            Console.Read();
        }
    }
}
