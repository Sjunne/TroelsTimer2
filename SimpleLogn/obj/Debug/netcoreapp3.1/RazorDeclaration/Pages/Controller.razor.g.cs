#pragma checksum "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\SimpleLogn\Pages\Controller.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25b1bfed0df7b5158ffad66cc1aaaa3fc4639da7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SimpleLogn.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\SimpleLogn\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\SimpleLogn\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\SimpleLogn\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\SimpleLogn\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\SimpleLogn\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\SimpleLogn\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\SimpleLogn\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\SimpleLogn\_Imports.razor"
using SimpleLogn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\SimpleLogn\_Imports.razor"
using SimpleLogn.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\SimpleLogn\Pages\Controller.razor"
using SimpleLogn.ViewModels;

#line default
#line hidden
#nullable disable
    public partial class Controller : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\SimpleLogn\Pages\Controller.razor"
       
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
