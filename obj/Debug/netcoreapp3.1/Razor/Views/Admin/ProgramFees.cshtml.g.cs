#pragma checksum "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\ProgramFees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c2783bbf2a5c4c324a3abe7133f3d7930c84a12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ProgramFees), @"mvc.1.0.view", @"/Views/Admin/ProgramFees.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c2783bbf2a5c4c324a3abe7133f3d7930c84a12", @"/Views/Admin/ProgramFees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"368f9781feefc3edff7f3832f6ea5b7d8b8e9b03", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_ProgramFees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CPEA.Utilities.DTO.programFees>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\ProgramFees.cshtml"
  
    Layout = "~/Views/Shared/_adminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"    <div class=""d-flex justify-content-between align-items-center flex-wrap grid-margin"">
        <div>
            <h4 class=""mb-3 mb-md-0"">Program Options</h4>
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
                        <table class=""table table-hover mb-0"">
                            <thead>
                                <tr>
                                    <th class=""pt-0"">Id</th>
                                    <th class=""pt-0"">Name</th>
                                    <th class=""pt-0"">Price (NGN)</th>
                                    <th class=""pt-0"">Deposit (NGN)</th>
                           ");
            WriteLiteral(@"         <th class=""pt-0"">Price (USD)</th>
                                    <th class=""pt-0"">Deposit (USD)</th>
                                    <th class=""pt-0"">Action</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 32 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\ProgramFees.cshtml"
                                 if (Model != null && Model.Count > 0)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\ProgramFees.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 37 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\ProgramFees.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 38 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\ProgramFees.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>₦ ");
#nullable restore
#line 39 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\ProgramFees.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.PriceNGN));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>₦ ");
#nullable restore
#line 40 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\ProgramFees.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.DepositNGN));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>$ ");
#nullable restore
#line 41 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\ProgramFees.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.PriceUSD));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>$ ");
#nullable restore
#line 42 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\ProgramFees.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.DepositUSD));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td></td>\r\n                                        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\ProgramFees.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\ProgramFees.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CPEA.Utilities.DTO.programFees>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591