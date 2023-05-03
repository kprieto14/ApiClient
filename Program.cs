using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiClient
{
  class Program
  {
    static async Task Main(string[] args)
    {
      var client = new HttpClient();

      var responseBody = await client.GetStreamAsync("https://dog.ceo/api/breeds/image/random");

      var items = await JsonSerializer.DeserializeAsync<Item>(responseBody);

      Console.WriteLine("\nWelcome to my beginner API app! ");
      Console.WriteLine($"{items.status}! Here is your random dog's URL 🐶 : {items.message}. I wish you could see how cute it is.\n");
    }
  }
}
