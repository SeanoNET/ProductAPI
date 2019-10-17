using System;

namespace ProductClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ProductsClient(new System.Net.Http.HttpClient());
            client.BaseUrl = "https://localhost:44332";

            var product = new Product();
            product.Name = "Test";
            product.Price = 1;

            var res = client.PostProductAsync(product).Result;

            Console.WriteLine($"Created {res.Id} - {res.Name}");
        }
    }
}
