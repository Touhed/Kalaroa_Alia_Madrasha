#pragma checksum "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Admin\Views\Admin\AdminDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cc284e9808359416b94b0db56725ae356aeecbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Admin_AdminDetails), @"mvc.1.0.view", @"/Areas/Admin/Views/Admin/AdminDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Admin/AdminDetails.cshtml", typeof(AspNetCore.Areas_Admin_Views_Admin_AdminDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cc284e9808359416b94b0db56725ae356aeecbf", @"/Areas/Admin/Views/Admin/AdminDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc73411888bebced195835472bf228434281c0b6", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Admin_AdminDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kalaroa_Alia_Madrasha.Models.Admin>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Admin\Views\Admin\AdminDetails.cshtml"
  
    ViewData["Title"] = "Admin";

#line default
#line hidden
            BeginContext(85, 691, true);
            WriteLiteral(@"
<h1 style=""text-align:center"">Admin Information</h1>

<div class=""container"">
    <table border=""1"" class=""table table-bordered"" cellpadding=""1"" cellspacing=""1"">
        <thead>
            <tr>
                <td style=""text-align:center; font-weight: bold;"">AdminId</td>
                <td style=""text-align:center; font-weight: bold;"">Name</td>
                <td style=""text-align:center; font-weight: bold;"">Email</td>
                <td style=""text-align:center; font-weight: bold;"">Contact</td>
                <td style=""text-align:center; font-weight: bold;"">Photo</td>
            </tr>
        </thead>

        <tr>
            <td style=""text-align:center"">");
            EndContext();
            BeginContext(777, 13, false);
#line 21 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Admin\Views\Admin\AdminDetails.cshtml"
                                     Write(Model.AdminId);

#line default
#line hidden
            EndContext();
            BeginContext(790, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(840, 10, false);
#line 22 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Admin\Views\Admin\AdminDetails.cshtml"
                                     Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(850, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(900, 11, false);
#line 23 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Admin\Views\Admin\AdminDetails.cshtml"
                                     Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(911, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(961, 13, false);
#line 24 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Admin\Views\Admin\AdminDetails.cshtml"
                                     Write(Model.Contact);

#line default
#line hidden
            EndContext();
            BeginContext(974, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1024, 11, false);
#line 25 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Admin\Views\Admin\AdminDetails.cshtml"
                                     Write(Model.Photo);

#line default
#line hidden
            EndContext();
            BeginContext(1035, 44, true);
            WriteLiteral("</td>\r\n        </tr>\r\n\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kalaroa_Alia_Madrasha.Models.Admin> Html { get; private set; }
    }
}
#pragma warning restore 1591
