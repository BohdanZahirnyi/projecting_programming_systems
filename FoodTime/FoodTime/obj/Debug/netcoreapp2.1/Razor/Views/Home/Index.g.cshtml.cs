#pragma checksum "D:\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79f3a2b724603181f0e724b4df7559b59f0e075e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79f3a2b724603181f0e724b4df7559b59f0e075e", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 29, true);
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(74, 1177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "315a1a955a29450485cf5f95e6b39534", async() => {
                BeginContext(80, 1164, true);
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>
    <link rel=""stylesheet"" href=""main.css"">
    <meta charset=""UTF-8"">

    <style>
        img {
            width: 100%;
            height: auto;
        }

        .container {
         ");
                WriteLiteral("   padding-top: 3%;\r\n            padding-bottom: 3%;\r\n        }\r\n\r\n        label {\r\n            font-size: 1.4em;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1251, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1253, 3853, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc899204898a4f4eb7ef31f652b86c95", async() => {
                BeginContext(1259, 3840, true);
                WriteLiteral(@"
    <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
        <a class=""navbar-brand"" href=""#"">Navbar</a>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>

        <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
            <ul class=""navbar-nav mr-auto"">
                <li class=""nav-item active"">
                    <a class=""nav-link"" href=""#"">Home <span class=""sr-only"">(current)</span></a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">Link</a>
                </li>
                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false");
                WriteLiteral(@""">
                        Dropdown
                    </a>
                    <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                        <a class=""dropdown-item"" href=""#"">Action</a>
                        <a class=""dropdown-item"" href=""#"">Another action</a>
                        <div class=""dropdown-divider""></div>
                        <a class=""dropdown-item"" href=""#"">Something else here</a>
                    </div>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link disabled"" href=""#"">Disabled</a>
                </li>
            </ul>
            <form class=""form-inline my-2 my-lg-0"">
                <input class=""form-control mr-sm-2"" type=""search"" placeholder=""Search"" aria-label=""Search"">
                <button class=""btn btn-outline-success my-2 my-sm-0"" type=""submit"">Search</button>
            </form>
        </div>
    </nav>

    <div class=""container"">
        <div class=""row"">
            ");
                WriteLiteral(@"<div class=""col-3"">
                <img src=""maxresdefault.jpg"">
                <h4>Caterpillar soup</h4>
                <div class=""row"">
                    <div class=""col-6""><label>6 $</label></div>
                    <div class=""col-6""><button type=""button"" class=""btn btn-success "" style=""display: flex; justify-content: center;"">Add to Cart</button></div>
                </div>
            </div>

            <div class=""col-3"">
                <img src=""cheese.jpg"">
                <h4>Casu marzu</h4>
                <div class=""row"">
                    <div class=""col-6""><label>9.5 $</label></div>
                    <div class=""col-6""><button type=""button"" class=""btn btn-success "" style=""display: flex; justify-content: center;"">Add to Cart</button></div>
                </div>
            </div>

            <div class=""col-3"">
                <img src=""D:\projecting_programming_systems\FoodTime\FoodTime\wwwroot\images\scorpioni.jpg"">
                <h4>Fried scorpions</h4>
");
                WriteLiteral(@"                <div class=""row"">
                    <div class=""col-6""><label>3 $</label></div>
                    <div class=""col-6""><button type=""button"" class=""btn btn-success "" style=""display: flex; justify-content: center;"">Add to Cart</button></div>
                </div>
            </div>

            <div class=""col-3"">
                <img src=""galushky.jpg"">
                <h4>Galushky</h4>
                <div class=""row"">
                    <div class=""col-6""><label>100 $</label></div>
                    <div class=""col-6""><button type=""button"" class=""btn btn-success "" style=""display: flex; justify-content: center;"">Add to Cart</button></div>
                </div>
            </div>
        </div>
        <hr>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5106, 59, true);
            WriteLiteral("\r\n</html>\r\n<div>\r\n    <h1>It\'s Okay, Baby!</h1>\r\n</div>\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5165, "\"", 5204, 1);
#line 114 "D:\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
WriteAttributeValue("", 5172, Url.Action("FoodDetail","Food"), 5172, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5205, 36, true);
            WriteLiteral(" class=\"elements\">FoodDetail</a>\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5241, "\"", 5280, 1);
#line 115 "D:\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
WriteAttributeValue("", 5248, Url.Action("SignIn","Entrance"), 5248, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5281, 35, true);
            WriteLiteral(" class=\"elements\">Sign In</a>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
