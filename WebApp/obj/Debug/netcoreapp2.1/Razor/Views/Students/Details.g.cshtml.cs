#pragma checksum "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d32f0138d9fa01aa968209117cace3716925ca1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Details), @"mvc.1.0.view", @"/Views/Students/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Details.cshtml", typeof(AspNetCore.Views_Students_Details))]
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
#line 1 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#line 2 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d32f0138d9fa01aa968209117cace3716925ca1", @"/Views/Students/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp.Models.ViewModels.StudentSemesters>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/studentsDetails.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(95, 43, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Name: ");
            EndContext();
            BeginContext(139, 18, false);
#line 10 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Details.cshtml"
         Write(Model.Student.Name);

#line default
#line hidden
            EndContext();
            BeginContext(157, 24, true);
            WriteLiteral("</h4>\r\n    <h5>Surname: ");
            EndContext();
            BeginContext(182, 21, false);
#line 11 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Details.cshtml"
            Write(Model.Student.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(203, 20, true);
            WriteLiteral("</h5>\r\n    <h5>DOB: ");
            EndContext();
            BeginContext(224, 17, false);
#line 12 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Details.cshtml"
        Write(Model.Student.Dob);

#line default
#line hidden
            EndContext();
            BeginContext(241, 110, true);
            WriteLiteral("</h5>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\"></dl>\r\n    <div id=\"studId\" style=\"display: none;\">\r\n        ");
            EndContext();
            BeginContext(352, 16, false);
#line 16 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Details.cshtml"
   Write(Model.Student.Id);

#line default
#line hidden
            EndContext();
            BeginContext(368, 33, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(401, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a00918d95854c8085a7890a56233a50", async() => {
                BeginContext(423, 16, true);
                WriteLiteral("Back to students");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(443, 680, true);
            WriteLiteral(@"
</div>
<br />

<button class=""btn btn-primary"" type=""button"" data-toggle=""collapse"" data-target=""#collapseExample"" aria-expanded=""false"" aria-controls=""collapseExample"">
    Show semesters
</button>

<div class=""collapse"" id=""collapseExample"">
    <table class=""table"" id=""semsstud"">
        <thead>
            <tr>
                <th>
                    Name
                </th>
                <th>
                    Start Date
                </th>
                <th>
                    End Date
                </th>
                <th>
                    Action
                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 47 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Details.cshtml"
             foreach (var sem in Model.Semesters)
            {

#line default
#line hidden
            BeginContext(1189, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1262, 38, false);
#line 51 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => sem.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1300, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1380, 43, false);
#line 54 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => sem.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(1423, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1503, 41, false);
#line 57 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => sem.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1544, 81, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1625, "\"", 1658, 2);
            WriteAttributeValue("", 1632, "/Semesters/Details/", 1632, 19, true);
#line 60 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Details.cshtml"
WriteAttributeValue("", 1651, sem.Id, 1651, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1659, 108, true);
            WriteLiteral(" class=\"btn btn-info\" role=\"button\">View Disciplines</a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 63 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(1782, 454, true);
            WriteLiteral(@"        </tbody>
    </table>
</div>


<br />
<br />

<h4>Available disciplines</h4>

<table class=""table"" id=""availableSem"">
    <thead>
        <tr>
            <th>
                Name
            </th>
            <th>
                Start Date
            </th>
            <th>
                End Date
            </th>
            <th>
                Action
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 92 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Details.cshtml"
         foreach (var sem in Model.AvailableSemesters)
        {

#line default
#line hidden
            BeginContext(2303, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2364, 8, false);
#line 96 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Details.cshtml"
               Write(sem.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2372, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2440, 13, false);
#line 99 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Details.cshtml"
               Write(sem.StartDate);

#line default
#line hidden
            EndContext();
            BeginContext(2453, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2521, 11, false);
#line 102 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Details.cshtml"
               Write(sem.EndDate);

#line default
#line hidden
            EndContext();
            BeginContext(2532, 304, true);
            WriteLiteral(@"
                </td>
                <td>
                    <button type=""button"" name=""addBtn"" onclick=""addBtn(this)"" class=""btn btn-success mb-2"">Add</button>
                </td>
                <td>
                    <div id=""availDisId"" style=""display: none;"">
                        ");
            EndContext();
            BeginContext(2837, 6, false);
#line 109 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Details.cshtml"
                   Write(sem.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2843, 72, true);
            WriteLiteral("\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 113 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(2926, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2969, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2975, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad5c41ca3f514eb286848cf6c7fcc78c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 118 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3048, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Models.ViewModels.StudentSemesters> Html { get; private set; }
    }
}
#pragma warning restore 1591
