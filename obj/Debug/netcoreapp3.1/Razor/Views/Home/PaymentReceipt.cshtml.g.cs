#pragma checksum "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\PaymentReceipt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7836a181a50da4927bb4ddddb0d11b881581890"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PaymentReceipt), @"mvc.1.0.view", @"/Views/Home/PaymentReceipt.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7836a181a50da4927bb4ddddb0d11b881581890", @"/Views/Home/PaymentReceipt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"368f9781feefc3edff7f3832f6ea5b7d8b8e9b03", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_PaymentReceipt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CPEA.Utilities.ViewModel.GenInvoice>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/EdurexAcademy.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:100%; height:auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""container-fluid d-flex justify-content-between"">
                    <div class=""col-lg-3 pl-0"">
                        <a href=""https://edurex.academy"" class=""noble-ui-logo d-block mt-3"">
                            <div style=""height:60px; width:200px;"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b7836a181a50da4927bb4ddddb0d11b8815818904336", async() => {
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
            WriteLiteral("\n                            </div>\n                        </a>\n");
            WriteLiteral(@"                        <p>20 Awolowo Avenue,<br> Bodija, Ibadan.<br>Oyo. <br />NIGERIA</p>
                        <h5 class=""mt-5 mb-2 text-muted"">Invoice to :</h5>
                        <p><span class=""text-muted"">Student Number : </span>StudentNumber,<br> <span class=""text-muted"">Name : </span>FirstName LastName</p>
                    </div>
                    <div class=""col-lg-3 pr-0"">
                        <h4 class=""font-weight-medium text-uppercase text-right mt-4 mb-2"">receipt</h4>
                        <h6 class=""text-right mb-5 pb-4""># ReceiptNum</h6>
");
            WriteLiteral(@"                        <h6 class=""text-right font-weight-normal""><span class=""text-muted"">Transaction Ref. : </span> paymentRef</h6>
                        <h6 class=""mb-0 mt-3 text-right font-weight-normal mb-2""><span class=""text-muted"">Payment Date : </span> paymentDate</h6>
");
            WriteLiteral(@"                    </div>
                </div>
                <div class=""container-fluid mt-5 d-flex justify-content-center w-100"">
                    <div class=""table-responsive w-100"">
                        <table class=""table table-bordered"">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Description</th>
                                    <th class=""text-right"">Amount Paid</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr class=""text-right"">
                                    <td class=""text-left"">1</td>
                                    <td class=""text-left"">paymentForName</td>
                                    <td>Amount</td>

                                </tr>
                                <tr class=""text-right"">
                                    <td class=""text-left"">2");
            WriteLiteral("</td>\n                                    <td class=\"text-left\">paymentForName</td>\n                                    <td>Amount</td>\n\n                                </tr>\n");
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
                <div class=""container-fluid mt-5 w-100"">
                    <div class=""row"">
                        <div class=""col-md-6 ml-auto"">
                            <div class=""table-responsive"">
                                <table class=""table"">
                                    <tbody>
                                        <tr>
                                            <td>Sub Total</td>
                                            <td class=""text-right""> totalPayment</td>
                                        </tr>                                        
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""container-fluid w-100"">
");
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CPEA.Utilities.ViewModel.GenInvoice> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591