#pragma checksum "C:\Users\Onur Furkan Meral\Desktop\PusulaPlus\PusulaPlus\Views\Shared\_yesproduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "881230a9f94be567d373ed77832cf51b924f7df5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__yesproduct), @"mvc.1.0.view", @"/Views/Shared/_yesproduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"881230a9f94be567d373ed77832cf51b924f7df5", @"/Views/Shared/_yesproduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"683fa08695f37bb87d56dd2b9e7c3457b5710e9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__yesproduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x\" crossorigin=\"anonymous\">\r\n");
#nullable restore
#line 9 "C:\Users\Onur Furkan Meral\Desktop\PusulaPlus\PusulaPlus\Views\Shared\_yesproduct.cshtml"
         foreach (var iter in Model.products)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""card col-md-3"">
                <div class=""card-body"">

                    <img style=""height:200px;width:150px"" class=""card-img-top"" src=""https://media.istockphoto.com/vectors/smart-phone-realistic-mobile-phone-smartphone-with-blank-screen-on-vector-id834343646"" />

                    <h5 class=""card-title"">");
#nullable restore
#line 17 "C:\Users\Onur Furkan Meral\Desktop\PusulaPlus\PusulaPlus\Views\Shared\_yesproduct.cshtml"
                                      Write(iter.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 18 "C:\Users\Onur Furkan Meral\Desktop\PusulaPlus\PusulaPlus\Views\Shared\_yesproduct.cshtml"
                                    Write(iter.image);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 875, "\"", 892, 2);
            WriteAttributeValue("", 882, "/", 882, 1, true);
#nullable restore
#line 19 "C:\Users\Onur Furkan Meral\Desktop\PusulaPlus\PusulaPlus\Views\Shared\_yesproduct.cshtml"
WriteAttributeValue("", 883, iter.Url, 883, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary\">İncele</a>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 22 "C:\Users\Onur Furkan Meral\Desktop\PusulaPlus\PusulaPlus\Views\Shared\_yesproduct.cshtml"

        }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591