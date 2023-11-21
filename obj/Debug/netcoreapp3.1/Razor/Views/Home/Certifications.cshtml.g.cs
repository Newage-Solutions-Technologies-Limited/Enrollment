#pragma checksum "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Certifications.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb860659923de58ec1dda02537674c36385f9dd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Certifications), @"mvc.1.0.view", @"/Views/Home/Certifications.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb860659923de58ec1dda02537674c36385f9dd4", @"/Views/Home/Certifications.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"368f9781feefc3edff7f3832f6ea5b7d8b8e9b03", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Certifications : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CPEA.Utilities.ViewModel.UserCertificationsVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OnlyCertifications", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 15px; background-color: #058383 !important "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""d-flex justify-content-between align-items-center flex-wrap grid-margin"">
    <div>
        <h4 class=""mb-3 mb-md-0"">My Certifications</h4>
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
                                <th class=""pt-0"">Short Code</th>
                                <th class=""pt-0"">Cert. Name</th>
                                <th class=""pt-0"">Provider</th>
                                <th class=""pt-0"">Price</th>
                                <th class=""pt-0"">ExamDate</th>
                                <");
            WriteLiteral("th class=\"pt-0\">Status</th>\r\n                                <th class=\"pt-0\">Action</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Certifications.cshtml"
                             if (Model != null && Model.UserCertificationList.Count > 0)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Certifications.cshtml"
                                 foreach (var item in Model.UserCertificationList)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 33 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Certifications.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.ShortCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 34 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Certifications.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 35 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Certifications.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.provider));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>₦ ");
#nullable restore
#line 36 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Certifications.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 37 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Certifications.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.ExamDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n");
#nullable restore
#line 39 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Certifications.cshtml"
                                             if (item.ProgramStatus == CPEA.Utilities.UserCourseStatusEnums.Completed)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"badge badge-success\">COMPLETED</span>\r\n");
#nullable restore
#line 42 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Certifications.cshtml"
                                            }
                                            else if (item.ProgramStatus == CPEA.Utilities.UserCourseStatusEnums.InProgress)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"badge badge-warning\">IN PROGRESS</span>\r\n");
#nullable restore
#line 46 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Certifications.cshtml"
                                            }
                                            else if (item.ProgramStatus == CPEA.Utilities.UserCourseStatusEnums.Pending)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"badge badge-danger\">REGISTERED</span>\r\n");
#nullable restore
#line 50 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Certifications.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </td>
                                        <td>
                                            <div class=""dropdown mb-2"">
                                                <button class=""btn p-0"" type=""button"" id=""dropdownMenuButton1"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                                    <i class=""icon-lg text-muted pb-3px"" data-feather=""more-horizontal""></i>
                                                </button>
                                                <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton1"">
                                                    <a class=""dropdown-item d-flex align-items-center"" href=""#""><i data-feather=""edit"" class=""icon-sm mr-2""></i> <span");
            BeginWriteAttribute("class", " class=\"", 3832, "\"", 3840, 0);
            EndWriteAttribute();
            WriteLiteral(">Print Registration</span></a>\r\n                                                    <a class=\"dropdown-item d-flex align-items-center\" href=\"#\"><i data-feather=\"download\" class=\"icon-sm mr-2\"></i> <span");
            BeginWriteAttribute("class", " class=\"", 4043, "\"", 4051, 0);
            EndWriteAttribute();
            WriteLiteral(">Download Guide</span></a>\r\n                                                    <a class=\"dropdown-item d-flex align-items-center\" href=\"#\"><i data-feather=\"plus-square\" class=\"icon-sm mr-2\"></i> <span");
            BeginWriteAttribute("class", " class=\"", 4253, "\"", 4261, 0);
            EndWriteAttribute();
            WriteLiteral(">Change Exam Date</span></a>\r\n\r\n                                                </div>\r\n                                            </div>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 66 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Certifications.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Home\Certifications.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n<div style=\" text-align:right\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb860659923de58ec1dda02537674c36385f9dd412441", async() => {
                WriteLiteral("Register New Certification");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CPEA.Utilities.ViewModel.UserCertificationsVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591