#pragma checksum "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b182ac6ffb80dd31b6f9e7f56a0284ad0998bf79"
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
#line 2 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
using Microsoft.AspNetCore.Mvc.ModelBinding;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
using ModelsAddFamily;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddFamily2")]
    public partial class AddFamily2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<head>\r\n    <style>\r\n        .test123\r\n        {\r\n        float: left;\r\n        margin-right: 20px;\r\n        }\r\n    </style>\r\n</head>\r\n");
            __builder.AddMarkupContent(1, "<h1>Add A Child</h1>\r\n");
            __builder.AddMarkupContent(2, "<h6>Step 2/4</h6>\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "height: 700px");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "test123");
            __builder.AddMarkupContent(8, "\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 22 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
                          child

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(15);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.AddMarkupContent(17, "<h6>Child</h6>\r\n            ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.AddMarkupContent(20, "\r\n                User Id:<br>\r\n                ");
                __Blazor.Forsøg2.Pages.AddFamily.AddFamily2.TypeInference.CreateInputNumber_0(__builder2, 21, 22, 
#nullable restore
#line 28 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
                                          child.Id

#line default
#line hidden
#nullable disable
                , 23, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => child.Id = __value, child.Id)), 24, () => child.Id);
                __builder2.AddMarkupContent(25, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, "\r\n                First Name:<br>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "rows", "4");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
                                                 child.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => child.FirstName = __value, child.FirstName))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => child.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.AddMarkupContent(39, "\r\n                Last Name:<br>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(40);
                __builder2.AddAttribute(41, "rows", "4");
                __builder2.AddAttribute(42, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
                                                 child.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => child.LastName = __value, child.LastName))));
                __builder2.AddAttribute(44, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => child.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "form-group");
                __builder2.AddMarkupContent(49, "\r\n                Weight:<br>\r\n                ");
                __Blazor.Forsøg2.Pages.AddFamily.AddFamily2.TypeInference.CreateInputNumber_1(__builder2, 50, 51, "4", 52, 
#nullable restore
#line 40 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
                                                   child.Weight

#line default
#line hidden
#nullable disable
                , 53, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => child.Weight = __value, child.Weight)), 54, () => child.Weight);
                __builder2.AddMarkupContent(55, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n            ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group");
                __builder2.AddMarkupContent(59, "\r\n                HairColor:<br>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(60);
                __builder2.AddAttribute(61, "rows", "4");
                __builder2.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
                                                 child.HairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => child.HairColor = __value, child.HairColor))));
                __builder2.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => child.HairColor));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n            ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "form-group");
                __builder2.AddMarkupContent(69, "\r\n                Eye Color:<br>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(70);
                __builder2.AddAttribute(71, "rows", "4");
                __builder2.AddAttribute(72, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
                                                 child.EyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => child.EyeColor = __value, child.EyeColor))));
                __builder2.AddAttribute(74, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => child.EyeColor));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n            ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-group");
                __builder2.AddMarkupContent(79, "\r\n                Age:<br>\r\n                ");
                __Blazor.Forsøg2.Pages.AddFamily.AddFamily2.TypeInference.CreateInputNumber_2(__builder2, 80, 81, "4", 82, 
#nullable restore
#line 52 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
                                                   child.Age

#line default
#line hidden
#nullable disable
                , 83, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => child.Age = __value, child.Age)), 84, () => child.Age);
                __builder2.AddMarkupContent(85, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n            ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "form-group");
                __builder2.AddMarkupContent(89, "\r\n                Height:<br>\r\n                ");
                __Blazor.Forsøg2.Pages.AddFamily.AddFamily2.TypeInference.CreateInputNumber_3(__builder2, 90, 91, "4", 92, 
#nullable restore
#line 56 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
                                                   child.Height

#line default
#line hidden
#nullable disable
                , 93, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => child.Height = __value, child.Height)), 94, () => child.Height);
                __builder2.AddMarkupContent(95, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n            ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "form-group");
                __builder2.AddMarkupContent(99, "\r\n                Sex:<br>\r\n                ");
                __Blazor.Forsøg2.Pages.AddFamily.AddFamily2.TypeInference.CreateInputSelect_4(__builder2, 100, 101, "4", 102, 
#nullable restore
#line 60 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
                                                   child.Sex

#line default
#line hidden
#nullable disable
                , 103, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => child.Sex = __value, child.Sex)), 104, () => child.Sex, 105, (__builder3) => {
                    __builder3.AddMarkupContent(106, "\r\n                    ");
                    __builder3.AddMarkupContent(107, "<option value>Select sex...</option>\r\n                    ");
                    __builder3.AddMarkupContent(108, "<option value=\"Male\">Male</option>\r\n                    ");
                    __builder3.AddMarkupContent(109, "<option value=\"Female\">Female</option>\r\n                ");
                }
                );
                __builder2.AddMarkupContent(110, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n\r\n\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(112, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n    ");
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "test123");
            __builder.AddMarkupContent(116, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(117);
            __builder.AddAttribute(118, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 71 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
                          pet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(119, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 71 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
                                               AddAnotherPet

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(120, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(121, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(122);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(123, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(124);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(125, "\r\n            ");
                __builder2.AddMarkupContent(126, "<h6>Child pets - Can add multiple</h6>\r\n            ");
                __builder2.OpenElement(127, "div");
                __builder2.AddAttribute(128, "class", "form-group");
                __builder2.AddMarkupContent(129, "\r\n                Age:<br>\r\n                ");
                __Blazor.Forsøg2.Pages.AddFamily.AddFamily2.TypeInference.CreateInputNumber_5(__builder2, 130, 131, 
#nullable restore
#line 77 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
                                          pet.Age

#line default
#line hidden
#nullable disable
                , 132, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pet.Age = __value, pet.Age)), 133, () => pet.Age);
                __builder2.AddMarkupContent(134, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(135, "\r\n            ");
                __builder2.OpenElement(136, "div");
                __builder2.AddAttribute(137, "class", "form-group");
                __builder2.AddMarkupContent(138, "\r\n                Name:<br>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(139);
                __builder2.AddAttribute(140, "rows", "4");
                __builder2.AddAttribute(141, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 81 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
                                                 pet.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(142, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pet.Name = __value, pet.Name))));
                __builder2.AddAttribute(143, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => pet.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(144, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(145, "\r\n            ");
                __builder2.OpenElement(146, "div");
                __builder2.AddAttribute(147, "class", "form-group");
                __builder2.AddMarkupContent(148, "\r\n                Species:<br>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(149);
                __builder2.AddAttribute(150, "rows", "4");
                __builder2.AddAttribute(151, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 85 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
                                                 pet.Species

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(152, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pet.Species = __value, pet.Species))));
                __builder2.AddAttribute(153, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => pet.Species));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(154, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(155, "\r\n\r\n            ");
                __builder2.AddMarkupContent(156, "<button class=\"btn btn-outline-dark\" type=\"submit\">Add</button>\r\n            ");
                __builder2.AddMarkupContent(157, "<p style=\"font-size: 70%;\">\r\n                <i>Can add multiple</i>\r\n            </p>\r\n\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(158, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n    ");
            __builder.OpenElement(160, "div");
            __builder.AddAttribute(161, "class", "test1234");
            __builder.AddMarkupContent(162, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(163);
            __builder.AddAttribute(164, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 96 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
                          childInterest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(165, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 96 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
                                                         AddAnotherInterest

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(166, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(167, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(168);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(169, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(170);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(171, "\r\n            ");
                __builder2.AddMarkupContent(172, "<h6>Interests, can add multiple</h6>\r\n            ");
                __builder2.OpenElement(173, "div");
                __builder2.AddAttribute(174, "class", "form-group");
                __builder2.AddMarkupContent(175, "\r\n                Name:<br>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(176);
                __builder2.AddAttribute(177, "rows", "4");
                __builder2.AddAttribute(178, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 102 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
                                                 childInterest.InterestId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(179, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => childInterest.InterestId = __value, childInterest.InterestId))));
                __builder2.AddAttribute(180, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => childInterest.InterestId));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(181, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(182, "\r\n            ");
                __builder2.AddMarkupContent(183, "<button class=\"btn btn-outline-dark\" type=\"submit\">Add</button>\r\n            ");
                __builder2.AddMarkupContent(184, "<p style=\"font-size: 70%;\">\r\n                <i>Can add multiple</i>\r\n            </p>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(185, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(187, "\r\n\r\n");
            __builder.OpenElement(188, "p");
            __builder.AddAttribute(189, "class", "actions");
            __builder.AddMarkupContent(190, "\r\n    ");
            __builder.OpenElement(191, "button");
            __builder.AddAttribute(192, "style", "float: right; background-color: limegreen");
            __builder.AddAttribute(193, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 113 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
                                                                        NextPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(194, "class", "btn btn-outline-dark");
            __builder.AddContent(195, "Next");
            __builder.CloseElement();
            __builder.AddMarkupContent(196, "\r\n    ");
            __builder.OpenElement(197, "button");
            __builder.AddAttribute(198, "style", "float: right; margin-right: 10px");
            __builder.AddAttribute(199, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 114 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
                                                               AddAnotherChild

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(200, "class", "btn btn-outline-dark");
            __builder.AddContent(201, "Add Another Child");
            __builder.CloseElement();
            __builder.AddMarkupContent(202, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 118 "C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\AddFamily\AddFamily2.razor"
       
    private Child child;
    private Pet pet;
    private ChildInterest childInterest;

    protected override Task OnInitializedAsync()
    {
        child = new Child();
        pet = new Pet();
        childInterest = new ChildInterest();
        return base.OnInitializedAsync();
    }

    private void AddAnotherPet()
    {
        child.Pets.Add(pet);
        pet = new Pet();
    }

    private void AddAnotherInterest()
    {
        child.ChildInterests.Add(childInterest);
        childInterest = new ChildInterest();
    }


    private void AddAnotherChild()
    {
        AddFamilyHolder.family.Children.Add(child);
        child = new Child();
    }

    private void NextPage()
    {
        AddFamilyHolder.family.Children.Add(child);
        NavigationManager.NavigateTo("/AddFamily3");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AddFamilyHolder AddFamilyHolder { get; set; }
    }
}
namespace __Blazor.Forsøg2.Pages.AddFamily.AddFamily2
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
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
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
