#pragma checksum "C:\Users\Onur Furkan Meral\Desktop\PusulaPlus\PusulaPlus\Views\Again\detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c530a915e23a81e56b7657acb1f7800c11a2102"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Again_detail), @"mvc.1.0.view", @"/Views/Again/detail.cshtml")]
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
#line 1 "C:\Users\Onur Furkan Meral\Desktop\PusulaPlus\PusulaPlus\Views\_ViewImports.cshtml"
using Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c530a915e23a81e56b7657acb1f7800c11a2102", @"/Views/Again/detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"683fa08695f37bb87d56dd2b9e7c3457b5710e9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Again_detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x\" crossorigin=\"anonymous\">\r\n");
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            <img class=\"img-fluid\" src=\"https://images-na.ssl-images-amazon.com/images/I/41VEJ7iQ18L._AC_SY1000_.jpg\" />\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n            <h1 class=\"mb-3\">");
#nullable restore
#line 15 "C:\Users\Onur Furkan Meral\Desktop\PusulaPlus\PusulaPlus\Views\Again\detail.cshtml"
                        Write(Model.Product.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1><hr />\r\n           \r\n");
#nullable restore
#line 17 "C:\Users\Onur Furkan Meral\Desktop\PusulaPlus\PusulaPlus\Views\Again\detail.cshtml"
             foreach (var iter in Model.Categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 761, "\"", 787, 2);
            WriteAttributeValue("", 768, "/products/", 768, 10, true);
#nullable restore
#line 19 "C:\Users\Onur Furkan Meral\Desktop\PusulaPlus\PusulaPlus\Views\Again\detail.cshtml"
WriteAttributeValue("", 778, iter.Url, 778, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger p-0 mb-3\">");
#nullable restore
#line 19 "C:\Users\Onur Furkan Meral\Desktop\PusulaPlus\PusulaPlus\Views\Again\detail.cshtml"
                                                                         Write(iter.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 20 "C:\Users\Onur Furkan Meral\Desktop\PusulaPlus\PusulaPlus\Views\Again\detail.cshtml"
               
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"mb-3\">\r\n                <h4 class=\"text-primary mb-3\">\r\n                    ");
#nullable restore
#line 25 "C:\Users\Onur Furkan Meral\Desktop\PusulaPlus\PusulaPlus\Views\Again\detail.cshtml"
               Write(Model.Product.image);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h4>\r\n            </div>\r\n\r\n            <button type=\"submit\" class=\"btn btn-outline-dark\">Add to Card</button>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
