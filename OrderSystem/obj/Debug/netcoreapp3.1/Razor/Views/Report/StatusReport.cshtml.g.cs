#pragma checksum "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Report\StatusReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b69eb9de0f34d31ae729f6ccae8c9803e7713a1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_StatusReport), @"mvc.1.0.view", @"/Views/Report/StatusReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b69eb9de0f34d31ae729f6ccae8c9803e7713a1c", @"/Views/Report/StatusReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89b067b8a0633520b98dd4572220918bfff3c014", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_StatusReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderSystem.ViewModels.StatusReportViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>Справка по статус на поръчката</h3>\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Report\StatusReport.cshtml"
 using (Html.BeginForm("StatusesReport", "Report", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 9 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Report\StatusReport.cshtml"
   Write(Html.Label("Статус: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 10 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Report\StatusReport.cshtml"
   Write(Html.DropDownListFor(m => m.Status.StatusId, new SelectList(new OrderSystem.Services.Services.StatusDatabaseService().GetStatuss(), "StatusId", "Name"), "Избери", htmlAttributes: new { @class = "custom-class-for-width", @style = "min-width: 15%;max-width: 15%;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <input type=\"submit\" value=\"Филтрирай\" />\r\n    </div>\r\n");
#nullable restore
#line 13 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Report\StatusReport.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-striped table-hover"" style=""width:75%"">
    <thead style=""width:100%;"">
        <tr class=""d-flex text-light"" style=""background-color:cadetblue"">
            <th class=""col-1"">
                Номер
            </th>
            <th class=""col-2"">
                Цена
            </th>
            <th class=""col-2"">
                Дата
            </th>
            <th class=""col-2"">
                Статус
            </th>
            <th class=""col-2"">
                Адрес
            </th>
            <th class=""col-3"">
                Потребител
            </th>
        </tr>
    </thead>
    <tbody style=""width:100%; overflow-x:hidden;"">
");
#nullable restore
#line 39 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Report\StatusReport.cshtml"
         foreach (var item in Model.Orders)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"d-flex\">\r\n            <td class=\"col-1 column-break-word\">\r\n                ");
#nullable restore
#line 43 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Report\StatusReport.cshtml"
           Write(item.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"col-2 column-break-word\">\r\n                ");
#nullable restore
#line 46 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Report\StatusReport.cshtml"
           Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"col-2 column-break-word\">\r\n                ");
#nullable restore
#line 49 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Report\StatusReport.cshtml"
           Write(item.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"col-2 column-break-word\">\r\n                ");
#nullable restore
#line 52 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Report\StatusReport.cshtml"
           Write(item.Status.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"col-2 column-break-word\">\r\n                ");
#nullable restore
#line 55 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Report\StatusReport.cshtml"
           Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"col-3 column-break-word\">\r\n                ");
#nullable restore
#line 58 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Report\StatusReport.cshtml"
           Write(item.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 61 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Report\StatusReport.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n<style>\r\n    .column-break-word {\r\n        word-break: break-all;\r\n    }\r\n\r\n    .docs-table-body-delete-btn {\r\n        width: 30px;\r\n        height: 30px;\r\n    }\r\n</style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderSystem.ViewModels.StatusReportViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591