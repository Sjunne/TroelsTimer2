#pragma checksum "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily4.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "600d2f057dd28edb1d5e931169169394b44cab8d"
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
#line 2 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily4.razor"
using ModelsAddFamily;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily4.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily4.razor"
using FileData;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddFamily4")]
    public partial class AddFamily4 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Family pets</h3>\r\n");
            __builder.AddMarkupContent(1, "<h6>step 4/4</h6>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily4.razor"
                  pet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily4.razor"
                                       AddAnotherPet

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
                __builder2.AddMarkupContent(13, "\r\n        Age:<br>\r\n        ");
                __Blazor.Forsøg2.Pages.AddFamily.AddFamily4.TypeInference.CreateInputNumber_0(__builder2, 14, 15, 
#nullable restore
#line 16 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily4.razor"
                                  pet.Age

#line default
#line hidden
#nullable disable
                , 16, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pet.Age = __value, pet.Age)), 17, () => pet.Age);
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "\r\n        Name:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "rows", "4");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily4.razor"
                                         pet.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pet.Name = __value, pet.Name))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => pet.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n    ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "\r\n        Species:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(33);
                __builder2.AddAttribute(34, "rows", "4");
                __builder2.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily4.razor"
                                         pet.Species

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pet.Species = __value, pet.Species))));
                __builder2.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => pet.Species));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n\r\n    ");
                __builder2.AddMarkupContent(40, "<button class=\"btn btn-outline-dark\" type=\"submit\">Add</button>\r\n    ");
                __builder2.AddMarkupContent(41, "<p style=\"font-size: 70%;\">\r\n        <i>Can add multiple</i>\r\n    </p>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.OpenElement(43, "p");
            __builder.AddAttribute(44, "class", "actions");
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "style", "float: right; background-color: limegreen");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily4.razor"
                                                                        NextPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "class", "btn btn-outline-dark");
            __builder.AddContent(50, "Next");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily4.razor"
       
    private Pet pet = new Pet();


    private void AddAnotherPet()
    {
        AddFamilyHolder.family.Pets.Add(pet);
        pet = new Pet();
    }

    private void NextPage()
    {
        AddFamilyHolder.family.Pets.Add(pet);
        pet = new Pet();
        File.AddFamily(AddFamilyHolder.family);
        NavigationManager.NavigateTo("/ShowFamilies");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IfileContext File { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AddFamilyHolder AddFamilyHolder { get; set; }
    }
}
namespace __Blazor.Forsøg2.Pages.AddFamily.AddFamily4
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
