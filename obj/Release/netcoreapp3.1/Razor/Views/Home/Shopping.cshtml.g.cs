#pragma checksum "C:\Users\丶scholar丶\source\repos\catering\Views\Home\Shopping.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a00df89d897057c285c20c6d038bedc2d10c2693"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Shopping), @"mvc.1.0.view", @"/Views/Home/Shopping.cshtml")]
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
#line 1 "C:\Users\丶scholar丶\source\repos\catering\Views\_ViewImports.cshtml"
using catering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\丶scholar丶\source\repos\catering\Views\_ViewImports.cshtml"
using catering.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a00df89d897057c285c20c6d038bedc2d10c2693", @"/Views/Home/Shopping.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9d46641ac4fe4cb9c2d5072a5b2953dc2d8517b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Shopping : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\丶scholar丶\source\repos\catering\Views\Home\Shopping.cshtml"
  
    var count = Model == null ? 0 : Model.Count();

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>购物车</h1>\r\n<span>");
#nullable restore
#line 9 "C:\Users\丶scholar丶\source\repos\catering\Views\Home\Shopping.cshtml"
 Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
<div class=""row"">
    <div class=""col-md-6"">
        <table class=""table table-bordered table-hover table-striped table-condensed"">
            <thead>
                <tr>标题</tr>
                <tr>简介</tr>
            </thead>
            <tbody>
");
#nullable restore
#line 18 "C:\Users\丶scholar丶\source\repos\catering\Views\Home\Shopping.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 21 "C:\Users\丶scholar丶\source\repos\catering\Views\Home\Shopping.cshtml"
                       Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 22 "C:\Users\丶scholar丶\source\repos\catering\Views\Home\Shopping.cshtml"
                       Write(item.intro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 23 "C:\Users\丶scholar丶\source\repos\catering\Views\Home\Shopping.cshtml"
                       Write(item.newPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 25 "C:\Users\丶scholar丶\source\repos\catering\Views\Home\Shopping.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
