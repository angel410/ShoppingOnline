#pragma checksum "D:\ShoppingCart\ShoppingCart.Web\Views\Users\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60c9a0486110d178f6e1c65fecd942acfe443afe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Login), @"mvc.1.0.view", @"/Views/Users/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60c9a0486110d178f6e1c65fecd942acfe443afe", @"/Views/Users/Login.cshtml")]
    public class Views_Users_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCart_.DAL.Models.Users>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Login.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Login.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ShoppingCart\ShoppingCart.Web\Views\Users\Login.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "60c9a0486110d178f6e1c65fecd942acfe443afe4130", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60c9a0486110d178f6e1c65fecd942acfe443afe5252", async() => {
                WriteLiteral("\r\n    <title>Login/Sign Up Form</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60c9a0486110d178f6e1c65fecd942acfe443afe6259", async() => {
                WriteLiteral("\r\n    <h3>");
#nullable restore
#line 15 "D:\ShoppingCart\ShoppingCart.Web\Views\Users\Login.cshtml"
   Write(ViewBag.message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n    <h3>");
#nullable restore
#line 16 "D:\ShoppingCart\ShoppingCart.Web\Views\Users\Login.cshtml"
   Write(ViewBag.error);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n    <div class=\"container\" id=\"container\">\r\n        <!-- sign in page -->\r\n        <div class=\"form-container sign-in-container\">\r\n");
#nullable restore
#line 20 "D:\ShoppingCart\ShoppingCart.Web\Views\Users\Login.cshtml"
             using (Html.BeginForm("Login", "Users", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <h1 class=\"form__title\">Login</h1>\r\n");
                WriteLiteral(@"                <div class=""form__input-group"">

                    <label asp-for=""UserName"" class=""control-label"">Username:</label>
                    <input asp-for=""UserName"" class=""form__input"" name=""UserName"" id=""UserName"" />
                    <span asp-validation-for=""UserName"" class=""text-danger""></span>
                </div>
                <div class=""form__input-group"">
                    <label asp-for=""Password"" class=""control-label"">Password:</label>
                    <input type=""password"" asp-for=""Password"" class=""form__input"" name=""password"" id=""password"" />
                    <span asp-validation-for=""Password"" class=""text-danger""></span>
                </div>
                <div class=""form__input-group"">
                    <input type=""submit"" value=""Login"" class=""btn btn-primary"" />
                </div>
");
#nullable restore
#line 38 "D:\ShoppingCart\ShoppingCart.Web\Views\Users\Login.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n\r\n        <!--  create account page -->\r\n\r\n        <div class=\"form-container sign-up-container\">\r\n\r\n\r\n");
#nullable restore
#line 46 "D:\ShoppingCart\ShoppingCart.Web\Views\Users\Login.cshtml"
             using (Html.BeginForm("Create", "Users", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n");
                WriteLiteral(@"                <div class=""form__input-group"">
                    <label asp-for=""Email"" class=""control-label"">Email:</label>
                    <input asp-for=""Email"" type=""email"" class=""form-control"" name=""Email"" id=""Email"" />
                    <span asp-validation-for=""Email"" class=""text-danger""></span>
                </div>
                <div class=""form__input-group"">
                    <label asp-for=""FullName"" class=""control-label"">FullName:</label>
                    <input asp-for=""FullName"" class=""form-control"" name=""FullName"" id=""FullName"" />
                    <span asp-validation-for=""FullName"" class=""text-danger""></span>
                </div>
                <div class=""form__input-group"">
                    <label asp-for=""Address"" class=""control-label"">Address:</label>
                    <input asp-for=""Address"" class=""form-control"" name=""Address"" id=""Address"" />
                    <span asp-validation-for=""Address"" class=""text-danger""></span>
                </div");
                WriteLiteral(@">
                <div class=""form__input-group"">
                    <label asp-for=""PhoneNo"" class=""control-label"">PhoneNo:</label>
                    <input asp-for=""PhoneNo"" class=""form-control"" name=""PhoneNo"" id=""PhoneNo"" />
                    <span asp-validation-for=""PhoneNo"" class=""text-danger""></span>
                </div>
                <div class=""form__input-group"">

                    <label asp-for=""UserName"" class=""control-label"">Username:</label>
                    <input asp-for=""UserName"" class=""form__input"" name=""UserName"" id=""UserName"" />
                    <span asp-validation-for=""UserName"" class=""text-danger""></span>
                </div>
                <div class=""form__input-group"">
                    <label asp-for=""Password"" class=""control-label"">Password:</label>
                    <input type=""password"" asp-for=""Password"" class=""form__input"" name=""password"" id=""password"" />
                    <span asp-validation-for=""Password"" class=""text-danger""></span");
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form__input-group\">\r\n                    <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n                </div>\r\n");
#nullable restore
#line 85 "D:\ShoppingCart\ShoppingCart.Web\Views\Users\Login.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
        <div class=""overlay-container"">
            <div class=""overlay"">
                <div class=""overlay-panel overlay-left"">
                    <h1>Welcome Back!</h1>
                    <p>Please login with your personal info</p>
                    <button class=""ghost"" id=""signIn"">Sign In</button>
                </div>
                <div class=""overlay-panel overlay-right"">
                    <h1>Hello, Friend!</h1>
                    <p>Enter your personal details and start journey with us</p>
                    <button asp-controller=""Users""
                            asp-action=""Create"" class=""ghost"" id=""signUp"">
                        Sign Up
                    </button>
                </div>
            </div>
        </div>
    </div>

    <script src=""scripts/main.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60c9a0486110d178f6e1c65fecd942acfe443afe13280", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 112 "D:\ShoppingCart\ShoppingCart.Web\Views\Users\Login.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCart_.DAL.Models.Users> Html { get; private set; }
    }
}
#pragma warning restore 1591
