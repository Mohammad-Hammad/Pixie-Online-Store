#pragma checksum "C:\Users\moham\source\repos\WebApplication11\WebApplication11\Views\Homepageview\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c1559aa27b4bd949ec5e598d3643cb633183419"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Homepageview_Products), @"mvc.1.0.view", @"/Views/Homepageview/Products.cshtml")]
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
#nullable restore
#line 1 "C:\Users\moham\source\repos\WebApplication11\WebApplication11\Views\_ViewImports.cshtml"
using WebApplication11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\moham\source\repos\WebApplication11\WebApplication11\Views\_ViewImports.cshtml"
using WebApplication11.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c1559aa27b4bd949ec5e598d3643cb633183419", @"/Views/Homepageview/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40d4615a478f022e670e186c1fe0812b887af102", @"/Views/_ViewImports.cshtml")]
    public class Views_Homepageview_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication11.Models.Productpage>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("30px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("350px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "C:\Users\moham\source\repos\WebApplication11\WebApplication11\Views\Homepageview\Products.cshtml"
  
    ViewData["Title"] = "Products";
    Layout = "~/Views/Shared/homepagelayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Page Content -->
  <!-- Items Starts Here -->
  <div class=""featured-page"">
    <div class=""container"">
      <div class=""row"">
        <div class=""col-md-4 col-sm-12"">
          <div class=""section-heading"">
            <div class=""line-dec""></div>
            <h1>Featured Items</h1>
          </div>
        </div>
        <div class=""col-md-8 col-sm-12"">
          <div id=""filters"" class=""button-group"">
            <button class=""btn btn-primary"" data-filter=""*"">All Products</button>
            <button class=""btn btn-primary"" data-filter="".new"">Newest</button>
            <button class=""btn btn-primary"" data-filter="".low"">Low Price</button>
            <button class=""btn btn-primary"" data-filter="".high"">Hight Price</button>
          </div>
        </div>
      </div>
    </div>
  </div>

  <div class=""featured container no-gutter"">

    <div class=""row posts"">
");
#nullable restore
#line 34 "C:\Users\moham\source\repos\WebApplication11\WebApplication11\Views\Homepageview\Products.cshtml"
       foreach(var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"item new col-md-4\">\r\n        <a href=\"single-product.html\">\r\n          <div class=\"featured-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7c1559aa27b4bd949ec5e598d3643cb6331834195869", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1274, "~/productpageimages/", 1274, 20, true);
#nullable restore
#line 40 "C:\Users\moham\source\repos\WebApplication11\WebApplication11\Views\Homepageview\Products.cshtml"
AddHtmlAttributeValue("", 1294, item.Imagename, 1294, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <h4>");
#nullable restore
#line 42 "C:\Users\moham\source\repos\WebApplication11\WebApplication11\Views\Homepageview\Products.cshtml"
           Write(item.Productname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <h6>");
#nullable restore
#line 43 "C:\Users\moham\source\repos\WebApplication11\WebApplication11\Views\Homepageview\Products.cshtml"
           Write(item.Productprice);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</h6>\r\n          </div>\r\n        </a>\r\n      </div>\r\n");
#nullable restore
#line 47 "C:\Users\moham\source\repos\WebApplication11\WebApplication11\Views\Homepageview\Products.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
  </div>

  <div class=""page-navigation"">
    <div class=""container"">
      <div class=""row"">
        <div class=""col-md-12"">
          <ul>
            <li class=""current-page""><a href=""#"">1</a></li>
            <li><a href=""#"">2</a></li>
            <li><a href=""#"">3</a></li>
            <li><a href=""#""><i class=""fa fa-angle-right""></i></a></li>
          </ul>
        </div>
      </div>
    </div>
  </div>
  <!-- Featred Page Ends Here -->

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication11.Models.Productpage>> Html { get; private set; }
    }
}
#pragma warning restore 1591