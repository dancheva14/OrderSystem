#pragma checksum "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Orders\OrdersList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47c22559b44bc2d2169d34e6407ef8b1952334f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_OrdersList), @"mvc.1.0.view", @"/Views/Orders/OrdersList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47c22559b44bc2d2169d34e6407ef8b1952334f5", @"/Views/Orders/OrdersList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89b067b8a0633520b98dd4572220918bfff3c014", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_OrdersList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OrderSystem.Database.Models.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Orders\OrdersList.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Няма намерена поръчка с този номер.</h4>\r\n");
#nullable restore
#line 7 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Orders\OrdersList.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <h3>Поръчки </h3>
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
");
#nullable restore
#line 23 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Orders\OrdersList.cshtml"
                 if (User != null && User.Identity.IsAuthenticated && User.IsInRole("Admin"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th class=\"col-3\">\r\n                        Партньор\r\n                    </th>\r\n");
#nullable restore
#line 28 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Orders\OrdersList.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th class=\"col-3\">\r\n                        Адрес\r\n                    </th>\r\n");
#nullable restore
#line 34 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Orders\OrdersList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th class=\"col-3\">\r\n                    Статус\r\n                </th>\r\n                <th class=\"col-1\">\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody style=\"width:100%; overflow-x:hidden;\">\r\n");
#nullable restore
#line 43 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Orders\OrdersList.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"d-flex\">\r\n                    <td class=\"col-1 column-break-word\">\r\n                        ");
#nullable restore
#line 47 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Orders\OrdersList.cshtml"
                   Write(item.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"col-2 column-break-word\">\r\n                        ");
#nullable restore
#line 50 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Orders\OrdersList.cshtml"
                   Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"col-2 column-break-word\">\r\n                        ");
#nullable restore
#line 53 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Orders\OrdersList.cshtml"
                   Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 55 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Orders\OrdersList.cshtml"
                     if (User != null && User.Identity.IsAuthenticated && User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"col-2 column-break-word\">\r\n                            ");
#nullable restore
#line 58 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Orders\OrdersList.cshtml"
                       Write(item.Partner.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 60 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Orders\OrdersList.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"col-2 column-break-word\">\r\n                            ");
#nullable restore
#line 64 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Orders\OrdersList.cshtml"
                       Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 66 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Orders\OrdersList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"col-3 column-break-word\">\r\n                        ");
#nullable restore
#line 68 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Orders\OrdersList.cshtml"
                   Write(item.Status.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 70 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Orders\OrdersList.cshtml"
                     if (User != null && User.Identity.IsAuthenticated && User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"col-1\">\r\n                            ");
#nullable restore
#line 73 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Orders\OrdersList.cshtml"
                       Write(Html.ActionLink("Редактирай", "EditOrder", "Orders", new { id = item.OrderId }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 75 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Orders\OrdersList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 77 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Orders\OrdersList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 80 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Orders\OrdersList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .column-break-word {\r\n        word-break: break-all;\r\n    }\r\n\r\n    .docs-table-body-delete-btn {\r\n        width: 30px;\r\n        height: 30px;\r\n    }\r\n</style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OrderSystem.Database.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
