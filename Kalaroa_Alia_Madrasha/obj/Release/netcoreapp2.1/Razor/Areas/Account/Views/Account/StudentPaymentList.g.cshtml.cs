#pragma checksum "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\StudentPaymentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dd98de6849a9dfb19ac62b8dbc46767323513c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Account_Views_Account_StudentPaymentList), @"mvc.1.0.view", @"/Areas/Account/Views/Account/StudentPaymentList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Account/Views/Account/StudentPaymentList.cshtml", typeof(AspNetCore.Areas_Account_Views_Account_StudentPaymentList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dd98de6849a9dfb19ac62b8dbc46767323513c1", @"/Areas/Account/Views/Account/StudentPaymentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc73411888bebced195835472bf228434281c0b6", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Account_Views_Account_StudentPaymentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Kalaroa_Alia_Madrasha.ViewModel.StudentPaymentVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\StudentPaymentList.cshtml"
  

    ViewData["Title"] = "Payment";

#line default
#line hidden
            BeginContext(109, 1212, true);
            WriteLiteral(@"
<h1 style=""text-align: center;"">Students Payment List</h1>

<div class=""container"" style=""padding-left: 15px; width: 100%"">
    <table border=""1"" class=""table table-bordered"" cellpadding=""1"" cellspacing=""1"">
        <thead>
            <tr>
                <td style=""text-align:center; font-weight: bold;"">Payment Id</td>
                <td style=""text-align:center; font-weight: bold;"">Student Id</td>
                <td style=""text-align:center; font-weight: bold;"">Month</td>
                <td style=""text-align:center; font-weight: bold;"">Year</td>
                <td style=""text-align:center; font-weight: bold;"">Tuition Fee</td>
                <td style=""text-align:center; font-weight: bold;"">Extra Fee Category</td>
                <td style=""text-align:center; font-weight: bold;"">Extra Fee</td>
                <td style=""text-align:center; font-weight: bold;"">Payment Date</td>
                <td style=""text-align:center; font-weight: bold;"">Total Amount</td>
                <td style=""");
            WriteLiteral("text-align:center; font-weight: bold;\">Student Pay Amount</td>\r\n                <td style=\"text-align:center; font-weight: bold;\">Payment Status</td>\r\n            </tr>\r\n        </thead>\r\n");
            EndContext();
#line 26 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\StudentPaymentList.cshtml"
         foreach (var t in Model)
        {

#line default
#line hidden
            BeginContext(1367, 56, true);
            WriteLiteral("        <tr>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1424, 11, false);
#line 29 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\StudentPaymentList.cshtml"
                                     Write(t.PaymentId);

#line default
#line hidden
            EndContext();
            BeginContext(1435, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1485, 11, false);
#line 30 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\StudentPaymentList.cshtml"
                                     Write(t.StudentId);

#line default
#line hidden
            EndContext();
            BeginContext(1496, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1546, 7, false);
#line 31 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\StudentPaymentList.cshtml"
                                     Write(t.Month);

#line default
#line hidden
            EndContext();
            BeginContext(1553, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1603, 6, false);
#line 32 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\StudentPaymentList.cshtml"
                                     Write(t.Year);

#line default
#line hidden
            EndContext();
            BeginContext(1609, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1659, 12, false);
#line 33 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\StudentPaymentList.cshtml"
                                     Write(t.TuitionFee);

#line default
#line hidden
            EndContext();
            BeginContext(1671, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1721, 18, false);
#line 34 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\StudentPaymentList.cshtml"
                                     Write(t.ExtraFeeCategory);

#line default
#line hidden
            EndContext();
            BeginContext(1739, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1789, 10, false);
#line 35 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\StudentPaymentList.cshtml"
                                     Write(t.ExtraFee);

#line default
#line hidden
            EndContext();
            BeginContext(1799, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1849, 13, false);
#line 36 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\StudentPaymentList.cshtml"
                                     Write(t.PaymentDate);

#line default
#line hidden
            EndContext();
            BeginContext(1862, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1912, 13, false);
#line 37 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\StudentPaymentList.cshtml"
                                     Write(t.TotalAmount);

#line default
#line hidden
            EndContext();
            BeginContext(1925, 49, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(1975, 12, false);
#line 38 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\StudentPaymentList.cshtml"
                                     Write(t.SPayAmount);

#line default
#line hidden
            EndContext();
            BeginContext(1987, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 39 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\StudentPaymentList.cshtml"
             if (t.PaymentStatus == 0)
            {

#line default
#line hidden
            BeginContext(2049, 55, true);
            WriteLiteral("                <td style=\"text-align:center\">Paid</td>");
            EndContext();
#line 41 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\StudentPaymentList.cshtml"
                                                       }
            else
            {

#line default
#line hidden
            BeginContext(2140, 54, true);
            WriteLiteral("                <td style=\"text-align:center\">Due</td>");
            EndContext();
#line 44 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\StudentPaymentList.cshtml"
                                                      }

#line default
#line hidden
            BeginContext(2197, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 46 "H:\MY BOOKS\IUBAT\Visual Projects\Kalaroa_Alia_Madrasha_Demo\Kalaroa_Alia_Madrasha\Areas\Account\Views\Account\StudentPaymentList.cshtml"

        }

#line default
#line hidden
            BeginContext(2225, 20, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Kalaroa_Alia_Madrasha.ViewModel.StudentPaymentVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
