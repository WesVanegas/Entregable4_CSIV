using ServicioAPI.Model;
using System.Text.Json;

namespace ServicioAPI.Util
{
    public class UserClient
    {
        public HttpClient Client {get; set;}

        public UserClient(HttpClient client){
            this.Client = client;
        }

        public async Task<User>? GetUser(string id){
            var response = await this.Client.GetAsync($"https://jsonplaceholder.typicode.com/users/{id}");

            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<User>(content);

        }

    }
    
}