#pragma checksum "D:\ShoppingCart\ShoppingCart.Web\Views\Products\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de5fbd46669718b3b9ec59a9a8522321e6be8beb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Create), @"mvc.1.0.view", @"/Views/Products/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de5fbd46669718b3b9ec59a9a8522321e6be8beb", @"/Views/Products/Create.cshtml")]
    public class Views_Products_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCart_.DAL.Models.Products>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ShoppingCart\ShoppingCart.Web\Views\Products\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"text-info\">Add New Product</h2>\r\n");
#nullable restore
#line 9 "D:\ShoppingCart\ShoppingCart.Web\Views\Products\Create.cshtml"
     using (Html.BeginForm("Create", "Products", FormMethod.Post, new { enctype = "multipart/form-data" }))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"p-4 rounded border\">\r\n    <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\">\r\n\r\n    </div>\r\n    <h3>");
#nullable restore
#line 15 "D:\ShoppingCart\ShoppingCart.Web\Views\Products\Create.cshtml"
   Write(ViewBag.message);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

    <div class=""form-group row"">
        <div class=""col-2"">
            <label asp-for=""Name"">Name</label>
        </div>
        <div class=""col-5"">
            <input asp-for=""Name"" name=""Name"" class=""form-control"" />
        </div>
        <span asp-validation-for=""Name"" class=""text-danger""></span>
    </div>
    <div class=""form-group row"">
        <div class=""col-2"">
            <label asp-for=""Price"">Price</label>
        </div>
        <div class=""col-5"">
            <input asp-for=""Price"" name=""Price"" class=""form-control"" />
        </div>
        <span asp-validation-for=""Price"" class=""text-danger""></span>
    </div>
    <div class=""form-group row"">
        <div class=""col-2"">
            <label asp-for=""Quantity"">Quantity</label>
        </div>
        <div class=""col-5"">
            <input asp-for=""Quantity"" name=""Quantity"" class=""form-control"" />
        </div>
        <span asp-validation-for=""Quantity"" class=""text-danger""></span>
    </div>
    <div class=""fo");
            WriteLiteral(@"rm-group row"">
        <div class=""col-2"">
            <label asp-for=""Image"">Image</label>
        </div>
        <div class=""col-5"">
            <input asp-for=""Image"" name=""Image"" class=""form-control"" type=""file"" />
        </div>
        <span asp-validation-for=""Image"" class=""text-danger""></span>
    </div>
    <div class=""form-group row"">
        <div class=""col-2"">
            <label asp-for=""Desc"">Description</label>
        </div>
        <div class=""col-5"">
            <input asp-for=""Desc"" name=""Desc"" class=""form-control"" />
        </div>
        <span asp-validation-for=""Desc"" class=""text-danger""></span>
    </div>

    <!--<div class=""form-group row"">
        <div class=""col-2"">
            <label asp-for=""ProductTypeId"">Product Type</label>
        </div>
        <div class=""col-5"">
            <select asp-for=""ProductTypeId"" asp-items=""ViewBag.productTypeId"" class=""form-control""></select>-->
");
            WriteLiteral(@"    <!--</div>
        <span asp-validation-for=""ProductTypeId"" class=""text-danger""></span>
    </div>-->


    <div class=""form-group"">
        <input type=""submit"" class=""btn btn-primary"" value=""Save"" />
        <a class=""btn btn-primary text-white""");
            BeginWriteAttribute("href", " href=\"", 2728, "\"", 2767, 1);
#nullable restore
#line 77 "D:\ShoppingCart\ShoppingCart.Web\Views\Products\Create.cshtml"
WriteAttributeValue("", 2735, Url.Action("Index", "Products"), 2735, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <i class=\"fa fa-pencil-square-o\"></i>&nbsp;Back To List\r\n        </a>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 82 "D:\ShoppingCart\ShoppingCart.Web\Views\Products\Create.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 86 "D:\ShoppingCart\ShoppingCart.Web\Views\Products\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCart_.DAL.Models.Products> Html { get; private set; }
    }
}
#pragma warning restore 1591