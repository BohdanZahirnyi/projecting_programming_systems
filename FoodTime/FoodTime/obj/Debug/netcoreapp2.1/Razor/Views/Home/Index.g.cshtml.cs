#pragma checksum "E:\studing\PPS\FoodTime\FoodTime\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6408b31fa4f3e4315add46aa3b1fb0e359fd7e96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "E:\studing\PPS\FoodTime\FoodTime\Views\_ViewImports.cshtml"
using FoodTime;

#line default
#line hidden
#line 4 "E:\studing\PPS\FoodTime\FoodTime\Views\Home\Index.cshtml"
using FoodTime.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6408b31fa4f3e4315add46aa3b1fb0e359fd7e96", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ebf4a1dc4f8437f8770ecd4859e528abe6377f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FoodTime.Models.FoodViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/cheese.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/kisspng-shopping-cart-computer-icons-scalable-vector-graph-login-5c5d24d4484df5.0922957315496081482962.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\studing\PPS\FoodTime\FoodTime\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
            BeginContext(115, 102, true);
            WriteLiteral("<link href=\"THE REFERENCE FILE URL\" rel=\"stylesheet\" type=\"text/css\" />\r\n\r\n<div class=\"container\">\r\n\r\n");
            EndContext();
#line 10 "E:\studing\PPS\FoodTime\FoodTime\Views\Home\Index.cshtml"
      
        ViewBag.Title = "Index";
    

#line default
#line hidden
            BeginContext(266, 47, true);
            WriteLiteral("\r\n    <h2>Index</h2>\r\n\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 17 "E:\studing\PPS\FoodTime\FoodTime\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
            BeginContext(364, 114, true);
            WriteLiteral("        <div class=\"col-4\" style=\"font-size:1.3em;\" id=\"dish\">\r\n            <div class=\"col-12\">\r\n                ");
            EndContext();
            BeginContext(478, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d83efab1007474ab97ab9c361604bfc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(511, 65, true);
            WriteLiteral("\r\n                <div class=\"row\"><h3 style=\"font-weight:bold;\">");
            EndContext();
            BeginContext(577, 39, false);
#line 23 "E:\studing\PPS\FoodTime\FoodTime\Views\Home\Index.cshtml"
                                                          Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(616, 49, true);
            WriteLiteral("</h3></div>\r\n                <div class=\"row\"><p>");
            EndContext();
            BeginContext(666, 44, false);
#line 24 "E:\studing\PPS\FoodTime\FoodTime\Views\Home\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Componets));

#line default
#line hidden
            EndContext();
            BeginContext(710, 75, true);
            WriteLiteral("<p></div>\r\n                <div class=\"row\"><p style=\"font-style: italic;\">");
            EndContext();
            BeginContext(786, 44, false);
#line 25 "E:\studing\PPS\FoodTime\FoodTime\Views\Home\Index.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.ExtraInfo));

#line default
#line hidden
            EndContext();
            BeginContext(830, 90, true);
            WriteLiteral("</p></div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-6\"><p> ");
            EndContext();
            BeginContext(921, 42, false);
#line 27 "E:\studing\PPS\FoodTime\FoodTime\Views\Home\Index.cshtml"
                                      Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
            EndContext();
            BeginContext(963, 36, true);
            WriteLiteral(" : <label style=\"color: indianred;\">");
            EndContext();
            BeginContext(1000, 41, false);
#line 27 "E:\studing\PPS\FoodTime\FoodTime\Views\Home\Index.cshtml"
                                                                                                                     Write(Html.DisplayFor(modelItem => item.Weight));

#line default
#line hidden
            EndContext();
            BeginContext(1041, 66, true);
            WriteLiteral(" гр</label></p></div>\r\n                    <div class=\"col-6\"><p> ");
            EndContext();
            BeginContext(1108, 41, false);
#line 28 "E:\studing\PPS\FoodTime\FoodTime\Views\Home\Index.cshtml"
                                      Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1149, 36, true);
            WriteLiteral(" : <label style=\"color: indianred;\">");
            EndContext();
            BeginContext(1186, 40, false);
#line 28 "E:\studing\PPS\FoodTime\FoodTime\Views\Home\Index.cshtml"
                                                                                                                    Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1226, 160, true);
            WriteLiteral(" $</label></p></div>\r\n                </div>\r\n                <a href=\"#\">\r\n                    <div class=\"row\" id=\"add_to_cart_btn\">\r\n                        ");
            EndContext();
            BeginContext(1386, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ca85d4efb9a44a3d88052b83af620ef7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1523, 132, true);
            WriteLiteral("\r\n                        <p>Add to cart</p>\r\n                    </div>\r\n                </a>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 38 "E:\studing\PPS\FoodTime\FoodTime\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1666, 35, true);
            WriteLiteral("\r\n        </div>\r\n\r\n</div>\r\n   \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FoodTime.Models.FoodViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
