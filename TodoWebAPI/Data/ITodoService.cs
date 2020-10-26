using System.Collections.Generic;
using System.Threading.Tasks;
using TodoWebAPI.Models;

namespace TodoWebAPI.Data
{
    public interface ITodoService {
        Task<IList<Todo>> GetTodosAsync(bool? iscomplte, int? id);
        Task   AddTodoAsync(Todo todo);
        Task   RemoveTodoAsync(int todoId);
        Task   UpdateAsync(Todo todo);
    }
}