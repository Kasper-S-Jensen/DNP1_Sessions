// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\Pages\Families.razor"
using Assignment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\Pages\Families.razor"
using Assignment1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\Pages\Families.razor"
using Microsoft.Net.Http.Headers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Families")]
    public partial class Families : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 157 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\Pages\Families.razor"
       

    private IList<Family> familiesToShow;
    private IList<int> houseNumbers = new List<int>();
    private IList<Family> allFamilies;
    private Family currentFamily = new Family();
    private string? filterByString;


    protected override async Task OnInitializedAsync()
    {
       await Updatefamilies();
    }

    private async Task Updatefamilies()
    {
        allFamilies = await familyData.GetFamiliesAsync();
        familiesToShow = null;
    }

    private void FilterByFamily(string streetName)
    {
        currentFamily.StreetName = streetName;

        houseNumbers.Clear();
        foreach (var family in allFamilies)
        {
            if (family.StreetName.Equals(currentFamily.StreetName))
            {
                houseNumbers.Add(family.HouseNumber);
            }
        }
    }

    private void FilterFamilies()
    {
        ExecuteFamilyFilter();
        Console.WriteLine("inside filterfamilies filter");
    }

    private void ExecuteFamilyFilter()
    {
        familiesToShow = allFamilies.Where(f => (currentFamily.StreetName.Equals(f.StreetName) && currentFamily.HouseNumber == f.HouseNumber && currentFamily.StreetName != null)).ToList();
        Console.WriteLine("inside executefamilyfilter");
    }


    private async Task RemoveAdult(int adultId)
    {
        await familyData.RemoveAdultAsync(adultId);
        await Updatefamilies();
    }

    private async Task RemoveFamily(string streetName, int houseNumber)
    {
        if (!await JSRuntime.InvokeAsync<bool>("confirm", $"Are you sure you want to remove the family at '{currentFamily.StreetName} {currentFamily.HouseNumber}', and all of its members?"))
            return;
        Console.WriteLine(currentFamily.HouseNumber + currentFamily.StreetName);

        Family familyToRemove = allFamilies.FirstOrDefault(f => (currentFamily.StreetName.Equals(f.StreetName) && currentFamily.HouseNumber == f.HouseNumber && currentFamily.StreetName != null));
        await familyData.RemoveFamilyAsync(streetName, houseNumber);
        allFamilies.Remove(familyToRemove);
        familiesToShow.Remove(familyToRemove);
        await Updatefamilies();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyData familyData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
