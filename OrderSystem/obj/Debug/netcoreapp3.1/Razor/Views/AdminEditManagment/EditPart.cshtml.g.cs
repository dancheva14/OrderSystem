#pragma checksum "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\EditPart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6affbd48934ac41a9bb677faf5d775f782671ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminEditManagment_EditPart), @"mvc.1.0.view", @"/Views/AdminEditManagment/EditPart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6affbd48934ac41a9bb677faf5d775f782671ae", @"/Views/AdminEditManagment/EditPart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89b067b8a0633520b98dd4572220918bfff3c014", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminEditManagment_EditPart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderSystem.Database.Models.Part>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\EditPart.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <fieldset>\r\n        <legend>Редактирай част</legend>\r\n        <div style=\"top: 50%; width: 100%\">\r\n            ");
#nullable restore
#line 8 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\EditPart.cshtml"
       Write(Html.HiddenFor(m => m.PartId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div style=\"width: 500px;\">\r\n\r\n\r\n                <div>\r\n                    ");
#nullable restore
#line 13 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\EditPart.cshtml"
               Write(Html.Label("Марка: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 14 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\EditPart.cshtml"
               Write(Html.DropDownListFor(m => m.BrandDetail.BrandId, new SelectList(new OrderSystem.Services.Services.BrandsDatabaseService().GetBrands(), "BrandId", "Name"), "Избери", htmlAttributes: new { @class = "custom-class-for-width form-control", @id = "ddlstate", @onchange = "javascript:GetCity(this.value);" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n                <br />\r\n                <div>\r\n                    ");
#nullable restore
#line 19 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\EditPart.cshtml"
               Write(Html.Label("Модел: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <select id=\"ddlcity\" name=\"ddlcity\" class=\"form-control\">\r\n                    </select>\r\n                </div>\r\n                <br />\r\n                <div>\r\n                    ");
#nullable restore
#line 25 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\EditPart.cshtml"
               Write(Html.Label("Категория: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 26 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\EditPart.cshtml"
               Write(Html.DropDownListFor(m => m.CategoryId, new SelectList(new OrderSystem.Services.Services.CategoryDatabaseService().GetCategorys(), "CategoryId", "Name"), "Избери", htmlAttributes: new { @class = "custom-class-for-width form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n                <br />\r\n                <div class=\"editor-label\">");
#nullable restore
#line 30 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\EditPart.cshtml"
                                     Write(Html.LabelFor(s => s.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"editor-field\">\r\n\r\n                    ");
#nullable restore
#line 33 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\EditPart.cshtml"
               Write(Html.TextBoxFor(m => m.Name, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 34 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\EditPart.cshtml"
               Write(Html.ValidationMessageFor(s => s.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <br />\r\n                <div class=\"editor-label\">");
#nullable restore
#line 37 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\EditPart.cshtml"
                                     Write(Html.LabelFor(s => s.Pricee));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"editor-field\">\r\n\r\n                    ");
#nullable restore
#line 40 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\EditPart.cshtml"
               Write(Html.TextBoxFor(m => m.Pricee, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 41 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\EditPart.cshtml"
               Write(Html.ValidationMessageFor(s => s.Pricee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <br />\r\n                <div>\r\n                    <input class=\"col-12\" type=\"submit\" value=Запази />\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </fieldset>\r\n");
#nullable restore
#line 50 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\AdminEditManagment\EditPart.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    fieldset {
        margin: 20px;
        border: 1px solid silver;
        padding: 8px;
        border-radius: 4px;
        width: 550px;
    }

    legend {
        padding: 2px;
    }
</style>

<script language=""javascript"" type=""text/javascript"">
    function GetCity(_stateId) {
        var procemessage = ""<option value='0'> Please wait...</option>"";
        $(""#ddlcity"").html(procemessage).show();
        var url = ""/AdminManagment/GetBrandDetailsByBrandId/"";

        $.ajax({
            url: url,
            data: { stateid: _stateId },
            cache: false,
            type: ""POST"",
            success: function (data) {
                var markup = ""<option value='0'>Избери модел</option>"";
                for (var x = 0; x < data.length; x++) {
                    markup += ""<option value="" + data[x].value + "">"" + data[x].text + ""</option>"";

                    debugger;
                }
                $(""#ddlcity"").html(markup).show();
           ");
            WriteLiteral(" },\r\n            error: function (reponse) {\r\n                alert(\"error : \" + reponse);\r\n            }\r\n        });\r\n\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderSystem.Database.Models.Part> Html { get; private set; }
    }
}
#pragma warning restore 1591
