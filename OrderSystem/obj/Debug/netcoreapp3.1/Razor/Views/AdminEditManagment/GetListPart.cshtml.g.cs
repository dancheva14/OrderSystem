#pragma checksum "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\GetListPart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3bf7a06c805fa70b64b316daf558a2e5eac66f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminEditManagment_GetListPart), @"mvc.1.0.view", @"/Views/AdminEditManagment/GetListPart.cshtml")]
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
#line 1 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\_ViewImports.cshtml"
using OrderSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\_ViewImports.cshtml"
using OrderSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3bf7a06c805fa70b64b316daf558a2e5eac66f7", @"/Views/AdminEditManagment/GetListPart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89b067b8a0633520b98dd4572220918bfff3c014", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminEditManagment_GetListPart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OrderSystem.Database.Models.Part>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n<h2>Части</h2>\r\n<div class=\"courses-list\">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\GetListPart.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"button_cont\" align=\"center\"><a class=\"example_f\"");
            BeginWriteAttribute("href", " href=\"", 217, "\"", 301, 1);
#nullable restore
#line 11 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\GetListPart.cshtml"
WriteAttributeValue("", 224, Url.Action("EditPart", "AdminEditManagment", new { id = item.PartId }, null), 224, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span>");
#nullable restore
#line 11 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\GetListPart.cshtml"
                                                                                                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n");
#nullable restore
#line 12 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\GetListPart.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<style>
    example_f {
        border-radius: 4px;
        background: linear-gradient(to right, #67b26b, #4ca2cb) !important;
        border: none;
        color: #FFFFFF;
        text-align: center;
        text-transform: uppercase;
        font-size: 22px;
        padding: 20px;
        width: 200px;
        transition: all 0.4s;
        cursor: pointer;
        margin: 5px;
    }

    .example_f span {
        cursor: pointer;
        display: inline-block;
        position: relative;
        transition: 0.4s;
    }

        .example_f span:after {
            content: '\00bb';
            position: absolute;
            opacity: 0;
            top: 0;
            right: -20px;
            transition: 0.5s;
        }

    .example_f:hover span {
        padding-right: 25px;
    }

        .example_f:hover span:after {
            opacity: 1;
            right: 0;
        }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OrderSystem.Database.Models.Part>> Html { get; private set; }
    }
}
#pragma warning restore 1591
