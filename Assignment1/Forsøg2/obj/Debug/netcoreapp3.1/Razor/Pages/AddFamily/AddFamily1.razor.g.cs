#pragma checksum "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db415f71e21bd67f2f2fd5a6a91110377402825f"
// <auto-generated/>
#pragma warning disable 1591
namespace Forsøg2.Pages.AddFamily
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
#line 2 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily1.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily1.razor"
using ModelsAddFamily;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily1.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily1.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily1.razor"
           [Authorize(Policy = "SecurityLevel4")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddFamily")]
    public partial class AddFamily1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Add Family</h1>\r\n");
            __builder.AddMarkupContent(1, "<h6>Step 1/4</h6>\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily1.razor"
                  family

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily1.razor"
                                          SubmitPage1

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, "\r\n        House Number:<br>\r\n        ");
                __Blazor.Forsøg2.Pages.AddFamily.AddFamily1.TypeInference.CreateInputNumber_0(__builder2, 14, 15, 
#nullable restore
#line 18 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily1.razor"
                                  family.HouseNumber

#line default
#line hidden
#nullable disable
                , 16, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => family.HouseNumber = __value, family.HouseNumber)), 17, () => family.HouseNumber);
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "\r\n        Street Name:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "rows", "4");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily1.razor"
                                         family.StreetName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => family.StreetName = __value, family.StreetName))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => family.StreetName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n    ");
                __builder2.AddMarkupContent(30, "<p class=\"actions\">\r\n        <button class=\"btn btn-outline-dark\" style=\"float: right; background-color: limegreen\" type=\"submit\">Next</button>\r\n    </p>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily1.razor"
       
    private Family family;
    
    protected override Task OnInitializedAsync()
    {
        family = AddFamilyHolder.family;
        return base.OnInitializedAsync();
    }

    private void SubmitPage1()
    {
        AddFamilyHolder.family.StreetName = family.StreetName;
        NavigationManager.NavigateTo("/AddFamily2");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AddFamilyHolder AddFamilyHolder { get; set; }
    }
}
namespace __Blazor.Forsøg2.Pages.AddFamily.AddFamily1
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
