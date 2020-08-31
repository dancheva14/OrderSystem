#pragma checksum "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Parts\PartsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c791608396114ca2b018b5947f003003feb4e4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parts_PartsList), @"mvc.1.0.view", @"/Views/Parts/PartsList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c791608396114ca2b018b5947f003003feb4e4e", @"/Views/Parts/PartsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89b067b8a0633520b98dd4572220918bfff3c014", @"/Views/_ViewImports.cshtml")]
    public class Views_Parts_PartsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderSystem.ViewModels.PartsListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h2>Наличност</h2>\r\n\r\n");
#nullable restore
#line 6 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Parts\PartsList.cshtml"
 using (Html.BeginForm("PartsList", "Parts", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 9 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Parts\PartsList.cshtml"
Write(Html.Label("Категория: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 10 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Parts\PartsList.cshtml"
Write(Html.DropDownListFor(m => m.CategoryId, new SelectList(new OrderSystem.Services.Services.CategoryDatabaseService().GetCategorys(), "CategoryId", "Name"), "Избери", htmlAttributes: new { @class = "custom-class-for-width", @style = "min-width: 15%;max-width: 15%;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <input type=\"submit\" value=\"Филтрирай\" />\r\n</div>\r\n");
#nullable restore
#line 13 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Parts\PartsList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"        margin-top: 30px; width:100%;\r\n        display: grid;\r\n        grid-template-columns: repeat(auto-fit, minmax(300px, 1fr))\" id=\"view\">\r\n\r\n");
#nullable restore
#line 19 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Parts\PartsList.cshtml"
         if (Model.Parts.Count() > 0)
        {
            foreach (var part in Model.Parts)
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Parts\PartsList.cshtml"
           Write(Html.Partial("_Part", new { part = part}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\vivian.dancheva\source\repos\OrderSystem\OrderSystem\Views\Parts\PartsList.cshtml"
                                                          
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>



<style>
    * {
        box-sizing: border-box;
    }

    #myInput {
        background-image: url('/css/searchicon.jpg');
        background-position: 10px 12px;
        background-repeat: no-repeat;
        width: 100%;
        font-size: 16px;
        padding: 12px 20px 12px 40px;
        border: 1px solid #ddd;
        margin-bottom: 12px;
    }

    #myUL {
        list-style-type: none;
        padding: 0;
        margin: 0;
    }

        #myUL li a {
            border: 1px solid #ddd;
            margin-top: -1px; /* Prevent double borders */
            background-color: #f6f6f6;
            padding: 12px;
            text-decoration: none;
            font-size: 15px;
            color: black;
            display: block
        }

            #myUL li a:hover:not(.header) {
                background-color: #eee;
            }
</style>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderSystem.ViewModels.PartsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
