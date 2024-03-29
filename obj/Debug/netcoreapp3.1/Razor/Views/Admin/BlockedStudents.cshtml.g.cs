#pragma checksum "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d796e092c29b057fa904bd4c8b7463d4a2ed7fc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_BlockedStudents), @"mvc.1.0.view", @"/Views/Admin/BlockedStudents.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d796e092c29b057fa904bd4c8b7463d4a2ed7fc6", @"/Views/Admin/BlockedStudents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"368f9781feefc3edff7f3832f6ea5b7d8b8e9b03", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_BlockedStudents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CPEA.Utilities.ViewModel.RegisteredStudentsVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SingleStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "UnBlockStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
  
    Layout = "~/Views/Shared/_adminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"d-flex justify-content-between align-items-center flex-wrap grid-margin\">\r\n    <div>\r\n        <h4 class=\"mb-3 mb-md-0\">Blocked Students</h4>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 13 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
 if (CPEA.Utilities.GeneralClass.role == "Admin")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-lg-12 col-xl-12 grid-margin stretch-card"">
            <div class=""card"">
                <div class=""card-body"">

                    <div class=""table-responsive"">
                        <table class=""table table-hover mb-0 "" id=""dataTableExample"">
                            <thead>
                                <tr>
                                    <th class=""pt-0"">Student Id</th>
                                    <th class=""pt-0"">Full Name</th>
                                    <th class=""pt-0"">Email</th>
                                    <th class=""pt-0"">Reg. Date</th>
                                    <th class=""pt-0"">Last Login</th>
                                    <th class=""pt-0"">Total Courses</th>
                                    <th class=""pt-0"">Total Certs</th>
                                    <th class=""pt-0"">Action</th>

                                </tr>
                            </thead>
            ");
            WriteLiteral("                <tbody>\r\n");
#nullable restore
#line 36 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                 if (Model != null && Model.RegisteredStudents.Count > 0)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                     foreach (var item in Model.RegisteredStudents)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d796e092c29b057fa904bd4c8b7463d4a2ed7fc66773", async() => {
                WriteLiteral(" ");
#nullable restore
#line 42 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                                                                                                               Write(Html.DisplayFor(modelItem => item.StudentNumber));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-email", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                                                                                          WriteLiteral(item.Email);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-email", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>");
#nullable restore
#line 44 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 44 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d796e092c29b057fa904bd4c8b7463d4a2ed7fc610369", async() => {
                WriteLiteral(" ");
#nullable restore
#line 46 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                                                                                                               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-email", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                                                                                          WriteLiteral(item.Email);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-email", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>");
#nullable restore
#line 48 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.RegisteredDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n");
#nullable restore
#line 50 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                                 if (item.LastLogin != new DateTime())
                                                {
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.LastLogin));

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                                                                                 
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\r\n                                            <td>");
#nullable restore
#line 55 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.TotalCourses));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 56 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.TotalCertifications));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d796e092c29b057fa904bd4c8b7463d4a2ed7fc615380", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                <div class=""dropdown mb-2"">
                                                    <button class=""btn p-0"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                                        <i class=""icon-lg text-muted pb-3px"" data-feather=""more-horizontal""></i>
                                                    </button>
                                                    <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                                                        <a class=""dropdown-item d-flex align-items-center"" href=""#""");
            BeginWriteAttribute("onclick", " onclick=\"", 3931, "\"", 4016, 6);
            WriteAttributeValue("", 3941, "BlockUser(\'", 3941, 11, true);
#nullable restore
#line 64 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
WriteAttributeValue("", 3952, item.Email, 3952, 11, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
WriteAttributeValue(" ", 3963, item.StudentNumber, 3964, 19, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
WriteAttributeValue(" ", 3983, item.FirstName, 3984, 15, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
WriteAttributeValue(" ", 3999, item.LastName, 4000, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4014, "\')", 4014, 2, true);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#unblockStudentModal\"><i data-feather=\"user-check\" class=\"icon-sm mr-2\"></i> <span");
            BeginWriteAttribute("class", " class=\"", 4133, "\"", 4141, 0);
            EndWriteAttribute();
            WriteLiteral(">Unblock</span></a>\r\n                                                    </div>\r\n                                                </div>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 69 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 79 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-lg-12 col-xl-12 grid-margin stretch-card"">
            <div class=""card"">
                <div class=""card-body"">

                    <div class=""table-responsive"">
                        <table class=""table table-hover mb-0 "" id=""dataTableExample"">
                            <thead>
                                <tr>
                                    <th class=""pt-0"">Student Id</th>
                                    <th class=""pt-0"">Full Name</th>
                                    <th class=""pt-0"">Email</th>
                                    <th class=""pt-0"">Reg. Date</th>
                                    <th class=""pt-0"">Last Login</th>
                                    <th class=""pt-0"">Total Courses</th>
                                    <th class=""pt-0"">Total Certs</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 101 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                 if (Model != null && Model.RegisteredStudents.Count > 0)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                     foreach (var item in Model.RegisteredStudents)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d796e092c29b057fa904bd4c8b7463d4a2ed7fc621537", async() => {
                WriteLiteral(" ");
#nullable restore
#line 107 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                                                                                                               Write(Html.DisplayFor(modelItem => item.StudentNumber));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-email", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 107 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                                                                                          WriteLiteral(item.Email);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-email", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>");
#nullable restore
#line 109 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 109 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d796e092c29b057fa904bd4c8b7463d4a2ed7fc625138", async() => {
                WriteLiteral(" ");
#nullable restore
#line 111 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                                                                                                               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-email", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                                                                                          WriteLiteral(item.Email);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-email", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>");
#nullable restore
#line 113 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.RegisteredDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n");
#nullable restore
#line 115 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                                 if (item.LastLogin != new DateTime())
                                                {
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.LastLogin));

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                                                                                 
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\r\n                                            <td>");
#nullable restore
#line 120 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.TotalCourses));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 121 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.TotalCertifications));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            \r\n                                        </tr>\r\n");
#nullable restore
#line 124 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 134 "C:\Users\CAROLINE\source\repos\CPEA\CPEA\Views\Admin\BlockedStudents.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    function BlockUser(g) {
        if (g != null) {
            var fields = g.split(' ');

            document.getElementById('studentEmail').value = fields[0];
            document.getElementById('studentEmailR').value = fields[0];
            document.getElementById('studentNumber').value = fields[1];
            document.getElementById('studentName').value = fields[2] + "" "" + fields[3];
        }
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CPEA.Utilities.ViewModel.RegisteredStudentsVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
