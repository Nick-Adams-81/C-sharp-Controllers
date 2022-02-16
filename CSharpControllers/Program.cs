using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace CSharpControllers
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var client = new HttpClient())
            //{
            //    var endpoint = new Uri("https://jsonplaceholder.typicode.com/posts");
            //    var result = client.GetAsync(endpoint).Result;
            //    var json = result.Content.ReadAsStringAsync().Result;
            //}


            using(var client2 = new HttpClient())
            {
                var endpoint = new Uri("https://jsonplaceholder.typicode.com/posts");
                var newPost = new Post()
                {
                    Title = "Test post",
                    Body = "Hello world!",
                    UserId = 55
                };
                var newPostJson = JsonConvert.SerializeObject(newPost);
                var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                var result = client2.PostAsync(endpoint, payload).Result.Content.ReadAsStringAsync().Result;


            }
        }
    }
}
