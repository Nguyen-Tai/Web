#pragma checksum "C:\Users\TNT\Desktop\Web\Shop2\Areas\Admin\Views\SanPham\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b639bf68d9988b39e4234160011b9f88d9350e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SanPham_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SanPham/Index.cshtml")]
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
#line 1 "C:\Users\TNT\Desktop\Web\Shop2\Areas\Admin\Views\_ViewImports.cshtml"
using Shop2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TNT\Desktop\Web\Shop2\Areas\Admin\Views\_ViewImports.cshtml"
using Shop2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b639bf68d9988b39e4234160011b9f88d9350e1", @"/Areas/Admin/Views/SanPham/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45cf22541518bd89ca65e97342d3a04590ec193c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SanPham_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SanPham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\TNT\Desktop\Web\Shop2\Areas\Admin\Views\SanPham\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">List sản phẩm</h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b639bf68d9988b39e4234160011b9f88d9350e14588", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp; New San Pham");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n<div>\r\n    <table class=\"table table-striped border>\r\n        <tr class=\"table-info\">\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\TNT\Desktop\Web\Shop2\Areas\Admin\Views\SanPham\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.TenSanPham));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\TNT\Desktop\Web\Shop2\Areas\Admin\Views\SanPham\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.MotaSP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\TNT\Desktop\Web\Shop2\Areas\Admin\Views\SanPham\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Gia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\TNT\Desktop\Web\Shop2\Areas\Admin\Views\SanPham\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\TNT\Desktop\Web\Shop2\Areas\Admin\Views\SanPham\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.TacGia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\TNT\Desktop\Web\Shop2\Areas\Admin\Views\SanPham\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.NXB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\TNT\Desktop\Web\Shop2\Areas\Admin\Views\SanPham\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.NgonNgu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\TNT\Desktop\Web\Shop2\Areas\Admin\Views\SanPham\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.NgayThem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n            <th></th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 44 "C:\Users\TNT\Desktop\Web\Shop2\Areas\Admin\Views\SanPham\Index.cshtml"
         if (Model != null)
        {
            foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "C:\Users\TNT\Desktop\Web\Shop2\Areas\Admin\Views\SanPham\Index.cshtml"
                   Write(Html.DisplayFor(m => item.TenSanPham));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "C:\Users\TNT\Desktop\Web\Shop2\Areas\Admin\Views\SanPham\Index.cshtml"
                   Write(Html.DisplayFor(m => item.MotaSP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "C:\Users\TNT\Desktop\Web\Shop2\Areas\Admin\Views\SanPham\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Gia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 59 "C:\Users\TNT\Desktop\Web\Shop2\Areas\Admin\Views\SanPham\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "C:\Users\TNT\Desktop\Web\Shop2\Areas\Admin\Views\SanPham\Index.cshtml"
                   Write(Html.DisplayFor(m => item.TacGia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "C:\Users\TNT\Desktop\Web\Shop2\Areas\Admin\Views\SanPham\Index.cshtml"
                   Write(Html.DisplayFor(m => item.NXB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 68 "C:\Users\TNT\Desktop\Web\Shop2\Areas\Admin\Views\SanPham\Index.cshtml"
                   Write(Html.DisplayFor(m => item.NgonNgu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 71 "C:\Users\TNT\Desktop\Web\Shop2\Areas\Admin\Views\SanPham\Index.cshtml"
                   Write(Html.DisplayFor(m => item.NgayThem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4b639bf68d9988b39e4234160011b9f88d9350e111397", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 74 "C:\Users\TNT\Desktop\Web\Shop2\Areas\Admin\Views\SanPham\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.SanPhamId;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 77 "C:\Users\TNT\Desktop\Web\Shop2\Areas\Admin\Views\SanPham\Index.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SanPham>> Html { get; private set; }
    }
}
#pragma warning restore 1591