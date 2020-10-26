using System.Collections.Generic;
using System.Threading.Tasks;
using AdvancedTodo.Models;

namespace AdvancedTodo.Data
{
    public interface ITodosService {
        Task<IList<Todo>> GetTodosAsync(string Filter);
        Task   AddTodoAsync(Todo todo);
        Task   RemoveTodoAsync(int todoId);
        Task   UpdateAsync(Todo todo);
    }
}