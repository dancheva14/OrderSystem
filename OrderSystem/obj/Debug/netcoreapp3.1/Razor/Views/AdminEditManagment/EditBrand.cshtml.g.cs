#pragma checksum "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\EditBrand.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc2369c4347ffbeab4d9a450537d848688ac7364"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminEditManagment_EditBrand), @"mvc.1.0.view", @"/Views/AdminEditManagment/EditBrand.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc2369c4347ffbeab4d9a450537d848688ac7364", @"/Views/AdminEditManagment/EditBrand.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89b067b8a0633520b98dd4572220918bfff3c014", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminEditManagment_EditBrand : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderSystem.Database.Models.Brand>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\EditBrand.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <fieldset>\r\n        <legend>Редактирай марка</legend>\r\n        <div style=\"top: 50%; width: 100%\">\r\n            ");
#nullable restore
#line 8 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\EditBrand.cshtml"
       Write(Html.HiddenFor(m => m.BrandId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div style=\"top:50%; width: 500px;\">\r\n                <div class=\"editor-label\">");
#nullable restore
#line 10 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\EditBrand.cshtml"
                                     Write(Html.LabelFor(s => s.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"editor-field\">\r\n                    ");
#nullable restore
#line 12 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\EditBrand.cshtml"
               Write(Html.TextBoxFor(m => m.Name, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <br />\r\n\r\n                <br />\r\n                <div>\r\n                    <input class=\"col-12\" type=\"submit\" value=Запази />\r\n                </div>\r\n                ");
#nullable restore
#line 20 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\EditBrand.cshtml"
           Write(Html.ActionLink("Изтрии", "DeleteBrand", "AdminEditManagment", new { id = Model.BrandId }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </fieldset>\r\n");
#nullable restore
#line 24 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\EditBrand.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    fieldset {\r\n        margin: 20px;\r\n        border: 1px solid silver;\r\n        padding: 8px;\r\n        border-radius: 4px;\r\n        width: 550px;\r\n    }\r\n\r\n    legend {\r\n        padding: 2px;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderSystem.Database.Models.Brand> Html { get; private set; }
    }
}
#pragma warning restore 1591
