using System;
using RestSharp;

namespace welcash_web.Core
{
    public class Request
    {
        public void sendInfo()
        {
            var client = new RestClient("https://5ef09ebead6d71001617a645.mockapi.io");

            var request = new RestRequest("welcash");
            request.AddParameter("application/json", getInfo(), ParameterType.RequestBody);

            var response = client.Post(request);
            Console.WriteLine(getInfo());

        }

        private string getInfo()
        {
            var informer = new Informer();
            var json = informer.toJson();
            return json;
        }
    }
}