#pragma checksum "D:\MY BOOKS\# IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\TeacherAccountDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58125a5e810962c45e374f7728af5d27e7dc76b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Account_Views_Account_TeacherAccountDetails), @"mvc.1.0.view", @"/Areas/Account/Views/Account/TeacherAccountDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Account/Views/Account/TeacherAccountDetails.cshtml", typeof(AspNetCore.Areas_Account_Views_Account_TeacherAccountDetails))]
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
#line 1 "D:\MY BOOKS\# IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\_ViewImports.cshtml"
using Kalaroa_Alia_Madrasha;

#line default
#line hidden
#line 2 "D:\MY BOOKS\# IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\_ViewImports.cshtml"
using Kalaroa_Alia_Madrasha.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58125a5e810962c45e374f7728af5d27e7dc76b5", @"/Areas/Account/Views/Account/TeacherAccountDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc73411888bebced195835472bf228434281c0b6", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Account_Views_Account_TeacherAccountDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kalaroa_Alia_Madrasha.Models.TeacherAccount>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\MY BOOKS\# IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\TeacherAccountDetails.cshtml"
                                     
    ViewData["Title"] = "Teacher Account";

#line default
#line hidden
            BeginContext(142, 795, true);
            WriteLiteral(@"
<h1 style=""text-align: center;"">Teacher Account Details</h1>

<div class=""container"">

    <table border=""1"" class=""table table-bordered"" cellpadding=""1"" cellspacing=""1"">
        <thead>
            <tr>
                <td style=""text-align:center; font-weight: bold;"">Acc No</td>
                <td style=""text-align:center; font-weight: bold;"">Teacher Id</td>
                <td style=""text-align:center; font-weight: bold;"">Teacher Name</td>
                <td style=""text-align:center; font-weight: bold;"">Basic Salary</td>
                <td style=""text-align:center; font-weight: bold;"">Month</td>
                <td style=""text-align:center; font-weight: bold;"">Year</td>
            </tr>
        </thead>

        <tr>
            <td style=""text-align:center"">");
            EndContext();
            BeginContext(938, 11, false);
#line 24 "D:\MY BOOKS\# IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\TeacherAccountDetails.cshtml"
                                     Write(Model.AccNo);

#line default
#line hidden
            EndContext();
            BeginContext(949, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(999, 15, false);
#line 25 "D:\MY BOOKS\# IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\TeacherAccountDetails.cshtml"
                                     Write(Model.TeacherId);

#line default
#line hidden
            EndContext();
            BeginContext(1014, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1064, 17, false);
#line 26 "D:\MY BOOKS\# IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\TeacherAccountDetails.cshtml"
                                     Write(Model.TeacherName);

#line default
#line hidden
            EndContext();
            BeginContext(1081, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1131, 17, false);
#line 27 "D:\MY BOOKS\# IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\TeacherAccountDetails.cshtml"
                                     Write(Model.BasicSalary);

#line default
#line hidden
            EndContext();
            BeginContext(1148, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1198, 11, false);
#line 28 "D:\MY BOOKS\# IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\TeacherAccountDetails.cshtml"
                                     Write(Model.Month);

#line default
#line hidden
            EndContext();
            BeginContext(1209, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1259, 10, false);
#line 29 "D:\MY BOOKS\# IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\TeacherAccountDetails.cshtml"
                                     Write(Model.Year);

#line default
#line hidden
            EndContext();
            BeginContext(1269, 42, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kalaroa_Alia_Madrasha.Models.TeacherAccount> Html { get; private set; }
    }
}
#pragma warning restore 1591
