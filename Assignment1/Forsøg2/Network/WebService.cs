using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FileData;
using Forsøg2.Models;

namespace Forsøg2.Network
{
    public class WebService : IfileContext
    {
        private HttpClient client;

        public WebService()
        {
            this.client = new HttpClient();
        }

        public async Task AddAdult(Adult adult)
        {
            Console.WriteLine(adult.ToString());
            string todoSerialized = JsonSerializer.Serialize(adult);
            StringContent content = new StringContent(
                todoSerialized,
                Encoding.UTF8,
                "application/json"
            );
            HttpResponseMessage responseMessage = await client.PostAsync("https://localhost:5004/Adult", content);
            //return responseMessage;
        }

        public void AddFamily(Family family)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IList<Adult>> getAllAdults(string query)
        {
            string httpsJsonplaceholderTypicodeComTodos = "https://localhost:5004/Adult" + query;
            string message = await client.GetStringAsync(httpsJsonplaceholderTypicodeComTodos);
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
        }

        public IList<Family> getAllFamilies()
        {
            throw new System.NotImplementedException();
        }

        public  async Task RemoveAdult(int id)
        {
            HttpResponseMessage message = await client.DeleteAsync("https://localhost:5004/Adult/" + id);
            Console.WriteLine(message.StatusCode);
        }

        public async Task<User> ValidateUser(string username, string password)
        {
            Console.WriteLine(username + "top");
            string httpsJsonplaceholderTypicodeComTodos = "https://localhost:5004/User?username=" + username + "&password=" + password;
            string message = await client.GetStringAsync(httpsJsonplaceholderTypicodeComTodos);
            User result = JsonSerializer.Deserialize<User>(message);
            Console.WriteLine(result.Password);
            return result;
        }
    }
}