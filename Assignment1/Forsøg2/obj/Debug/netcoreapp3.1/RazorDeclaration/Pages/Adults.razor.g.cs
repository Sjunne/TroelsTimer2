#pragma checksum "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f51c5b7b344c8b590bd32ab314b378aa071dc57d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Forsøg2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\_Imports.razor"
using Forsøg2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\_Imports.razor"
using Forsøg2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor"
using FileData;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor"
       
    private IList<Adult> adultsToShow;
    private IList<Adult> allAdults;

    private string nameFilter;
    private int minAge;
    private FilterComponent filterComponent;

    private string searchValue = "";
    
    protected override async Task OnInitializedAsync() {
        //allAdults = await File.getAllAdults(); Dont wanna overload
        adultsToShow = new List<Adult>();
    }

    private void ExecuteFilter(ChangeEventArgs changeEventArgs)
    {
        nameFilter = changeEventArgs.Value.ToString();
        try
        {
            switch (searchValue)
            {
                case "FirstName":
                    adultsToShow = allAdults.Where(t =>
                        (nameFilter != null && t.FirstName.Contains(nameFilter) || string.IsNullOrEmpty(nameFilter))).ToList();
                    break;

                case "LastName":
                    adultsToShow = allAdults.Where(t =>
                        (nameFilter != null && t.LastName.Contains(nameFilter) || string.IsNullOrEmpty(nameFilter))).ToList();
                    break;

                case "Age":
                    adultsToShow = allAdults.Where(t => (nameFilter != null && t.Age == int.Parse(nameFilter) || string.IsNullOrEmpty(nameFilter))).ToList();
                    break;

                case "EyeColour":
                    adultsToShow = allAdults.Where(t =>
                        (nameFilter != null && t.EyeColor.Contains(nameFilter) || string.IsNullOrEmpty(nameFilter))).ToList();
                    break;

                case "HairColour":
                    adultsToShow = allAdults.Where(t =>
                        (nameFilter != null && t.HairColor.Contains(nameFilter) || string.IsNullOrEmpty(nameFilter))).ToList();
                    break;

                case "Height":
                    adultsToShow = allAdults.Where(t => (nameFilter != null && t.Height == int.Parse(nameFilter) || string.IsNullOrEmpty(nameFilter))).ToList();
                    break;

                case "Weight":
                    adultsToShow = allAdults.Where(t => (nameFilter != null && t.Weight == float.Parse(nameFilter) || string.IsNullOrEmpty(nameFilter))).ToList();
                    break;
            }
        }
        catch (FormatException e)
        {
            adultsToShow = allAdults;
        }
    }

    private async void ApplyFilter()
    {
        string query = "";
        if (filterComponent.firstName != null)
        {
            query += "firstName=" + filterComponent.firstName;
        }
        if (filterComponent.lastName != null)
        {
            if(!query.Equals(""))
            {
                query += "&lastName=" + filterComponent.lastName;
            }
            else
            {
                query += "lastname=" + filterComponent.lastName;
            }
        }
        if (filterComponent.jobTitle != null)
        {
            if(!query.Equals(""))
            {
                query += "&jobTitle=" + filterComponent.jobTitle;
            }
            else
            {
                query += "jobTitle=" + filterComponent.jobTitle;
            }
        }
        if (filterComponent.eyeColor != null)
        {
            if(!query.Equals(""))
            {
                query += "&eyeColor=" + filterComponent.eyeColor;
            }
            else
            {
                query += "eyeColor=" + filterComponent.eyeColor;
            }
        }
        if (filterComponent.sex != null)
        {
            if(!query.Equals(""))
            {
                query += "&sex=" + filterComponent.sex;
            }
            else
            {
                query += "sex=" + filterComponent.sex;
            }
        }
        if (filterComponent.hairColor != null)
        {
            if(!query.Equals(""))
            {
                query += "&hairColor=" + filterComponent.hairColor;
            }
            else
            {
                query += "hairColor=" + filterComponent.hairColor;
            }
        }
        if (filterComponent.age != null)
        {
            if(!query.Equals(""))
            {
                query += "&age=" + filterComponent.age;
            }
            else
            {
                query += "age=" + filterComponent.age;
            }
        }
        if (filterComponent.height != null)
        {
            if(!query.Equals(""))
            {
                query += "&height=" + filterComponent.height;
            }
            else
            {
                query += "height=" + filterComponent.height;
            }
        }
        if (filterComponent.weight != null)
        {
            if(!query.Equals(""))
            {
                query += "&weight=" + filterComponent.weight;
            }
            else
            {
                query += "jobtitle=" + filterComponent.weight;
            }
        }
        if (filterComponent.id != null)
        {
            if(!query.Equals(""))
            {
                query += "&id=" + filterComponent.id;
            }
            else
            {
                query += "id=" + filterComponent.id;
            }
        }
        if (query != "")
        {
            Console.WriteLine(query);
            adultsToShow = await File.getAllAdults("?" + query);
            StateHasChanged();
            Console.WriteLine(adultsToShow.Count);
        }
        else
        {
            Console.WriteLine(query + "tom");
            adultsToShow = await File.getAllAdults("");
            StateHasChanged();
        }
        filterComponent.firstName = null;
        filterComponent.lastName = null;
        filterComponent.age = null;
        filterComponent.height = null;
        filterComponent.id = null;
        filterComponent.sex = null;
        filterComponent.eyeColor = null;
        filterComponent.weight = null;
        filterComponent.hairColor = null;
        
    }

    private void RemoveAdult(in int itemId)
    {
        Console.WriteLine(itemId);
        File.RemoveAdult(itemId);
        ApplyFilter();
        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IfileContext File { get; set; }
    }
}
#pragma warning restore 1591
