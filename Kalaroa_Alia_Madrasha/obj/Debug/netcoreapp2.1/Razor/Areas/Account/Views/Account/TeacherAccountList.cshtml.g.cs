#pragma checksum "D:\MY BOOKS\# IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\TeacherAccountList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7add41f663676dd1f4cd061fc05414f4fa90e12f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Account_Views_Account_TeacherAccountList), @"mvc.1.0.view", @"/Areas/Account/Views/Account/TeacherAccountList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Account/Views/Account/TeacherAccountList.cshtml", typeof(AspNetCore.Areas_Account_Views_Account_TeacherAccountList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7add41f663676dd1f4cd061fc05414f4fa90e12f", @"/Areas/Account/Views/Account/TeacherAccountList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc73411888bebced195835472bf228434281c0b6", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Account_Views_Account_TeacherAccountList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Kalaroa_Alia_Madrasha.Models.TeacherAccount>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\MY BOOKS\# IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\TeacherAccountList.cshtml"
  
    
    ViewData["Title"] = "Teacher Account";

#line default
#line hidden
            BeginContext(116, 733, true);
            WriteLiteral(@"
<h1 style=""text-align: center;"">Teachers Account List</h1>

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
");
            EndContext();
#line 21 "D:\MY BOOKS\# IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\TeacherAccountList.cshtml"
         foreach (var t in Model)
        {

#line default
#line hidden
            BeginContext(895, 64, true);
            WriteLiteral("            <tr>\r\n                <td style=\"text-align:center\">");
            EndContext();
            BeginContext(960, 7, false);
#line 24 "D:\MY BOOKS\# IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\TeacherAccountList.cshtml"
                                         Write(t.AccNo);

#line default
#line hidden
            EndContext();
            BeginContext(967, 53, true);
            WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1021, 11, false);
#line 25 "D:\MY BOOKS\# IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\TeacherAccountList.cshtml"
                                         Write(t.TeacherId);

#line default
#line hidden
            EndContext();
            BeginContext(1032, 53, true);
            WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1086, 13, false);
#line 26 "D:\MY BOOKS\# IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\TeacherAccountList.cshtml"
                                         Write(t.TeacherName);

#line default
#line hidden
            EndContext();
            BeginContext(1099, 53, true);
            WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1153, 13, false);
#line 27 "D:\MY BOOKS\# IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\TeacherAccountList.cshtml"
                                         Write(t.BasicSalary);

#line default
#line hidden
            EndContext();
            BeginContext(1166, 53, true);
            WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1220, 7, false);
#line 28 "D:\MY BOOKS\# IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\TeacherAccountList.cshtml"
                                         Write(t.Month);

#line default
#line hidden
            EndContext();
            BeginContext(1227, 53, true);
            WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1281, 6, false);
#line 29 "D:\MY BOOKS\# IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\TeacherAccountList.cshtml"
                                         Write(t.Year);

#line default
#line hidden
            EndContext();
            BeginContext(1287, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 31 "D:\MY BOOKS\# IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\TeacherAccountList.cshtml"
        }

#line default
#line hidden
            BeginContext(1324, 20, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Kalaroa_Alia_Madrasha.Models.TeacherAccount>> Html { get; private set; }
    }
}
#pragma warning restore 1591
