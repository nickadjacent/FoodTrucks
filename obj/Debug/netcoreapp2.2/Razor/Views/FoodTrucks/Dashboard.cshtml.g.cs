#pragma checksum "/Users/cthulhu/Documents/Dojo/C#/ORM/FoodTrucks/Views/FoodTrucks/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2534f1a8730303a291f9b3cb2170cdef1cb46ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FoodTrucks_Dashboard), @"mvc.1.0.view", @"/Views/FoodTrucks/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FoodTrucks/Dashboard.cshtml", typeof(AspNetCore.Views_FoodTrucks_Dashboard))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/cthulhu/Documents/Dojo/C#/ORM/FoodTrucks/Views/_ViewImports.cshtml"
using FoodTrucks;

#line default
#line hidden
#line 2 "/Users/cthulhu/Documents/Dojo/C#/ORM/FoodTrucks/Views/_ViewImports.cshtml"
using FoodTrucks.Models;

#line default
#line hidden
#line 6 "/Users/cthulhu/Documents/Dojo/C#/ORM/FoodTrucks/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2534f1a8730303a291f9b3cb2170cdef1cb46ff", @"/Views/FoodTrucks/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16c470aaec9320b48830a1d468fb1ed5416c2cff", @"/Views/_ViewImports.cshtml")]
    public class Views_FoodTrucks_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FoodTruck>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DashboardLinks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_RatingStars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FoodTrucks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/cthulhu/Documents/Dojo/C#/ORM/FoodTrucks/Views/FoodTrucks/Dashboard.cshtml"
  
    int? loggedInUserId = Context.Session.GetInt32("UserId");

#line default
#line hidden
            BeginContext(91, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(92, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f2534f1a8730303a291f9b3cb2170cdef1cb46ff5947", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(124, 41, true);
            WriteLiteral("</partial>\n\n<div class=\"container mt-5\">\n");
            EndContext();
#line 10 "/Users/cthulhu/Documents/Dojo/C#/ORM/FoodTrucks/Views/FoodTrucks/Dashboard.cshtml"
     foreach (FoodTruck truck in Model)
    {
        double avgRating = truck.CalculateAverageRating();


#line default
#line hidden
            BeginContext(271, 288, true);
            WriteLiteral(@"        <div class=""row bg-light border mt-2 mb-2 p-3"">
            <div class=""col-md-3"">
                <img src=""https://image.flaticon.com/icons/png/512/45/45880.png"" alt=""Delivery Truck"" style=""width: 50%;"">
            </div>
            <div class=""col-md-6"">
                <h3>");
            EndContext();
            BeginContext(560, 10, false);
#line 19 "/Users/cthulhu/Documents/Dojo/C#/ORM/FoodTrucks/Views/FoodTrucks/Dashboard.cshtml"
               Write(truck.Name);

#line default
#line hidden
            EndContext();
            BeginContext(570, 32, true);
            WriteLiteral("</h3>\n                <p>Style: ");
            EndContext();
            BeginContext(603, 11, false);
#line 20 "/Users/cthulhu/Documents/Dojo/C#/ORM/FoodTrucks/Views/FoodTrucks/Dashboard.cshtml"
                     Write(truck.Style);

#line default
#line hidden
            EndContext();
            BeginContext(614, 61, true);
            WriteLiteral("</p>\n                <p>\n                    Average Rating: ");
            EndContext();
            BeginContext(676, 9, false);
#line 22 "/Users/cthulhu/Documents/Dojo/C#/ORM/FoodTrucks/Views/FoodTrucks/Dashboard.cshtml"
                               Write(avgRating);

#line default
#line hidden
            EndContext();
            BeginContext(685, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(706, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f2534f1a8730303a291f9b3cb2170cdef1cb46ff8951", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 23 "/Users/cthulhu/Documents/Dojo/C#/ORM/FoodTrucks/Views/FoodTrucks/Dashboard.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = avgRating;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(754, 97, true);
            WriteLiteral("</partial>\n                </p>\n            </div>\n            <div class=\"col-md-3 text-right\">\n");
            EndContext();
#line 28 "/Users/cthulhu/Documents/Dojo/C#/ORM/FoodTrucks/Views/FoodTrucks/Dashboard.cshtml"
                 if (loggedInUserId == truck.UserId)
                {

#line default
#line hidden
            BeginContext(1063, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1083, 287, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2534f1a8730303a291f9b3cb2170cdef1cb46ff11012", async() => {
                BeginContext(1316, 50, true);
                WriteLiteral("\n                        edit\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-foodTruckId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "/Users/cthulhu/Documents/Dojo/C#/ORM/FoodTrucks/Views/FoodTrucks/Dashboard.cshtml"
                                   WriteLiteral(truck.FoodTruckId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["foodTruckId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-foodTruckId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["foodTruckId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1370, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 38 "/Users/cthulhu/Documents/Dojo/C#/ORM/FoodTrucks/Views/FoodTrucks/Dashboard.cshtml"
                }

#line default
#line hidden
            BeginContext(1389, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(1406, 264, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2534f1a8730303a291f9b3cb2170cdef1cb46ff13937", async() => {
                BeginContext(1622, 44, true);
                WriteLiteral("\n                    review\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-foodTruckId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "/Users/cthulhu/Documents/Dojo/C#/ORM/FoodTrucks/Views/FoodTrucks/Dashboard.cshtml"
                               WriteLiteral(truck.FoodTruckId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["foodTruckId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-foodTruckId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["foodTruckId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1670, 35, true);
            WriteLiteral("\n            </div>\n        </div>\n");
            EndContext();
#line 50 "/Users/cthulhu/Documents/Dojo/C#/ORM/FoodTrucks/Views/FoodTrucks/Dashboard.cshtml"
    }

#line default
#line hidden
            BeginContext(1711, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FoodTruck>> Html { get; private set; }
    }
}
#pragma warning restore 1591
