#pragma checksum "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\AdvancedTodo\Pages\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16ba46f8e816d9c131033278b71e4fee8e98f371"
// <auto-generated/>
#pragma warning disable 1591
namespace AdvancedTodo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\AdvancedTodo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\AdvancedTodo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\AdvancedTodo\_Imports.razor"
using AdvancedTodo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\AdvancedTodo\_Imports.razor"
using AdvancedTodo.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Profile")]
    public partial class Profile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<head>\r\n    <style>\r\n        body {\r\n        background-color: #1b1e21;\r\n        }\r\n    </style>\r\n</head>\r\n");
            __builder.AddMarkupContent(1, @"<div style=""width: 100%; height: 400px; background: rgb(2,0,36);
                                                                              background: linear-gradient(90deg, rgba(2,0,36,1) 0%, rgba(9,9,121,1) 35%, rgba(0,212,255,1) 100%);"">
    <div id=""example1"" class=""cover-div"" style=""height: 220px; position: relative"">
        <button class=""btn btn-primary"" style=""position: absolute; bottom: 3px; right: 3px"">Change cover</button>
        <div id=""example2""></div>
        <button style=""position: absolute; bottom: 3px; right: 40%; height: 30px; width: 40px; border-radius: 8px;"">
            <img src=""images/camera.png"" style=""height: 100%; width: 100%;"">
        </button>
    </div>


    <div id=""top"">
        <h2 class=""Georgia"">Maria Frandsen</h2>

    </div>
</div>

");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", "width: 75%; margin: auto; background-color: white;");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "RadzenTabs");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "Tabs");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "RadzenTabsItem");
            __builder.AddAttribute(10, "Text", "About");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<div style=\"height: 300px\">\r\n                    <div style=\"float:left; width: 40%; height: 250px; border-style: solid; margin-left: 7%; overflow: scroll;\">\r\n                        <div>\r\n                            <h5 class=\"Georgia\" style=\"float: left\">About Maria</h5>\r\n                            <button class=\"btn btn-primary Georgia\" style=\"float: right\">Edit</button>\r\n                        </div>\r\n                        <div style=\"float: left\">\r\n                            <p class=\"Georgia\">Age: </p>\r\n                            <p class=\"Georgia\">Interests: </p>\r\n                            <p class=\"Georgia\">Ideal date: </p>\r\n                            <p class=\"Georgia\">Instagram: </p>\r\n                            <p class=\"Georgia\">Spotify: </p>\r\n                        </div>\r\n\r\n                    </div>\r\n                    <div style=\" overflow: scroll; float:right; width: 40%; height: 250px; border-style: solid; margin-right: 7%; margin-bottom: 50px;\">\r\n                        <div>\r\n                            <h5 class=\"Georgia\" style=\"float: left\">Introduction </h5>\r\n                            <button class=\"btn btn-primary Georgia\" style=\"float: right\">Edit</button>\r\n                        </div>\r\n                        <p class=\"Georgia\" style=\"float: left\">\r\n                            Tekst bliver i daglig tale tit identificeret med det medie, de fremstår i, og som sådan\r\n                            er begrebet en meget flertydig størrelse.\r\n\r\n                            En tekst er her f.eks. en bog, et brev eller en avis.\r\n                            Den kan også være en del af en større tekst, f.eks. en\r\n                            nærmere afgrænset del af bogen (i forskellige\r\n                            former for antologier og samlinger) et bestemt afsnit\r\n                            i brevet (eller f.eks. et bilag til brevet) eller\r\n                            en enkelt artikel i avisen.\r\n\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "RadzenTabsItem");
            __builder.AddAttribute(15, "Text", "Images");
            __builder.AddMarkupContent(16, "\r\n                <div style=\"height: 300px\"></div>\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "RadzenTabsItem");
            __builder.AddAttribute(19, "Text", "Reviews");
            __builder.AddMarkupContent(20, "\r\n                <div style=\"height: 300px\"></div>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
