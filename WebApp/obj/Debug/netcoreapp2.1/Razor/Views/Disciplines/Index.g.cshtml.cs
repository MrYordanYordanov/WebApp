#pragma checksum "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Disciplines\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f4532783882a93462b210a4882e62a0c769d1fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Disciplines_Index), @"mvc.1.0.view", @"/Views/Disciplines/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Disciplines/Index.cshtml", typeof(AspNetCore.Views_Disciplines_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f4532783882a93462b210a4882e62a0c769d1fe", @"/Views/Disciplines/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Disciplines_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp.Models.ViewModels.Discipline>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Disciplines\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 37, true);
            WriteLiteral("\r\n<h2>Disciplines</h2>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(137, 783, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4b39171e6b64e4080d1600c59937ab8", async() => {
                BeginContext(163, 750, true);
                WriteLiteral(@"
        <label for=""Name"">Name:</label>
        <div class=""form-group mx-sm-3 mb-2"">
            <input type=""text"" class=""form-control"" id=""disciplineName"" placeholder=""Name"">
        </div>
        <label for=""ProfessorName"">ProfessorName:</label>
        <div class=""form-group mx-sm-3 mb-2"">
            <input type=""text"" class=""form-control"" id=""disciplineProfessorName"" placeholder=""ProfessorName"">
        </div>
        <label for=""Score"">Score:</label>
        <div class=""form-group mx-sm-3 mb-2"">
            <input type=""number"" class=""form-control"" min=""0"" value=""0"" step="".5"" id=""disciplineScore"">
        </div>
        <button type=""button"" id=""create"" class=""btn btn-primary mb-2"">Create new descipline</button>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(920, 123, true);
            WriteLiteral("\r\n</div>\r\n<br />\r\n<table class=\"table\" id=\"disciplinesGrid\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1044, 38, false);
#line 31 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Disciplines\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1082, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1138, 40, false);
#line 34 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Disciplines\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1178, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1234, 49, false);
#line 37 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Disciplines\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProfessorName));

#line default
#line hidden
            EndContext();
            BeginContext(1283, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1339, 41, false);
#line 40 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Disciplines\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Score));

#line default
#line hidden
            EndContext();
            BeginContext(1380, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 46 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Disciplines\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1515, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1576, 37, false);
#line 50 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Disciplines\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1613, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1681, 39, false);
#line 53 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Disciplines\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1720, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1788, 48, false);
#line 56 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Disciplines\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProfessorName));

#line default
#line hidden
            EndContext();
            BeginContext(1836, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1904, 40, false);
#line 59 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Disciplines\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Score));

#line default
#line hidden
            EndContext();
            BeginContext(1944, 214, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <button type=\"button\" name=\"editBtn\" onclick=\"editBtn(this)\" class=\"btn btn-warning mb-2\">Edit</button>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 65 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Disciplines\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2169, 28, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2214, 4040, true);
                WriteLiteral(@"
    <script type=""text/javascript"">

        function saveBtn(result) {
            var childrens = $(result).parent().parent().children();
            var nameinput = $(childrens[1]).children();
            var prinput = $(childrens[2]).children();
            var scoreinput = $(childrens[3]).children();
            var disEditName = $(nameinput[0]).val();
            var disEditPrName = $(prinput[0]).val();
            var disEditPrScore = $(scoreinput[0]).val();


            var id = $(childrens[0]).text();
            $.ajax(
                {
                    type: ""PUT"", //HTTP PUT Method
                    url: ""Disciplines/Edit"", // Controller/View
                    data: { //Passing data
                        Id: id,
                        Name: disEditName, //Reading text box values using Jquery
                        ProfessorName: disEditPrName,
                        Score: disEditPrScore
                    },
                    success: function (result) {
                WriteLiteral(@"
                        $(childrens[1]).empty()
                            .append(`<td>${result.name}</td>`);
                        $(childrens[2]).empty()
                            .append(`<td>${result.professorName}</td>`);
                        $(childrens[3]).empty()
                            .append(`<td>${result.score.toFixed(2)}</td>`);
                        $(childrens[4]).empty()
                            .append(`<button type=""button"" onclick=""editBtn($(this))"" class=""btn btn-warning mb-2"">Edit</button>`);
                    }
                });
        };


        function editBtn(result) {

            var childrens = $(result).parent().parent().children();
            var disName = $(childrens[1]).text().trim();
            var disPrName = $(childrens[2]).text().trim();
            var disScore = $(childrens[3]).text().trim();

            $(childrens[1]).empty()
                .append(`<input type=""text"" class=""form-control"" value=""${disName}"" id=""disName");
                WriteLiteral(@"Edit"" placeholder=""Name"">`)
            $(childrens[2]).empty()
                .append(`<input type=""text"" class=""form-control"" value=""${disPrName}"" id=""disPrNameEdit"" placeholder=""ProfessorName"">`)
            $(childrens[3]).empty()
                .append(`<input type=""number""  min=""0""  step="".5"" class=""form-control"" value=""${disScore}"" id=""disScoreEdit"">`)
            $(childrens[4]).empty()
                .append(`<button  onclick=""saveBtn($(this))"" type=""button"" name=""saveBtn"" class=""btn btn-success mb-2"">Save</button>`)
        };



        $(document).ready(function () {
            $('#create').click(function () {
                disciplineName = $('#disciplineName').val();
                disciplineProfessorName = $('#disciplineProfessorName').val();
                disciplineScore= $('#disciplineScore').val();

                $.ajax(
                    {
                        type: ""POST"", //HTTP POST Method
                        url: ""Disciplines/Create"", // Controller");
                WriteLiteral(@"/View
                        data: { //Passing data
                            Name: disciplineName, //Reading text box values using Jquery
                            ProfessorName: disciplineProfessorName,
                            Score: disciplineScore
                        },
                        success: function (result) {
                            $('#disciplinesGrid > tbody:last')
                                .append(`<tr><td>${result.id}</td><td>${result.name}</td><td>${result.professorName}</td><td>${result.score.toFixed(2)}</td><td>
                        <button type=""button"" onclick=""editBtn(this)""  name=""editBtn"" class=""btn btn-warning mb-2"">Edit</button></td></tr>`);
                        }
                    });

                $('#disciplineName').val('');
                $('#disciplineProfessorName').val('');
                $('#disciplineScore').val('');
            })
        });
    </script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp.Models.ViewModels.Discipline>> Html { get; private set; }
    }
}
#pragma warning restore 1591