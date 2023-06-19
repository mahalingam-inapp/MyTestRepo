using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace FetchDataFromAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("An error occurred while fetching data from the API.");
            }
        }
    }
}
