#pragma checksum "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef5f12568c209d5d7e52c268c8ae7df9d87f249c"
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
#line 2 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Statistics")]
    public partial class Statistics : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Age </h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-lg-8 control-section");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "control-section");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenComponent<Syncfusion.Blazor.Charts.SfAccumulationChart>(10);
            __builder.AddAttribute(11, "Title", "Mobile Browser Statistics");
            __builder.AddAttribute(12, "EnableAnimation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                                                     false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartEvents>(15);
                __builder2.AddAttribute(16, "Load", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Charts.IAccLoadedEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Charts.IAccLoadedEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                           BeforeRender

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartTooltipSettings>(18);
                __builder2.AddAttribute(19, "Enable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n                ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartLegendSettings>(21);
                __builder2.AddAttribute(22, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                          false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n                ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartSeriesCollection>(24);
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(26, "\r\n                    ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartSeries>(27);
                    __builder3.AddAttribute(28, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 20 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                          dataSource

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "XName", "xValue");
                    __builder3.AddAttribute(30, "YName", "yValue");
                    __builder3.AddAttribute(31, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                                                                             OuterRadius

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "StartAngle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 20 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                                                                                                       StartAngle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "EndAngle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 20 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                                                                                                                              EndAngle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "InnerRadius", "0%");
                    __builder3.AddAttribute(35, "ExplodeIndex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 21 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                                             ExplodeIndex

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "Explode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                                                                    true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "ExplodeOffset", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                                                                                          ExplodeRadius

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(39, "\r\n                        ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Charts.AccumulationDataLabelSettings>(40);
                        __builder4.AddAttribute(41, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                                true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(42, "Name", "xValue");
                        __builder4.AddAttribute(43, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.AccumulationLabelPosition>(
#nullable restore
#line 22 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                                                              AccumulationLabelPosition.Outside

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(44, "\r\n                    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "col-lg-4 property-section");
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.OpenElement(53, "table");
            __builder.AddAttribute(54, "title", "Properties");
            __builder.AddAttribute(55, "style", "width: 100%");
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.AddMarkupContent(57, "<tr style=\"height:50px\"><th>Properties</th></tr>\r\n            ");
            __builder.OpenElement(58, "tr");
            __builder.AddAttribute(59, "style", "height: 50px");
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.AddMarkupContent(61, "<td style=\"width: 50%\">\r\n                    <div>\r\n                        Pie Angle:\r\n                    </div>\r\n                </td>\r\n                ");
            __builder.OpenElement(62, "td");
            __builder.AddAttribute(63, "style", "width: 70%;");
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.OpenElement(65, "div");
            __builder.AddMarkupContent(66, "\r\n                        ");
            __builder.OpenElement(67, "input");
            __builder.AddAttribute(68, "type", "range");
            __builder.AddAttribute(69, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                       changeAngle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "value", 
#nullable restore
#line 39 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                                            value

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(71, "min", "0");
            __builder.AddAttribute(72, "max", "360");
            __builder.AddAttribute(73, "style", "width:90%");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                ");
            __builder.OpenElement(77, "td");
            __builder.AddAttribute(78, "style", "width: 30%");
            __builder.AddMarkupContent(79, "\r\n                    ");
            __builder.OpenElement(80, "p");
            __builder.AddAttribute(81, "style", "font-weight: normal;");
            __builder.OpenElement(82, "span");
            __builder.AddContent(83, 
#nullable restore
#line 43 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                            value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n            ");
            __builder.OpenElement(87, "tr");
            __builder.AddAttribute(88, "style", "height: 50px");
            __builder.AddMarkupContent(89, "\r\n                ");
            __builder.AddMarkupContent(90, "<td style=\"width: 50%\">\r\n                    <div>\r\n                        Outer Radius:\r\n                    </div>\r\n                </td>\r\n                ");
            __builder.OpenElement(91, "td");
            __builder.AddAttribute(92, "style", "width: 50%;");
            __builder.AddMarkupContent(93, "\r\n                    ");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "data-role", "rangeslider");
            __builder.AddMarkupContent(96, "\r\n                        ");
            __builder.OpenElement(97, "input");
            __builder.AddAttribute(98, "type", "range");
            __builder.AddAttribute(99, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                       ChangeOuterRadius

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(100, "value", 
#nullable restore
#line 54 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                                                  radiusValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(101, "min", "0");
            __builder.AddAttribute(102, "max", "80");
            __builder.AddAttribute(103, "style", "width:90%");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                ");
            __builder.OpenElement(107, "td");
            __builder.AddAttribute(108, "style", "width: 30%");
            __builder.AddMarkupContent(109, "\r\n                    ");
            __builder.OpenElement(110, "p");
            __builder.AddAttribute(111, "style", "font-weight: normal;");
            __builder.OpenElement(112, "span");
            __builder.AddContent(113, 
#nullable restore
#line 58 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                            radiusValue

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n            ");
            __builder.OpenElement(117, "tr");
            __builder.AddAttribute(118, "style", "height: 50px");
            __builder.AddMarkupContent(119, "\r\n                ");
            __builder.AddMarkupContent(120, "<td style=\"width: 50%\">\r\n                    <div>\r\n                        Explode Radius:\r\n                    </div>\r\n                </td>\r\n                ");
            __builder.OpenElement(121, "td");
            __builder.AddAttribute(122, "style", "width: 50%;");
            __builder.AddMarkupContent(123, "\r\n                    ");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "data-role", "rangeslider");
            __builder.AddMarkupContent(126, "\r\n                        ");
            __builder.OpenElement(127, "input");
            __builder.AddAttribute(128, "type", "range");
            __builder.AddAttribute(129, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                       ChangeExplodeRadius

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(130, "value", 
#nullable restore
#line 69 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                                                    exploderadius

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(131, "min", "0");
            __builder.AddAttribute(132, "max", "40");
            __builder.AddAttribute(133, "style", "width:90%");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                ");
            __builder.OpenElement(137, "td");
            __builder.AddAttribute(138, "style", "width: 30%");
            __builder.AddMarkupContent(139, "\r\n                    ");
            __builder.OpenElement(140, "p");
            __builder.AddAttribute(141, "style", "font-weight: normal;");
            __builder.OpenElement(142, "span");
            __builder.AddContent(143, 
#nullable restore
#line 73 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                           exploderadius

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n            ");
            __builder.OpenElement(147, "tr");
            __builder.AddAttribute(148, "style", "height: 50px");
            __builder.AddMarkupContent(149, "\r\n                ");
            __builder.AddMarkupContent(150, "<td style=\"width: 50%\">\r\n                    <div>\r\n                        Explode Index:\r\n                    </div>\r\n                </td>\r\n                ");
            __builder.OpenElement(151, "td");
            __builder.AddAttribute(152, "style", "width: 50%;");
            __builder.AddMarkupContent(153, "\r\n                    ");
            __builder.OpenElement(154, "div");
            __builder.AddAttribute(155, "data-role", "rangeslider");
            __builder.AddMarkupContent(156, "\r\n                        ");
            __builder.OpenElement(157, "input");
            __builder.AddAttribute(158, "type", "range");
            __builder.AddAttribute(159, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 84 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                       ChangeExplodeIndex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(160, "value", 
#nullable restore
#line 84 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                                                   ExplodeIndex

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(161, "min", "0");
            __builder.AddAttribute(162, "max", "6");
            __builder.AddAttribute(163, "style", "width:90%");
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n                ");
            __builder.OpenElement(167, "td");
            __builder.AddAttribute(168, "style", "width: 30%");
            __builder.AddMarkupContent(169, "\r\n                    ");
            __builder.OpenElement(170, "p");
            __builder.AddAttribute(171, "style", "font-weight: normal;");
            __builder.OpenElement(172, "span");
            __builder.AddContent(173, 
#nullable restore
#line 88 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
                                                            ExplodeIndex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(177, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "C:\Users\sjunn\RiderProjects\TroelsTimer2\Assignment1\Forsøg2\Pages\Statistics.razor"
      

    public int StartAngle = 0, value = 0, EndAngle = 360, radiusValue = 70, exploderadius = 10;
    public double ExplodeIndex = 1;
    private IList<Adult> Adults;
    private static List<double> data;
    public string OuterRadius = "70%", ExplodeRadius = "10%";
    private void changeAngle(Microsoft.AspNetCore.Components.ChangeEventArgs args)
    {
        value = Convert.ToInt32(args.Value);
        StartAngle = +Convert.ToInt32(args.Value);
        EndAngle = +Convert.ToInt32(args.Value);
    }
    private void ChangeOuterRadius(Microsoft.AspNetCore.Components.ChangeEventArgs args)
    {
        radiusValue = Convert.ToInt32(args.Value);
        OuterRadius = args.Value + "%";
    }
    private void ChangeExplodeRadius(Microsoft.AspNetCore.Components.ChangeEventArgs args)
    {
        exploderadius = Convert.ToInt32(args.Value);
        ExplodeRadius = args.Value + "%";
    }
    private void ChangeExplodeIndex(Microsoft.AspNetCore.Components.ChangeEventArgs args)
    {
        ExplodeIndex = Convert.ToInt32(args.Value);
    }

    protected override async void OnInitialized()
    {
        base.OnInitialized();
        //Adults = await File.getAllAdults();
        data = FillDataSOurce();
        dataSource = new List<PieData1>
        {
            new PieData1 { xValue = "Younger than 20", yValue = data[0], r="Test"},
            new PieData1 { xValue = "20-30",    yValue = data[1], r="test2"},
            new PieData1 { xValue = "30-40",  yValue = data[2]},
            new PieData1 { xValue = "40-50", yValue = data[3]},
            new PieData1 { xValue = "50-60", yValue = data[4]},
            new PieData1 { xValue = "Older than 60", yValue = data[5]}
        };
    }
    
    public class PieData1
    {
        public string xValue { get; set; }
        public double yValue { get; set; }
        public string r { get; set; }
    }

    public List<double> FillDataSOurce()
    {
     
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        int e = 0;
        int f = 0;
        for (int i = 0; i < Adults.Count; i++)
        {
            if (Adults[i].Age < 20)
                a++;
            else if (Adults[i].Age >= 20 && Adults[i].Age <= 30)
                b++;
            else if (Adults[i].Age >= 30 && Adults[i].Age <= 40)
                c++;
            else if (Adults[i].Age >= 40 && Adults[i].Age <= 50)
                d++;
            else if (Adults[i].Age >= 50 && Adults[i].Age <= 60)
                e++;
            else
                f++;
        }
        List<double> data = new List<double>
        {
            a,
            b,
            c,
            d,
            e,
            f
        };
        return data;
    }

    private List<PieData1> dataSource;


    string CurrentUri;
    void BeforeRender(IAccLoadedEventArgs Args)
    {
        
        CurrentUri = NavigationManager.Uri;
        if (CurrentUri.IndexOf("material") > -1)
        {
            Args.Theme = AccumulationTheme.Material;
        }
        else if (CurrentUri.IndexOf("fabric") > -1)
        {
            Args.Theme = AccumulationTheme.Fabric;
        }
        else if (CurrentUri.IndexOf("bootstrap") > -1)
        {
            Args.Theme = AccumulationTheme.Bootstrap;
        }
        else if (CurrentUri.IndexOf("highcontrast") > -1)
        {
            Args.Theme = AccumulationTheme.HighContrast;
        }
        else
        {
            Args.Theme = AccumulationTheme.Bootstrap4;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IfileContext File { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
