#pragma checksum "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Users\Views\Users\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6d990066c3772b049654ea8de0da396c5abde42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Users_Views_Users_UserList), @"mvc.1.0.view", @"/Areas/Users/Views/Users/UserList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Users/Views/Users/UserList.cshtml", typeof(AspNetCore.Areas_Users_Views_Users_UserList))]
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
#line 1 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\_ViewImports.cshtml"
using Kalaroa_Alia_Madrasha;

#line default
#line hidden
#line 2 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\_ViewImports.cshtml"
using Kalaroa_Alia_Madrasha.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6d990066c3772b049654ea8de0da396c5abde42", @"/Areas/Users/Views/Users/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc73411888bebced195835472bf228434281c0b6", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Users_Views_Users_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Kalaroa_Alia_Madrasha.Models.Users>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Users\Views\Users\UserList.cshtml"
  
    ViewData["Title"] = "User List";

#line default
#line hidden
            BeginContext(94, 191, true);
            WriteLiteral("\r\n<h1 style=\"text-align:center\">User Login Information</h1>\r\n\r\n<div class=\"container\" style=\"width: 20%;\">\r\n    <div class=\"form-group\">\r\n        <div class=\"input-group-addon\">\r\n            ");
            EndContext();
            BeginContext(285, 313, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f03404a713f41faa8cf9ee4db1d9d7e", async() => {
                BeginContext(351, 103, true);
                WriteLiteral("\r\n                <input placeholder=\"Search By Id\" class=\"form-control\" name=\"id\" />\r\n                ");
                EndContext();
                BeginContext(454, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b21225f7ff6d442bb8aae2d5fd99b8d0", async() => {
                    BeginContext(535, 38, true);
                    WriteLiteral("<input type=\"submit\" value=\"Search\" />");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(577, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(598, 787, true);
            WriteLiteral(@"
        </div>
    </div>
</div>
<div class=""container"">
    <table border=""1"" class=""table table-bordered"" cellpadding=""1"" cellspacing=""1"">
        <thead>
            <tr>
                <td style=""text-align:center; font-weight: bold;"">Login Id</td>
                <td style=""text-align:center; font-weight: bold;"">User Id</td>
                <td style=""text-align:center; font-weight: bold;"">User Type</td>
                <td style=""text-align:center; font-weight: bold;"">First Name</td>
                <td style=""text-align:center; font-weight: bold;"">Last Name</td>
                <td style=""text-align:center; font-weight: bold;"">Email</td>
                <td style=""text-align:center; font-weight: bold;"">Password</td>
            </tr>
        </thead>
");
            EndContext();
#line 31 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Users\Views\Users\UserList.cshtml"
         foreach (var ac in Model)
        {

#line default
#line hidden
            BeginContext(1432, 56, true);
            WriteLiteral("        <tr>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1489, 10, false);
#line 34 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Users\Views\Users\UserList.cshtml"
                                     Write(ac.LoginId);

#line default
#line hidden
            EndContext();
            BeginContext(1499, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1549, 9, false);
#line 35 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Users\Views\Users\UserList.cshtml"
                                     Write(ac.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(1558, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1608, 11, false);
#line 36 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Users\Views\Users\UserList.cshtml"
                                     Write(ac.UserType);

#line default
#line hidden
            EndContext();
            BeginContext(1619, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1669, 12, false);
#line 37 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Users\Views\Users\UserList.cshtml"
                                     Write(ac.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1681, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1731, 11, false);
#line 38 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Users\Views\Users\UserList.cshtml"
                                     Write(ac.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1742, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1792, 8, false);
#line 39 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Users\Views\Users\UserList.cshtml"
                                     Write(ac.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1800, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1850, 11, false);
#line 40 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Users\Views\Users\UserList.cshtml"
                                     Write(ac.Password);

#line default
#line hidden
            EndContext();
            BeginContext(1861, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 42 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Users\Views\Users\UserList.cshtml"
        }

#line default
#line hidden
            BeginContext(1894, 20, true);
            WriteLiteral("    </table>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Kalaroa_Alia_Madrasha.Models.Users>> Html { get; private set; }
    }
}
#pragma warning restore 1591
