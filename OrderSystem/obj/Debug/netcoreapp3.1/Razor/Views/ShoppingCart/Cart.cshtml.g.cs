#pragma checksum "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\ShoppingCart\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a19d970d6d889d6979378d16dca8531be4b75f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Cart), @"mvc.1.0.view", @"/Views/ShoppingCart/Cart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a19d970d6d889d6979378d16dca8531be4b75f7", @"/Views/ShoppingCart/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89b067b8a0633520b98dd4572220918bfff3c014", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderSystem.Database.Models.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>Избрани артикули</h3>\r\n<div>\r\n    ");
#nullable restore
#line 5 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\ShoppingCart\Cart.cshtml"
Write(Html.Label("Номер на поръчката: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 6 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\ShoppingCart\Cart.cshtml"
Write(Html.Label(Model.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 8 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\ShoppingCart\Cart.cshtml"
 if (Model.OrderDetails != null)
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\ShoppingCart\Cart.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\ShoppingCart\Cart.cshtml"
   Write(Html.HiddenFor(m => m.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-striped table-hover"" style=""width:75%"">
            <thead style=""width:100%;"">
                <tr class=""d-flex text-light"" style=""background-color:cadetblue"">
                    <th class=""col-3"">
                        Име
                    </th>
                    <th class=""col-2"">
                        Цена
                    </th>
                    <th class=""col-2"">
                        Количество
                    </th>
                    <th class=""col-2"">
                        Марка
                    </th>
                    <th class=""col-2"">
                        Модел
                    </th>
                    <th class=""col-1"">
                    </th>
                </tr>
            </thead>
            <tbody style=""width:100%; overflow-x:hidden;"">
");
#nullable restore
#line 37 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\ShoppingCart\Cart.cshtml"
                 for (int i = 0; i < Model.OrderDetails.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"d-flex\">\r\n                        <td class=\"col-3 column-break-word\">\r\n                            ");
#nullable restore
#line 41 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\ShoppingCart\Cart.cshtml"
                       Write(Model.OrderDetails[i].Part.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"col-2 column-break-word\">\r\n                            ");
#nullable restore
#line 44 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\ShoppingCart\Cart.cshtml"
                       Write(Model.OrderDetails[i].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </td>
                        <td class=""col-2 column-break-word"">
                            <input class=""form-control""
                                   style=""width:120px;height:30px;""
                                   id=""Quantity""
                                   name=""Quantity""");
            BeginWriteAttribute("value", "\r\n                                   value=\"", 1862, "\"", 1937, 1);
#nullable restore
#line 51 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\ShoppingCart\Cart.cshtml"
WriteAttributeValue("", 1906, Model.OrderDetails[i].Quantity, 1906, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                   type=\"text\"\r\n                                   placeholder=\"количество\" />\r\n                        </td>\r\n\r\n                        <td class=\"col-2\">\r\n                            ");
#nullable restore
#line 57 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\ShoppingCart\Cart.cshtml"
                       Write(Model.OrderDetails[i].Part.BrandDetail.Brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"col-2\">\r\n                            Двигател: ");
#nullable restore
#line 60 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\ShoppingCart\Cart.cshtml"
                                 Write(Model.OrderDetails[i].Part.BrandDetail.EngineType);

#line default
#line hidden
#nullable disable
            WriteLiteral(", к.с. ");
#nullable restore
#line 60 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\ShoppingCart\Cart.cshtml"
                                                                                          Write(Model.OrderDetails[i].Part.BrandDetail.Power);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"col-1\">\r\n                            <button id=\"gosho\" type=\"button\" class=\"delete btn btn-outline-danger btn-sm docs-table-body-delete-btn\" data-id=\"");
#nullable restore
#line 63 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\ShoppingCart\Cart.cshtml"
                                                                                                                                         Write(Model.OrderDetails[i].Part.PartId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">✕</button>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 66 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\ShoppingCart\Cart.cshtml"
                    //  @Html.Hidden("PartId", "", new { id = Model.OrderDetails[i].Part.PartId })
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            WriteLiteral("        <div>\r\n            <div>\r\n                <input class=\"col-3\" type=\"submit\" value=\"Завърши поръчката\" />\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 76 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\ShoppingCart\Cart.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\ShoppingCart\Cart.cshtml"
     
}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Нямате избрани артикули</h3>\r\n    <h4>Моля, изберете стоки за поръчката от меню \"Артикули\".</h4>\r\n");
#nullable restore
#line 83 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\ShoppingCart\Cart.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<style>\r\n    .column-break-word {\r\n        word-break: break-all;\r\n    }\r\n\r\n    .docs-table-body-delete-btn {\r\n        width: 30px;\r\n        height: 30px;\r\n    }\r\n</style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderSystem.Database.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
