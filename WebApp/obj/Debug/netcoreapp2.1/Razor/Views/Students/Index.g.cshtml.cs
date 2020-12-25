#pragma checksum "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1ef0be265e8e06cc2e4a3080b7395ccca220e11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Index.cshtml", typeof(AspNetCore.Views_Students_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1ef0be265e8e06cc2e4a3080b7395ccca220e11", @"/Views/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp.Models.ViewModels.Student>>
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 34, true);
            WriteLiteral("\r\n<h2>Students</h2>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(131, 730, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e78ddcddfd624f368253560f666598b3", async() => {
                BeginContext(157, 697, true);
                WriteLiteral(@"
        <label for=""Name"">Name:</label>
        <div class=""form-group mx-sm-3 mb-2"">
            <input type=""text"" class=""form-control"" id=""studentName"" placeholder=""Name"">
        </div>
        <label for=""Surname"">Surname:</label>
        <div class=""form-group mx-sm-3 mb-2"">
            <input type=""text"" class=""form-control"" id=""studentSurname"" placeholder=""Surname"">
        </div>
        <label for=""Dob"">DOB:</label>
        <div class=""form-group mx-sm-3 mb-2"">
            <input type=""date"" class=""form-control"" id=""studentDob""  placeholder=""Dob"">
        </div>
        <button type=""button"" id=""create"" class=""btn btn-primary mb-2"">Create new student</button>
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
            BeginContext(861, 120, true);
            WriteLiteral("\r\n</div>\r\n<br />\r\n<table class=\"table\" id=\"studentsGrid\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(982, 38, false);
#line 31 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1020, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1076, 40, false);
#line 34 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1116, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1172, 43, false);
#line 37 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(1215, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1271, 39, false);
#line 40 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Dob));

#line default
#line hidden
            EndContext();
            BeginContext(1310, 124, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Action\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 48 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1483, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1532, 37, false);
#line 52 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1569, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1625, 39, false);
#line 55 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1664, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1720, 42, false);
#line 58 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(1762, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1818, 38, false);
#line 61 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dob));

#line default
#line hidden
            EndContext();
            BeginContext(1856, 161, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <button type=\"button\" name=\"editBtn\"  onclick=\"editBtn(this)\" class=\"btn btn-warning mb-2\">Edit</button>\r\n");
            EndContext();
            BeginContext(2273, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 70 "C:\Users\ACER\source\repos\WebApp\WebApp\Views\Students\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2318, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2361, 4076, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        
        function saveBtn (result) {
            var childrens = $(result).parent().parent().children();
            var nameinput = $(childrens[1]).children();
            var surnameinput = $(childrens[2]).children();
            var dobinput = $(childrens[3]).children();
            var studentEditName = $(nameinput[0]).val();
            var studentEditSurname = $(surnameinput[0]).val();
            var studentEditDob = $(dobinput[0]).val();
            

            var id=$(childrens[0]).text();
            $.ajax(
                {
                    type: ""PUT"", //HTTP PUT Method
                    url: ""Students/Edit"", // Controller/View
                    data: { //Passing data
                        Id:id,
                        Name: studentEditName, //Reading text box values using Jquery
                        Surname: studentEditSurname,
                        Dob: studentEditDob
                    },
                  ");
                WriteLiteral(@"  success: function (result) {
                        $(childrens[1]).empty()
                            .append(`<td>${result.name}</td>`);
                        $(childrens[2]).empty()
                            .append(`<td>${result.surname}</td>`);
                        $(childrens[3]).empty()
                            .append(`<td>${result.dob.toString()}</td>`);
                        $(childrens[4]).empty()
                            .append(`<button type=""button"" onclick=""editBtn($(this))"" class=""btn btn-warning mb-2"">Edit</button>`);                      
                    }
                });
        };
       
       
        function editBtn(result) {

            var childrens = $(result).parent().parent().children();
            var studentName = $(childrens[1]).text().trim();
            var studentSurname = $(childrens[2]).text().trim();
            var studentDob = $(childrens[3]).text().trim();

            $(childrens[1]).empty()
                .append(`");
                WriteLiteral(@"<input type=""text"" class=""form-control"" value=""${studentName}"" id=""studentNameEdit"" placeholder=""Name"">`)
            $(childrens[2]).empty()
                .append(`<input type=""text"" class=""form-control"" value=""${studentSurname}"" id=""studentSurnameEdit"" placeholder=""Name"">`)
            $(childrens[3]).empty()
                .append(`<input type=""date"" class=""form-control"" value=""${studentDob}"" id=""studentDobEdit"" placeholder=""Date"">`)
            $(childrens[4]).empty()
                .append(`<button  onclick=""saveBtn($(this))"" type=""button"" name=""saveBtn"" class=""btn btn-success mb-2"">Save</button>`)            
            };

        
       
        $(document).ready(function () {
            $('#create').click(function () {
                studentName = $('#studentName').val();
                studentSurname = $('#studentSurname').val();
                studentDob = $('#studentDob').val();

                $.ajax(
                    {
                        type: ""POST"", //HTTP");
                WriteLiteral(@" POST Method
                        url: ""Students/Create"", // Controller/View
                        data: { //Passing data
                            Name: studentName, //Reading text box values using Jquery
                            Surname: studentSurname,
                            Dob:studentDob
                        },
                        success: function (result) {
                           
                            $('#studentsGrid > tbody:last')
                                .append(`<tr><td>${result.id}</td><td>${result.name}</td><td>${result.surname}</td><td>${result.dob}</td><td>
                    <button type=""button"" onclick=""editBtn(this)""   name=""editBtn"" class=""btn btn-warning mb-2"">Edit</button></td></tr>`);
                        }
                    });

                $('#studentName').val('');
                $('#studentSurname').val('');
                $('#studentDob').val('');
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp.Models.ViewModels.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
