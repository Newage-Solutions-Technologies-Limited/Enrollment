#pragma checksum "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5c8381c60d9dbcc9c8937583f1f2adddd0064ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Payments), @"mvc.1.0.view", @"/Views/Admin/Payments.cshtml")]
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
#line 1 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\_ViewImports.cshtml"
using CPEA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\_ViewImports.cshtml"
using CPEA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5c8381c60d9dbcc9c8937583f1f2adddd0064ba", @"/Views/Admin/Payments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"368f9781feefc3edff7f3832f6ea5b7d8b8e9b03", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Payments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CPEA.Utilities.ViewModel.PaymentVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
  
    Layout = "~/Views/Shared/_adminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""d-flex justify-content-between align-items-center flex-wrap grid-margin"">
    <div>
        <h4 class=""mb-3 mb-md-0"">Payment History</h4>
    </div>
</div>

<div class=""row"">
    <div class=""col-12 col-xl-12 stretch-card"">
        <div class=""row flex-grow"">
            <div class=""col-md-4 grid-margin stretch-card"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""d-flex justify-content-between align-items-baseline"">
                            <h6 class=""card-title mb-0"">Today</h6>
                            <div class=""dropdown mb-2"">
                                <h4 class=""mb-2"">");
#nullable restore
#line 21 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                            Write(Model.TodayRe.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-4 col-md-4 col-xl-4\">\r\n                                <h5 class=\"mb-2\">");
#nullable restore
#line 26 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                            Write(Model.TodayRe.Failed);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                <div class=""d-flex align-items-baseline"">
                                    <p class=""text-danger"">
                                        <span>Failed</span>
                                    </p>
                                </div>
                            </div>
                            <div class=""col-4 col-md-4 col-xl-4"">
                                <h5 class=""mb-2"">");
#nullable restore
#line 34 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                            Write(Model.TodayRe.Pending);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                <div class=""d-flex align-items-baseline"">
                                    <p class=""text-warning"">
                                        <span>Pending</span>
                                    </p>
                                </div>
                            </div>
                            <div class=""col-4 col-md-4 col-xl-4"">
                                <h5 class=""mb-2"">");
#nullable restore
#line 42 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                            Write(Model.TodayRe.Successful);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                <div class=""d-flex align-items-baseline"">
                                    <p class=""text-success"">
                                        <span>Successful</span>
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            
            <div class=""col-md-4 grid-margin stretch-card"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""d-flex justify-content-between align-items-baseline"">
                            <h6 class=""card-title mb-0"">This Week</h6>
                            <div class=""dropdown mb-2"">
                                <h4 class=""mb-2"">");
#nullable restore
#line 60 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                            Write(Model.WeekRe.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-4 col-md-4 col-xl-4\">\r\n                                <h5 class=\"mb-2\">");
#nullable restore
#line 65 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                            Write(Model.WeekRe.Failed);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                <div class=""d-flex align-items-baseline"">
                                    <p class=""text-danger"">
                                        <span>Failed</span>
                                    </p>
                                </div>
                            </div>
                            <div class=""col-4 col-md-4 col-xl-4"">
                                <h5 class=""mb-2"">");
#nullable restore
#line 73 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                            Write(Model.WeekRe.Pending);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                <div class=""d-flex align-items-baseline"">
                                    <p class=""text-warning"">
                                        <span>Pending</span>
                                    </p>
                                </div>
                            </div>
                            <div class=""col-4 col-md-4 col-xl-4"">
                                <h5 class=""mb-2"">");
#nullable restore
#line 81 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                            Write(Model.WeekRe.Successful);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                <div class=""d-flex align-items-baseline"">
                                    <p class=""text-success"">
                                        <span>Successful</span>
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 grid-margin stretch-card"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""d-flex justify-content-between align-items-baseline"">
                            <h6 class=""card-title mb-0"">This Month</h6>
                            <div class=""dropdown mb-2"">
                                <h4 class=""mb-2"">");
#nullable restore
#line 98 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                            Write(Model.MonthRe.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-4 col-md-4 col-xl-4\">\r\n                                <h5 class=\"mb-2\">");
#nullable restore
#line 103 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                            Write(Model.MonthRe.Failed);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                <div class=""d-flex align-items-baseline"">
                                    <p class=""text-danger"">
                                        <span>Failed</span>
                                    </p>
                                </div>
                            </div>
                            <div class=""col-4 col-md-4 col-xl-4"">
                                <h5 class=""mb-2"">");
#nullable restore
#line 111 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                            Write(Model.MonthRe.Pending);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                <div class=""d-flex align-items-baseline"">
                                    <p class=""text-warning"">
                                        <span>Pending</span>
                                    </p>
                                </div>
                            </div>
                            <div class=""col-4 col-md-4 col-xl-4"">
                                <h5 class=""mb-2"">");
#nullable restore
#line 119 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                            Write(Model.MonthRe.Successful);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                <div class=""d-flex align-items-baseline"">
                                    <p class=""text-success"">
                                        <span>Successful</span>
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
            WriteLiteral(@"        </div>
    </div>
</div> <!-- row -->


<div class=""row"">
    <div class=""col-lg-12 col-xl-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex justify-content-between align-items-baseline mb-2"">
                    <h6 class=""card-title mb-0""></h6>
                </div>
                <div class=""table-responsive"">
                    <table class=""table table-hover mb-0 "" id=""dataTableExample"">
                        <thead>
                            <tr>
");
            WriteLiteral(@"                                <th class=""pt-0"">Payment Reference</th>
                                <th class=""pt-0"">Student Id</th>
                                <th class=""pt-0"">Payee</th>
                                <th class=""pt-0"">Amount</th>
                                <th class=""pt-0"">Program</th>
                                <th class=""pt-0"">Status</th>
                                <th class=""pt-0"">Payment Date</th>
                                <th class=""pt-0"">Payment Method</th>

                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 194 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                             if (Model != null && Model.AllPayments.Count > 0)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 196 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                 foreach (var item in Model.AllPayments)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n\r\n                                        <td>");
#nullable restore
#line 200 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.PaymentReference));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 201 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.StudentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 202 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Payee));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>₦ ");
#nullable restore
#line 203 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 204 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Program));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n");
#nullable restore
#line 206 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                             if (item.StatusId == CPEA.Utilities.PaymentStatusEnums.Paid)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"badge badge-success\">");
#nullable restore
#line 208 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                                                             Write(Html.DisplayFor(modelItem => item.StatusId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 209 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                            }
                                            else if (item.StatusId == CPEA.Utilities.PaymentStatusEnums.Initialized)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"badge badge-warning\">");
#nullable restore
#line 212 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                                                             Write(Html.DisplayFor(modelItem => item.StatusId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 213 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                            }
                                            else if (item.StatusId == CPEA.Utilities.PaymentStatusEnums.Pending)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"badge badge-info-muted\">");
#nullable restore
#line 216 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                                                                Write(Html.DisplayFor(modelItem => item.StatusId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 217 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                            }
                                            else if (item.StatusId == CPEA.Utilities.PaymentStatusEnums.Failed)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"badge badge-danger\">");
#nullable restore
#line 220 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                                                            Write(Html.DisplayFor(modelItem => item.StatusId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 221 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                        <td>");
#nullable restore
#line 223 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.PaymentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 224 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.PaymentMethodId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                    </tr>\r\n");
#nullable restore
#line 227 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 227 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\Payments.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CPEA.Utilities.ViewModel.PaymentVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591