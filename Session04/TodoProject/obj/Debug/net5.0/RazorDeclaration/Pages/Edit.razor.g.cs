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
#line 2 "D:\Dokumenter D\Git\DNP1_Assignments\Session04\TodoProject\Pages\Edit.razor"
using TodoProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Dokumenter D\Git\DNP1_Assignments\Session04\TodoProject\Pages\Edit.razor"
using TodoProject.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Edit/{Id:int}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "D:\Dokumenter D\Git\DNP1_Assignments\Session04\TodoProject\Pages\Edit.razor"
       

    [Parameter]
    public int Id { get; set; }

    private Todo todoToEdit;

    protected override async Task OnInitializedAsync()
    {
        todoToEdit = TodoData.Get(Id);
    }

    private void Save()
    {
        TodoData.Update(todoToEdit);
        NavMgr.NavigateTo("/ Todos");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITodoData TodoData { get; set; }
    }
}
#pragma warning restore 1591
