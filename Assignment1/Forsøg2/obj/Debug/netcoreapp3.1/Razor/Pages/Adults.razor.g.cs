#pragma checksum "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ab14e46bec2a1837f2d1d2ccd2e603159f8b81e"
// <auto-generated/>
#pragma warning disable 1591
namespace Forsøg2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\_Imports.razor"
using Forsøg2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\_Imports.razor"
using Forsøg2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor"
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
            __builder.AddMarkupContent(0, "<h3>Adults</h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Search Criteria: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor"
                                                    (arg) => ExecuteFilter(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width:50px");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\r\n        Sex:<br>\r\n        ");
            __builder.OpenElement(12, "select");
            __builder.AddAttribute(13, "rows", "4");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor"
                                searchValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchValue = __value, searchValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "option");
            __builder.AddAttribute(18, "value", true);
            __builder.AddContent(19, "Select sex...");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "option");
            __builder.AddAttribute(22, "value", "Age");
            __builder.AddContent(23, "Age");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "option");
            __builder.AddAttribute(26, "value", "FirstName");
            __builder.AddContent(27, "FirstName");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "value", "LastName");
            __builder.AddContent(31, "LastName");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "option");
            __builder.AddAttribute(34, "value", "EyeColour");
            __builder.AddContent(35, "EyeColour");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "option");
            __builder.AddAttribute(38, "value", "HairColour");
            __builder.AddContent(39, "HairColour");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenElement(41, "option");
            __builder.AddAttribute(42, "value", "Height");
            __builder.AddContent(43, "Height");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "option");
            __builder.AddAttribute(46, "value", "Weight");
            __builder.AddContent(47, "Weight");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n");
#nullable restore
#line 25 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor"
 if (adultsToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "    ");
            __builder.AddMarkupContent(52, "<p>\r\n        <em>Loading...</em>\r\n    </p>\r\n");
#nullable restore
#line 30 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor"
    
} else if (!adultsToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "    ");
            __builder.AddMarkupContent(54, "<p>\r\n        <em>No Adults exist. Please add some.</em>\r\n    </p>\r\n");
#nullable restore
#line 36 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "    ");
            __builder.OpenElement(56, "table");
            __builder.AddAttribute(57, "class", "table");
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.AddMarkupContent(59, @"<thead>
        <tr>
            <th>ID</th>
            <th>FirstName</th>
            <th>LastName</th>
            <th>HairColor</th>
            <th>EyeColor</th>
            <th>Age</th>
            <th>Weight</th>
            <th>Height</th>
            <th>Sex</th>
        </tr>
        </thead>
        ");
            __builder.OpenElement(60, "tbody");
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 54 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor"
         foreach (var item in adultsToShow) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "            ");
            __builder.OpenElement(63, "tr");
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.OpenElement(65, "td");
            __builder.AddContent(66, 
#nullable restore
#line 56 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                ");
            __builder.OpenElement(68, "td");
            __builder.AddContent(69, 
#nullable restore
#line 57 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.OpenElement(71, "td");
            __builder.AddContent(72, 
#nullable restore
#line 58 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.OpenElement(74, "td");
            __builder.AddContent(75, 
#nullable restore
#line 59 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor"
                     item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                ");
            __builder.OpenElement(77, "td");
            __builder.AddContent(78, 
#nullable restore
#line 60 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor"
                     item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                ");
            __builder.OpenElement(80, "td");
            __builder.AddContent(81, 
#nullable restore
#line 61 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                ");
            __builder.OpenElement(83, "td");
            __builder.AddContent(84, 
#nullable restore
#line 62 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor"
                     item.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                ");
            __builder.OpenElement(86, "td");
            __builder.AddContent(87, 
#nullable restore
#line 63 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor"
                     item.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.OpenElement(89, "td");
            __builder.AddContent(90, 
#nullable restore
#line 64 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor"
                     item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n");
#nullable restore
#line 66 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(93, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
#nullable restore
#line 69 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor"
    
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Adults.razor"
       
    private IList<Adult> adultsToShow;
    private IList<Adult> allAdults;

    private string nameFilter;
    private int minAge;

    private string searchValue = "";
    
    protected override async Task OnInitializedAsync() {
        allAdults = File.getAllAdults();
        adultsToShow = allAdults;
    }
    
    private void FilterByName(ChangeEventArgs changeEventArgs) {
        nameFilter = null;
        try
        {
            nameFilter = changeEventArgs.Value.ToString();
        } catch (Exception e) { }
    }
    
    private void FilterByAge(ChangeEventArgs changeEventArgs)
    {
        minAge = 0;
        try
        {
            minAge = int.Parse(changeEventArgs.Value.ToString());
        } catch (Exception e) { }
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
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IfileContext File { get; set; }
    }
}
#pragma warning restore 1591
