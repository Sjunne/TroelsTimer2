#pragma checksum "C:\Users\sjunn\RiderProjects\TroelsTimer2\SimpleLogn\Pages\Controller.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25b1bfed0df7b5158ffad66cc1aaaa3fc4639da7"
// <auto-generated/>
#pragma warning disable 1591
namespace SimpleLogn.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sjunn\RiderProjects\TroelsTimer2\SimpleLogn\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sjunn\RiderProjects\TroelsTimer2\SimpleLogn\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sjunn\RiderProjects\TroelsTimer2\SimpleLogn\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sjunn\RiderProjects\TroelsTimer2\SimpleLogn\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sjunn\RiderProjects\TroelsTimer2\SimpleLogn\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sjunn\RiderProjects\TroelsTimer2\SimpleLogn\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sjunn\RiderProjects\TroelsTimer2\SimpleLogn\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sjunn\RiderProjects\TroelsTimer2\SimpleLogn\_Imports.razor"
using SimpleLogn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sjunn\RiderProjects\TroelsTimer2\SimpleLogn\_Imports.razor"
using SimpleLogn.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\sjunn\RiderProjects\TroelsTimer2\SimpleLogn\Pages\Controller.razor"
using SimpleLogn.ViewModels;

#line default
#line hidden
#nullable disable
    public partial class Controller : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Controller</h3>\r\n");
            __builder.AddMarkupContent(1, "<h1>Det her er Controlleren</h1>\r\n\r\n");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\sjunn\RiderProjects\TroelsTimer2\SimpleLogn\Pages\Controller.razor"
                                          viewmodel.Metode1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "metode1");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "btn btn-primary");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\sjunn\RiderProjects\TroelsTimer2\SimpleLogn\Pages\Controller.razor"
                                          viewmodel.Metode2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "metode2");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\sjunn\RiderProjects\TroelsTimer2\SimpleLogn\Pages\Controller.razor"
       
    private ViewModel viewmodel;
    
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
    {

        int applesReturn = 0;
        int orangesReturn = 0;

        for (int i = 0; i < apples.Length; i++)
        {
            if (apples[i] + a <= s || apples[i] + a > t)
                applesReturn++;
        }

        for (int i = 0; i < oranges.Length; i++)
        {
            if (oranges[i] + b > t || oranges[i] + b < s)
            {
                orangesReturn++;
            }
        }

        Console.WriteLine(applesReturn);
        Console.WriteLine(orangesReturn);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
