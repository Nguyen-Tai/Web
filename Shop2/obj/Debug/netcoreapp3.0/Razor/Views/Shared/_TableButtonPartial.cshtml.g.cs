#pragma checksum "C:\Users\TNT\Desktop\Web\Shop2\Views\Shared\_TableButtonPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbadd3273e9a3fb9190dceda049e8c77dc4779cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TableButtonPartial), @"mvc.1.0.view", @"/Views/Shared/_TableButtonPartial.cshtml")]
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
#line 1 "C:\Users\TNT\Desktop\Web\Shop2\Views\_ViewImports.cshtml"
using Shop2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TNT\Desktop\Web\Shop2\Views\_ViewImports.cshtml"
using Shop2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbadd3273e9a3fb9190dceda049e8c77dc4779cf", @"/Views/Shared/_TableButtonPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45cf22541518bd89ca65e97342d3a04590ec193c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TableButtonPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<td style=\"width:150px\">\r\n    <div class=\"btn-group\" role=\"group\">\r\n        <a type=\"button\" class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 250, "\"", 302, 1);
#nullable restore
#line 7 "C:\Users\TNT\Desktop\Web\Shop2\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 257, Url.Action("Edit/"+Model).Replace("%2F","/"), 257, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <i class=\"fas fa-edit\"></i>\r\n        </a>\r\n        <a type=\"button\" class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 409, "\"", 464, 1);
#nullable restore
#line 10 "C:\Users\TNT\Desktop\Web\Shop2\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 416, Url.Action("Details/"+Model).Replace("%2F","/"), 416, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <i class=\"far fa-list-alt\"></i>\r\n        </a>\r\n        <a type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 574, "\"", 628, 1);
#nullable restore
#line 13 "C:\Users\TNT\Desktop\Web\Shop2\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 581, Url.Action("Delete/"+Model).Replace("%2F","/"), 581, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <i class=\"fas fa-trash-alt\"></i>\r\n        </a>\r\n\r\n    </div>\r\n</td>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
