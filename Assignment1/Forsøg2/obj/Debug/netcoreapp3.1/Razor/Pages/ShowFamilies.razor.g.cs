#pragma checksum "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5225796b0ae50eadb45b703783a052467c95a7df"
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
#line 3 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
using Syncfusion.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ShowFamilies")]
    public partial class ShowFamilies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Test123</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, @"<head>
    <style>
    /* Style the buttons that are used to open and close the accordion panel */
    .accordion {
      background-color: #eee;
      color: #444;
      cursor: pointer;
      padding: 18px;
      width: 100%;
      text-align: left;
      border: none;
      outline: none;
      transition: 0.4s;
      margin: 5px;
    }
    
    /* Add a background color to the button if it is clicked on (add the .active class with JS), and when you move the mouse over it (hover) */
    .active, .accordion:hover {
      background-color: #ccc;
    }
    
    /* Style the accordion panel. Note: hidden by default */
    .panel {
      padding: 0 18px;
      background-color: white;
      display: none;
      overflow: hidden;
    }
  </style>
</head>
    

");
#nullable restore
#line 41 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
 if (families == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p>\r\n        <em>Loading...</em>\r\n    </p>\r\n");
#nullable restore
#line 46 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
}
else if (!families.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.AddMarkupContent(5, "<p>\r\n        <em>No Adults exist. Please add some.</em>\r\n    </p>\r\n");
#nullable restore
#line 52 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddMarkupContent(10, "<thead>\r\n        </thead>\r\n        ");
            __builder.OpenElement(11, "tbody");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 59 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
         for (int i = 0; i < families.Count; i++)
        {
            int copy = i; //out of scope counter thing? 

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "            ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "accordion");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                          e => Flip(copy)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Street: ");
            __builder.AddContent(22, 
#nullable restore
#line 64 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                                                     families[i].StreetName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, ", House Number: ");
            __builder.AddContent(24, 
#nullable restore
#line 64 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                                                                                            families[i].HouseNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "panel");
            __builder.AddAttribute(28, "style", 
#nullable restore
#line 65 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                familiesAcc[copy] ? "display: block;" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "p");
            __builder.AddMarkupContent(31, "\r\n                            ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "accordion");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                                  e => FlipAdults(copy)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "Adults");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "panel");
            __builder.AddAttribute(39, "style", 
#nullable restore
#line 68 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                        adultsAcc[copy] ? "display: block;" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(40, "\r\n                                ");
            __builder.OpenElement(41, "table");
            __builder.AddAttribute(42, "class", "table");
            __builder.AddMarkupContent(43, "\r\n                                    ");
            __builder.AddMarkupContent(44, @"<thead>
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
            __builder.OpenElement(45, "tbody");
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 84 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                     foreach (var item in families[i].Adults)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "                                        ");
            __builder.OpenElement(48, "tr");
            __builder.AddMarkupContent(49, "\r\n                                            ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 87 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                 item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                                            ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 88 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                 item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                            ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 89 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                 item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                                            ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 90 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                 item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                                            ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 91 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                 item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                                            ");
            __builder.OpenElement(65, "td");
            __builder.AddContent(66, 
#nullable restore
#line 92 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                 item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                                            ");
            __builder.OpenElement(68, "td");
            __builder.AddContent(69, 
#nullable restore
#line 93 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                 item.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                                            ");
            __builder.OpenElement(71, "td");
            __builder.AddContent(72, 
#nullable restore
#line 94 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                 item.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                                            ");
            __builder.OpenElement(74, "td");
            __builder.AddContent(75, 
#nullable restore
#line 95 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                 item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 97 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(78, "                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                            ");
            __builder.OpenElement(82, "button");
            __builder.AddAttribute(83, "class", "accordion");
            __builder.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 101 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                                  e => FlipChildren(copy)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(85, "Children");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                            ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "panel");
            __builder.AddAttribute(89, "style", 
#nullable restore
#line 102 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                        ChildrenAcc[copy] ? "display: block;" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(90, "\r\n");
#nullable restore
#line 103 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                 for (int j = 0; j < families[i].Children.Count; j++)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(91, "                                    ");
            __builder.OpenElement(92, "h3");
            __builder.AddContent(93, 
#nullable restore
#line 105 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                         families[i].Children[j].FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(94, " ");
            __builder.AddContent(95, 
#nullable restore
#line 105 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                                            families[i].Children[j].LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                                    ");
            __builder.OpenElement(97, "table");
            __builder.AddAttribute(98, "class", "table");
            __builder.AddMarkupContent(99, "\r\n                                        ");
            __builder.AddMarkupContent(100, @"<thead>
                                        <tr>
                                            <th>HairColor</th>
                                            <th>EyeColor</th>
                                            <th>Age</th>
                                            <th>Weight</th>
                                            <th>Height</th>
                                            <th>Sex</th>
                                        </tr>
                                        </thead>
                                        ");
            __builder.OpenElement(101, "tbody");
            __builder.AddMarkupContent(102, "\r\n                                        ");
            __builder.OpenElement(103, "tr");
            __builder.AddMarkupContent(104, "\r\n                                            ");
            __builder.OpenElement(105, "td");
            __builder.AddContent(106, 
#nullable restore
#line 119 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                 families[i].Children[j].HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                                            ");
            __builder.OpenElement(108, "td");
            __builder.AddContent(109, 
#nullable restore
#line 120 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                 families[i].Children[j].EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                                            ");
            __builder.OpenElement(111, "td");
            __builder.AddContent(112, 
#nullable restore
#line 121 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                 families[i].Children[j].Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                                            ");
            __builder.OpenElement(114, "td");
            __builder.AddContent(115, 
#nullable restore
#line 122 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                 families[i].Children[j].Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                                            ");
            __builder.OpenElement(117, "td");
            __builder.AddContent(118, 
#nullable restore
#line 123 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                 families[i].Children[j].Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                                            ");
            __builder.OpenElement(120, "td");
            __builder.AddContent(121, 
#nullable restore
#line 124 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                 families[i].Children[j].Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n                                    ");
            __builder.AddMarkupContent(126, "<h5>\r\n                                        <b>Interests</b>\r\n                                    </h5>\r\n");
#nullable restore
#line 131 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                    if (families[i].Children[j].ChildInterests.Count == 0)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(127, "                                        ");
            __builder.AddMarkupContent(128, "<p>\r\n                                            <b>None</b>\r\n                                        </p>\r\n");
#nullable restore
#line 136 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                    }
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                     for (int k = 0; k < families[i].Children[j].ChildInterests.Count; k++)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(129, "                                        ");
            __builder.OpenElement(130, "h6");
            __builder.AddContent(131, 
#nullable restore
#line 139 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                             families[i].Children[j].ChildInterests[k].InterestId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n");
#nullable restore
#line 140 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(133, "                                    ");
            __builder.AddMarkupContent(134, "<h5>\r\n                                        <b>Pets</b>\r\n                                    </h5>\r\n");
#nullable restore
#line 144 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                    if (families[i].Children[j].Pets.Count == 0)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(135, "                                        ");
            __builder.AddMarkupContent(136, "<p>\r\n                                            <b>None</b>\r\n                                        </p>\r\n");
#nullable restore
#line 149 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                    }
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 150 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                     for (int d = 0; d < families[i].Children[j].Pets.Count; d++)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(137, "                                        ");
            __builder.OpenElement(138, "table");
            __builder.AddAttribute(139, "class", "table");
            __builder.AddMarkupContent(140, "\r\n                                            ");
            __builder.AddMarkupContent(141, @"<thead>
                                            <tr>
                                                <th>Species</th>
                                                <th>Name</th>
                                                <th>Age</th>
                                            </tr>
                                            </thead>
                                            ");
            __builder.OpenElement(142, "tbody");
            __builder.AddMarkupContent(143, "\r\n                                            ");
            __builder.OpenElement(144, "tr");
            __builder.AddMarkupContent(145, "\r\n                                                ");
            __builder.OpenElement(146, "td");
            __builder.AddContent(147, 
#nullable restore
#line 162 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                     families[i].Children[j].Pets[d].Species

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n                                                ");
            __builder.OpenElement(149, "td");
            __builder.AddContent(150, 
#nullable restore
#line 163 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                     families[i].Children[j].Pets[d].Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n                                                ");
            __builder.OpenElement(152, "td");
            __builder.AddContent(153, 
#nullable restore
#line 164 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                     families[i].Children[j].Pets[d].Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n");
#nullable restore
#line 168 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 168 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                     
                                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(158, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n                            ");
            __builder.OpenElement(160, "button");
            __builder.AddAttribute(161, "class", "accordion");
            __builder.AddAttribute(162, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 172 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                                  e => FlipPets(copy)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(163, "Family Pets");
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n                            ");
            __builder.OpenElement(165, "div");
            __builder.AddAttribute(166, "class", "panel");
            __builder.AddAttribute(167, "style", 
#nullable restore
#line 173 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                        familyPetsAcc[copy] ? "display: block;" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(168, "\r\n");
#nullable restore
#line 174 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                 if (families[i].Pets.Count == 0)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(169, "                                    ");
            __builder.AddMarkupContent(170, "<p><b>None</b></p>\r\n");
#nullable restore
#line 177 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 178 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                 for (int b = 0; b < families[i].Pets.Count; b++)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(171, "                                    ");
            __builder.OpenElement(172, "table");
            __builder.AddAttribute(173, "class", "table");
            __builder.AddMarkupContent(174, "\r\n                                        ");
            __builder.AddMarkupContent(175, @"<thead>
                                        <tr>
                                            <th>Species</th>
                                            <th>Name</th>
                                            <th>Age</th>
                                        </tr>
                                        </thead>
                                        ");
            __builder.OpenElement(176, "tbody");
            __builder.AddMarkupContent(177, "\r\n                                        ");
            __builder.OpenElement(178, "tr");
            __builder.AddMarkupContent(179, "\r\n                                            ");
            __builder.OpenElement(180, "td");
            __builder.AddContent(181, 
#nullable restore
#line 190 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                 families[i].Pets[b].Species

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n                                            ");
            __builder.OpenElement(183, "td");
            __builder.AddContent(184, 
#nullable restore
#line 191 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                 families[i].Pets[b].Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(185, "\r\n                                            ");
            __builder.OpenElement(186, "td");
            __builder.AddContent(187, 
#nullable restore
#line 192 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                                 families[i].Pets[b].Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(188, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(189, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(190, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(191, "\r\n");
#nullable restore
#line 196 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(192, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(193, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(194, "\r\n                    \r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(195, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(196, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(197, "\r\n");
#nullable restore
#line 203 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(198, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(199, "\r\n\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(200, "\r\n");
#nullable restore
#line 208 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 211 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\ShowFamilies.razor"
       

    List<bool> familiesAcc = new List<bool>
    {
        new bool(),
    };

    List<bool> adultsAcc = new List<bool>
    {
        new bool(),
    };

    List<bool> ChildrenAcc = new List<bool>
    {
        new bool(),
    };

    List<bool> familyPetsAcc = new List<bool>
    {
        new bool(),
    };

    IList<Family> families;

    private void Flip(int i)
    {
        familiesAcc[i] = !familiesAcc[i];
    }

    protected override Task OnInitializedAsync()
    {
        families = File.getAllFamilies();
        foreach (var item in families)
        {
            familiesAcc.Add(new bool());
            adultsAcc.Add(new bool());
            ChildrenAcc.Add(new bool());
            familyPetsAcc.Add(new bool());
        }
        return base.OnInitializedAsync();
    }

    private void FlipAdults(int a)
    {
        adultsAcc[a] = !adultsAcc[a];
    }

    private void FlipChildren(int a)
    {
        ChildrenAcc[a] = !ChildrenAcc[a];
    }

    private void FlipPets(int a)
    {
        familyPetsAcc[a] = !familyPetsAcc[a];
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IfileContext File { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
