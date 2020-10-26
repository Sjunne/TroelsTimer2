using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AdvancedTodo.Models;

namespace AdvancedTodo.Data
{
    public class TodoServiceWeb : ITodosService
    {
        public async Task<IList<Todo>> GetTodosAsync(string filter)
        {
            HttpClient client = new HttpClient();
            string httpsJsonplaceholderTypicodeComTodos = "https://localhost:5003/todo" + filter;
            string message = await client.GetStringAsync(httpsJsonplaceholderTypicodeComTodos);
            List<Todo> result = JsonSerializer.Deserialize<List<Todo>>(message);
            return result;
        }

        public async Task AddTodoAsync(Todo todo)
        {
            HttpClient client = new HttpClient();
            string todoSerialized = JsonSerializer.Serialize(todo);
            StringContent content = new StringContent(
                todoSerialized,
                Encoding.UTF8,
                "application/json"
                );
            HttpResponseMessage responseMessage = await client.PostAsync("https://jsonplaceholder.typicode.com/todos/", content);
            //return responseMessage;
        }

        public async Task RemoveTodoAsync(int todoId)
        {
            HttpClient client = new HttpClient();
            await client.DeleteAsync("https://jsonplaceholder.typicode.com/todos/" + todoId);
        }

        public async Task UpdateAsync(Todo todo)
        {
            HttpClient client = new HttpClient();
            string todoSerialized = JsonSerializer.Serialize(todo);
            StringContent content = new StringContent(
                todoSerialized,
                Encoding.UTF8,
                "application/json"
            );
            await client.PatchAsync("https://jsonplaceholder.typicode.com/todos/", content);
        }
    }
}