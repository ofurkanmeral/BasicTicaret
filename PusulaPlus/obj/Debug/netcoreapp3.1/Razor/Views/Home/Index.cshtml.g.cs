#pragma checksum "C:\Users\Onur Furkan Meral\Desktop\PusulaPlus\PusulaPlus\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d668d09f58b6963fd14232453b957ee40d12f6fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d668d09f58b6963fd14232453b957ee40d12f6fe", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"683fa08695f37bb87d56dd2b9e7c3457b5710e9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("d");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("        <link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x\" crossorigin=\"anonymous\">\r\n        <p> ");
#nullable restore
#line 10 "C:\Users\Onur Furkan Meral\Desktop\PusulaPlus\PusulaPlus\Views\Home\Index.cshtml"
       Write(ViewBag.action);

#line default
#line hidden
#nullable disable
            WriteLiteral(";</p>\r\n        <p> ");
#nullable restore
#line 11 "C:\Users\Onur Furkan Meral\Desktop\PusulaPlus\PusulaPlus\Views\Home\Index.cshtml"
       Write(ViewBag.controller);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 12 "C:\Users\Onur Furkan Meral\Desktop\PusulaPlus\PusulaPlus\Views\Home\Index.cshtml"
         if (Model.products.Count == 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Onur Furkan Meral\Desktop\PusulaPlus\PusulaPlus\Views\Home\Index.cshtml"
       Write(await Html.PartialAsync("_noproduct"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Onur Furkan Meral\Desktop\PusulaPlus\PusulaPlus\Views\Home\Index.cshtml"
                                                  ;
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\" style=\"background-color:lightblue\">\r\n    <div class=\"col-md-3 \">\r\n        ");
#nullable restore
#line 20 "C:\Users\Onur Furkan Meral\Desktop\PusulaPlus\PusulaPlus\Views\Home\Index.cshtml"
   Write(await Html.PartialAsync("_category", Model.categories));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n\r\n        ");
#nullable restore
#line 24 "C:\Users\Onur Furkan Meral\Desktop\PusulaPlus\PusulaPlus\Views\Home\Index.cshtml"
   Write(await Html.PartialAsync("_yesproduct"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    </div>\r\n\r\n\r\n</div>\r\n");
#nullable restore
#line 29 "C:\Users\Onur Furkan Meral\Desktop\PusulaPlus\PusulaPlus\Views\Home\Index.cshtml"
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
