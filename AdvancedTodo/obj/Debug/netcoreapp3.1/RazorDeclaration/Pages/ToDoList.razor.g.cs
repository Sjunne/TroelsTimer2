#pragma checksum "C:\Users\sjunn\RiderProjects\TroelsTimer2\AdvancedTodo\Pages\ToDoList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66bfe644a472d1ba6dce2eaf0ae226957a96f5b7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AdvancedTodo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sjunn\RiderProjects\TroelsTimer2\AdvancedTodo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sjunn\RiderProjects\TroelsTimer2\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sjunn\RiderProjects\TroelsTimer2\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sjunn\RiderProjects\TroelsTimer2\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sjunn\RiderProjects\TroelsTimer2\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sjunn\RiderProjects\TroelsTimer2\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sjunn\RiderProjects\TroelsTimer2\AdvancedTodo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sjunn\RiderProjects\TroelsTimer2\AdvancedTodo\_Imports.razor"
using AdvancedTodo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sjunn\RiderProjects\TroelsTimer2\AdvancedTodo\_Imports.razor"
using AdvancedTodo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sjunn\RiderProjects\TroelsTimer2\AdvancedTodo\Pages\ToDoList.razor"
using AdvancedTodo.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sjunn\RiderProjects\TroelsTimer2\AdvancedTodo\Pages\ToDoList.razor"
using AdvancedTodo.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ToDoList")]
    public partial class ToDoList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\sjunn\RiderProjects\TroelsTimer2\AdvancedTodo\Pages\ToDoList.razor"
       
    private IList<Todo> todosToShow;
    private IList<Todo> allTodos;
    
    private int? filterById;
    private bool? filterByIsCompleted;
/*
    private void FilterByUserId(ChangeEventArgs changeEventArgs) {
        filterById = null;
        try {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        } catch (Exception e) { }
        ExecuteFilter();
    }

   

    private void ExecuteFilter() {
        todosToShow = allTodos.Where(t => 
            (filterById != null && t.UserId == filterById || filterById == null) &&
            (filterByIsCompleted != null && t.IsCompleted == filterByIsCompleted || filterByIsCompleted == null)
            ).ToList();
    }
    
    */

    private void FilterByCompletedStatus(ChangeEventArgs args) {
        filterByIsCompleted = null;
        try {
            filterByIsCompleted = bool.Parse(args.Value.ToString());
        } catch (Exception e) { }
    }



    protected override async Task OnInitializedAsync() {
        //allTodos = await TodosService.GetTodosAsync();
        todosToShow = allTodos;
    }

    private async Task RemoveTodo(int todoId) {
        Todo todoToRemove = todosToShow.First(t => t.TodoId == todoId);
        TodosService.RemoveTodoAsync(todoId);
        allTodos.Remove(todoToRemove);
    }
    
    private async Task CompletedChange(ChangeEventArgs evt, Todo todo) {
        todo.IsCompleted=(bool)evt.Value;
        TodosService.UpdateAsync(todo);
    }

    public async Task loadFilter()
    {
        string query = "";
        if (filterById != null)
        {
            query += "id=" + filterById;
        }
        if (filterByIsCompleted != null)
        {
            if(!query.Equals(""))
            {
                query += "&completed=" + filterByIsCompleted.ToString().ToLower();
            }
            else
            {
                query += "completed=" + filterByIsCompleted.ToString().ToLower();
            }
        }

        if (!(query.Equals("")))
        {
            Console.WriteLine(query);
            Task<IList<Todo>> todosAsync = TodosService.GetTodosAsync("?" + query);
            todosToShow = await todosAsync;
        }
        else
        {
            Task<IList<Todo>> todosAsync = TodosService.GetTodosAsync("");
            todosToShow = await todosAsync;
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITodosService TodosService { get; set; }
    }
}
#pragma warning restore 1591
