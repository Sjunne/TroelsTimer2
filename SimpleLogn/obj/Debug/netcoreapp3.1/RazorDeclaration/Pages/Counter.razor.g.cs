#pragma checksum "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\SimpleLogn\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21c9896989af61684c83b84c35541269e701d94e"
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
#line 2 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\SimpleLogn\Pages\Counter.razor"
           [Authorize(Policy = "MustBeTeacher")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\SimpleLogn\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
