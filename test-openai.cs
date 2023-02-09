using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Create an instance of HttpClient
            var client = new HttpClient();

            // Make a GET request to the API endpoint
            var response = await client.GetAsync("https://api.example.com/data");

            // Check that the response was successful
            if (response.IsSuccessStatusCode)
            {
                // Read the response content as a string
                var content = await response.Content.ReadAsStringAsync();

                // Deserialize the JSON string into a C# object
                var data = JsonSerializer.Deserialize<Data>(content);

                // Use the deserialized data
                Console.WriteLine("Data received:");
                Console.WriteLine("Name: " + data.Name);
                Console.WriteLine("Age: " + data.Age);
                Console.WriteLine("City: " + data.City);
            }
            else
            {
                Console.WriteLine("Request failed with status code: " + response.StatusCode);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

    class Data
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
