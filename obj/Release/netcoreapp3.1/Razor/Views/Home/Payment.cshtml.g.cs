#pragma checksum "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e250dfc8575ae104199465989fe657d4bc5df622"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Payment), @"mvc.1.0.view", @"/Views/Home/Payment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e250dfc8575ae104199465989fe657d4bc5df622", @"/Views/Home/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"368f9781feefc3edff7f3832f6ea5b7d8b8e9b03", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CPEA.Utilities.ViewModel.UserPaymentsVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item d-flex align-items-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EachPayment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DownloadReceipt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""d-flex justify-content-between align-items-center flex-wrap grid-margin"">
    <div>
        <h4 class=""mb-3 mb-md-0"">Payment History</h4>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-12 col-xl-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex justify-content-between align-items-baseline mb-2"">
                    <h6 class=""card-title mb-0""></h6>
                </div>
                <div class=""table-responsive"">
                    <table id=""dataTableExample"" class=""table"">
                        <thead>
                            <tr>
                                <th class=""pt-0"">Transaction Id</th>
                                <th class=""pt-0"">Amount</th>
                                <th class=""pt-0"">Payment Date</th>
                                <th class=""pt-0"">Status</th>
                                <th class=""pt-0"">Payment Method</th>
                      ");
            WriteLiteral("          <th class=\"pt-0\">Action</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Payment.cshtml"
                             if (Model != null && Model.UserPaymentList.Count > 0)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Payment.cshtml"
                                 foreach (var item in Model.UserPaymentList)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 33 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Payment.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.PaymentRef));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 34 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Payment.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 35 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Payment.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.PaymentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n");
#nullable restore
#line 37 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Payment.cshtml"
                                             if (item.Status == CPEA.Utilities.PaymentStatusEnums.Paid)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"badge badge-success\">PAID</span>\r\n");
#nullable restore
#line 40 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Payment.cshtml"
                                            }
                                            else if (item.Status == CPEA.Utilities.PaymentStatusEnums.Initialized)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"badge badge-warning\">INITIALIZED</span>\r\n");
#nullable restore
#line 44 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Payment.cshtml"
                                            }
                                            else if (item.Status == CPEA.Utilities.PaymentStatusEnums.Pending)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"badge badge-info-muted\">PENDING</span>\r\n");
#nullable restore
#line 48 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Payment.cshtml"
                                            }
                                            else if (item.Status == CPEA.Utilities.PaymentStatusEnums.Failed)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"badge badge-danger\">FAILED</span>\r\n");
#nullable restore
#line 52 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Payment.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                        <td>\r\n");
#nullable restore
#line 55 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Payment.cshtml"
                                             if (item.PaymentMethod == CPEA.Utilities.PaymentMethodEnums.Card)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span>DEBIT CARD</span>\r\n");
#nullable restore
#line 58 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Payment.cshtml"
                                            }
                                            else if (item.PaymentMethod == CPEA.Utilities.PaymentMethodEnums.Offline)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span>OFFLINE</span>\r\n");
#nullable restore
#line 62 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Payment.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </td>
                                        <td>
                                            <div class=""dropdown mb-2"">
                                                <button class=""btn p-0"" type=""button"" id=""dropdownMenuButton2"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                                    <i class=""icon-lg text-muted pb-3px"" data-feather=""more-horizontal""></i>
                                                </button>
                                                <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton2"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e250dfc8575ae104199465989fe657d4bc5df62211333", async() => {
                WriteLiteral("<i data-feather=\"edit\" class=\"icon-sm mr-2\"></i> <span");
                BeginWriteAttribute("class", " class=\"", 4576, "\"", 4584, 0);
                EndWriteAttribute();
                WriteLiteral(">View Payment</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-paymentRef", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Payment.cshtml"
                                                                                                                                                                WriteLiteral(item.PaymentRef);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["paymentRef"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-paymentRef", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["paymentRef"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 71 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Payment.cshtml"
                                                     if (item.Status == CPEA.Utilities.PaymentStatusEnums.Paid)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e250dfc8575ae104199465989fe657d4bc5df62214549", async() => {
                WriteLiteral("<i data-feather=\"download\" class=\"icon-sm mr-2\"></i> <span");
                BeginWriteAttribute("class", " class=\"", 5035, "\"", 5043, 0);
                EndWriteAttribute();
                WriteLiteral(">Download Receipt</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-paymentRef", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Payment.cshtml"
                                                                                                                                                                        WriteLiteral(item.PaymentRef);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["paymentRef"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-paymentRef", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["paymentRef"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 74 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Payment.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 76 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Payment.cshtml"
                                                     if (item.Status != CPEA.Utilities.PaymentStatusEnums.Paid && item.PaymentMethod != CPEA.Utilities.PaymentMethodEnums.Offline)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <a class=\"dropdown-item d-flex align-items-center\" href=\"#\"><i data-feather=\"edit\" class=\"icon-sm mr-2\"></i> <span");
            BeginWriteAttribute("class", " class=\"", 5536, "\"", 5544, 0);
            EndWriteAttribute();
            WriteLiteral(">Requery</span></a>\r\n");
#nullable restore
#line 79 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Payment.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n                                            \r\n\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 87 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Payment.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Payment.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CPEA.Utilities.ViewModel.UserPaymentsVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591