#pragma checksum "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\StudentAccountDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9af134d5c181b97e6b77e7aaba21939d63f9430e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Account_Views_Account_StudentAccountDetails), @"mvc.1.0.view", @"/Areas/Account/Views/Account/StudentAccountDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Account/Views/Account/StudentAccountDetails.cshtml", typeof(AspNetCore.Areas_Account_Views_Account_StudentAccountDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9af134d5c181b97e6b77e7aaba21939d63f9430e", @"/Areas/Account/Views/Account/StudentAccountDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc73411888bebced195835472bf228434281c0b6", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Account_Views_Account_StudentAccountDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kalaroa_Alia_Madrasha.Models.StudentAccount>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\StudentAccountDetails.cshtml"
                                     
    ViewData["Title"] = "Student Account";

#line default
#line hidden
            BeginContext(142, 474, true);
            WriteLiteral(@"
<h1 style=""text-align: center;"">Student Account Details</h1>

<div class=""container"">
    <table border=""1"" class=""table table-bordered"" cellpadding=""1"" cellspacing=""1"">
        <thead>
            <tr>
                <td style=""text-align:center; font-weight: bold;"">Student Id</td>
                <td style=""text-align:center; font-weight: bold;"">Student Name</td>
            </tr>
        </thead>

        <tr>
            <td style=""text-align:center"">");
            EndContext();
            BeginContext(617, 15, false);
#line 19 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\StudentAccountDetails.cshtml"
                                     Write(Model.StudentId);

#line default
#line hidden
            EndContext();
            BeginContext(632, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(682, 17, false);
#line 20 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\StudentAccountDetails.cshtml"
                                     Write(Model.StudentName);

#line default
#line hidden
            EndContext();
            BeginContext(699, 42, true);
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kalaroa_Alia_Madrasha.Models.StudentAccount> Html { get; private set; }
    }
}
#pragma warning restore 1591