using IdentityModel.Client;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace ProductClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // discover endpoints from metadata
            var client = new HttpClient();
            var disco = client.GetDiscoveryDocumentAsync("http://localhost:5000").Result;
            if (disco.IsError)
            {
                Console.WriteLine(disco.Error);
                return;
            }

            // request token
            var tokenResponse = client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = disco.TokenEndpoint,

                ClientId = "client",
                ClientSecret = "secret1234",
                Scope = "productapi"
            }).Result;

            if (tokenResponse.IsError)
            {
                Console.WriteLine(tokenResponse.Error);
                return;
            }

            client.SetBearerToken(tokenResponse.AccessToken);

            var apiClient = new ProductsClient(client);
            apiClient.BaseUrl = "http://localhost:5001";

            var product = new Product();
            product.Name = "Test2";
            product.Price = 3;

            var res = apiClient.PostProductAsync(product).Result;

            Console.WriteLine($"Created {res.Id} - {res.Name}");
        }
    }
}
