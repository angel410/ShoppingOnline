#pragma checksum "D:\ShoppingCart\ShoppingCart.Web\Views\Home\CustomerOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56000016e621418df820cbe87dcab859e3bda6b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CustomerOrders), @"mvc.1.0.view", @"/Views/Home/CustomerOrders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56000016e621418df820cbe87dcab859e3bda6b7", @"/Views/Home/CustomerOrders.cshtml")]
    public class Views_Home_CustomerOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShoppingCart_.DAL.Models.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ShoppingCart\ShoppingCart.Web\Views\Home\CustomerOrders.cshtml"
  
    ViewData["Title"] = "CustomerOrders";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<table class=""table"">
    <thead>
        <tr>
          
            <th>
              Order Total Price
            </th>
            <th>
                Order Date
            </th>
           
            <th>
                
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 26 "D:\ShoppingCart\ShoppingCart.Web\Views\Home\CustomerOrders.cshtml"
         if (Model.Count()>0)
        {
            foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 33 "D:\ShoppingCart\ShoppingCart.Web\Views\Home\CustomerOrders.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OrderTotlPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 36 "D:\ShoppingCart\ShoppingCart.Web\Views\Home\CustomerOrders.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n              \r\n                        <a class=\"btn btn-primary text-white\"");
            BeginWriteAttribute("href", " href=\"", 942, "\"", 1014, 1);
#nullable restore
#line 41 "D:\ShoppingCart\ShoppingCart.Web\Views\Home\CustomerOrders.cshtml"
WriteAttributeValue("", 949, Url.Action("CustomerOrderDetails", "Home", new { id = item.Id }), 949, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"fa fa-pencil-square-o\"></i>&nbsp;Details\r\n                        </a>\r\n\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 47 "D:\ShoppingCart\ShoppingCart.Web\Views\Home\CustomerOrders.cshtml"
            }

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShoppingCart_.DAL.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591