#pragma checksum "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\GetListStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1772adc76ab68ffbdea6525163f811b79b627260"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminEditManagment_GetListStatus), @"mvc.1.0.view", @"/Views/AdminEditManagment/GetListStatus.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1772adc76ab68ffbdea6525163f811b79b627260", @"/Views/AdminEditManagment/GetListStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89b067b8a0633520b98dd4572220918bfff3c014", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminEditManagment_GetListStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OrderSystem.Database.Models.Status>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""></script>





    <h2>Статуси</h2>
    <div style="" margin-top: 30px; width:100%; display: grid; grid-template-columns: repeat(auto-fit, minmax(300px, 1fr))"" id=""view"">

");
#nullable restore
#line 14 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\GetListStatus.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\" style=\"margin:10px; max-width:300px;background-color:aliceblue\">\r\n                <div class=\"card-body\" align=\"center\"><a class=\"example_f\"");
            BeginWriteAttribute("href", " href=\"", 844, "\"", 932, 1);
#nullable restore
#line 17 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\GetListStatus.cshtml"
WriteAttributeValue("", 851, Url.Action("EditStatus", "AdminEditManagment", new { id = item.StatusId }, null), 851, 81, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span>");
#nullable restore
#line 17 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\GetListStatus.cshtml"
                                                                                                                                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n            </div>\r\n");
#nullable restore
#line 19 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\GetListStatus.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>

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
     ");
            WriteLiteral("           opacity: 1;\r\n                right: 0;\r\n            }\r\n    </style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OrderSystem.Database.Models.Status>> Html { get; private set; }
    }
}
#pragma warning restore 1591
