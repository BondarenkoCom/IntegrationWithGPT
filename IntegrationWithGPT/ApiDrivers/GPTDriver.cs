using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationWithGPT.ApiDrivers
{
    public class GPTDriver : IDriver
    {
        public string SendRequest()
        {
            string token = "secret";
            var prompt = "Hello, i love you";
            var endpoint = "https://api.openai.com/v1/engines/davinci/completions";
            var client = new HttpClient();

            var requestContent = new StringContent(prompt, Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = client.PostAsync(endpoint, requestContent).Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("POST request was successful");
                Console.WriteLine("Response: " + response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                Console.WriteLine("POST request was unsuccessful");
                Console.WriteLine("Response: " + response.StatusCode);
            }
            Console.ReadLine();

            return null;
        }
    }
}
