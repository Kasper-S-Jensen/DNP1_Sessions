// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TodoProject.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Dokumenter D\Git\DNP1_Assignments\Session04\TodoProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dokumenter D\Git\DNP1_Assignments\Session04\TodoProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Dokumenter D\Git\DNP1_Assignments\Session04\TodoProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Dokumenter D\Git\DNP1_Assignments\Session04\TodoProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Dokumenter D\Git\DNP1_Assignments\Session04\TodoProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Dokumenter D\Git\DNP1_Assignments\Session04\TodoProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Dokumenter D\Git\DNP1_Assignments\Session04\TodoProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Dokumenter D\Git\DNP1_Assignments\Session04\TodoProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Dokumenter D\Git\DNP1_Assignments\Session04\TodoProject\_Imports.razor"
using TodoProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Dokumenter D\Git\DNP1_Assignments\Session04\TodoProject\_Imports.razor"
using TodoProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dokumenter D\Git\DNP1_Assignments\Session04\TodoProject\Pages\Todos.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Dokumenter D\Git\DNP1_Assignments\Session04\TodoProject\Pages\Todos.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Todos")]
    public partial class Todos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "D:\Dokumenter D\Git\DNP1_Assignments\Session04\TodoProject\Pages\Todos.razor"
       

    private IList<Todo> todosToShow;
    private IList<Todo> allTodos;
    private int? filterById;
    private bool? filterByIsCompleted;

    private void FilterByUserId(ChangeEventArgs changeEventArgs)
    {
        filterById = null;
        try
        {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void FilterByCompletedStatus(ChangeEventArgs args)
    {
        filterByIsCompleted = null;
        try
        {
            filterByIsCompleted = bool.Parse(args.Value.ToString());
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void ExecuteFilter()
    {
        todosToShow = allTodos.Where(t => (filterById != null && t.UserID == filterById || filterById == null) && (filterByIsCompleted != null && t.IsCompleted == filterByIsCompleted || filterByIsCompleted == null)).ToList();
    }


    protected override async Task OnInitializedAsync()
    {
        allTodos =  await TodoData.GetTodosAsync();
        todosToShow = allTodos;
    }

    private async Task RemoveTodo(int todoId)
    {
        Todo todoToRemove = allTodos.First(t => t.TodoID == todoId);
        await TodoData.RemoveTodoAsync(todoId);
        allTodos.Remove(todoToRemove);
        todosToShow.Remove(todoToRemove);
    }

    private async Task CompletedChange(ChangeEventArgs evt, Todo todo)
    {
        todo.IsCompleted = (bool) evt.Value;
        await TodoData.UpdateAsync(todo);
    }

    private void Edit(int id)
    {
        NavMgr.NavigateTo($"Edit/{id}");
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITodoData TodoData { get; set; }
    }
}
#pragma warning restore 1591
