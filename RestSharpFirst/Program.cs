using RestSharp;
using System;
using System.Threading.Tasks;

namespace RestSharpFirst
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string baseurl = "https://jsonplaceholder.typicode.com/todos";

            var client = new RestClient(baseurl);

            var req = new RestRequest();
            req.AddParameter("id", "1");
            var resp = await client.GetAsync(req);

            Console.WriteLine(resp.Content.ToString());

            Console.ReadLine();
        }
    }
}
