#pragma checksum "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Semesters\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db5f44bddaed33298f41318698aebf763943d6df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Semesters_Index), @"mvc.1.0.view", @"/Views/Semesters/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Semesters/Index.cshtml", typeof(AspNetCore.Views_Semesters_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db5f44bddaed33298f41318698aebf763943d6df", @"/Views/Semesters/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Semesters_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp.Models.ViewModels.Semester>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/semestersIndex.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Semesters\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 55, true);
            WriteLiteral("\r\n<h2>Semesters</h2>\r\n\r\n<br />\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(154, 18, false);
#line 11 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Semesters\Index.cshtml"
Write(ViewBag.Validation);

#line default
#line hidden
            EndContext();
            BeginContext(172, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            BeginContext(182, 1130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f524c941a3c44ede8ff1dedb30fd7fb9", async() => {
                BeginContext(188, 1117, true);
                WriteLiteral(@"
    <div class=""form-row"">
        <div class=""form-group col-md-3"">
            <label for=""Name"">Name</label>
            <input type=""text"" class=""form-control is-valid"" id=""semName"" placeholder=""Name"">
            <div class=""hidden"" id=""nameVMessage"">
            </div>
        </div>
        <div class=""form-group col-md-3"">
            <label for=""StartDate"">Start Date</label>
            <input type=""date"" class=""form-control"" id=""semStartDate"" placeholder=""endDate"">
            <div class=""hidden"" id=""startDVMessage"">
            </div>
        </div>
        <div class=""form-group col-md-3"">
            <label for=""EndDate"">End Date</label>
            <input type=""date"" class=""form-control"" id=""semEndDate"" placeholder=""endDate"">
            <div class=""hidden"" id=""endDVMessage"">
            </div>
        </div>
        <div class=""form-group col-md-3"">
            <label for=""button""></label>
            <div>
                <button type=""button"" id=""create"" class=""btn btn");
                WriteLiteral("-primary mb-2\">Create new semester</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1312, 118, true);
            WriteLiteral("\r\n\r\n<br />\r\n<br />\r\n<table class=\"table\" id=\"semsGrid\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1431, 38, false);
#line 48 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Semesters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1469, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1525, 40, false);
#line 51 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Semesters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1565, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1621, 45, false);
#line 54 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Semesters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(1666, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1722, 43, false);
#line 57 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Semesters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1765, 124, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Action\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 65 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Semesters\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1938, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1999, 37, false);
#line 69 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Semesters\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2036, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2104, 39, false);
#line 72 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Semesters\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2143, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2211, 44, false);
#line 75 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Semesters\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(2255, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2323, 42, false);
#line 78 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Semesters\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(2365, 194, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <button type=\"button\" name=\"editBtn\" onclick=\"editBtn(this)\" class=\"btn btn-warning mb-2\">Edit</button>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2559, "\"", 2593, 2);
            WriteAttributeValue("", 2566, "/Semesters/Details/", 2566, 19, true);
#line 82 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Semesters\Index.cshtml"
WriteAttributeValue("", 2585, item.Id, 2585, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2594, 100, true);
            WriteLiteral(" class=\"btn btn-info\" role=\"button\">View Disciplines</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 85 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Semesters\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2705, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2748, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2754, 72, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14460708e7534955a7eef4d3821c2423", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 90 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Semesters\Index.cshtml"
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
                BeginContext(2826, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp.Models.ViewModels.Semester>> Html { get; private set; }
    }
}
#pragma warning restore 1591
