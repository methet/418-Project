#pragma checksum "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/MyWebApp/418FinalProject/Views/Question/DeleteQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36610f52090402a2db0d1020fec4e743cd045275"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Question_DeleteQuestion), @"mvc.1.0.view", @"/Views/Question/DeleteQuestion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Question/DeleteQuestion.cshtml", typeof(AspNetCore.Views_Question_DeleteQuestion))]
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
#line 1 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/MyWebApp/418FinalProject/Views/_ViewImports.cshtml"
using _418FinalProject;

#line default
#line hidden
#line 3 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/MyWebApp/418FinalProject/Views/Question/DeleteQuestion.cshtml"
using _418FinalProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36610f52090402a2db0d1020fec4e743cd045275", @"/Views/Question/DeleteQuestion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"721d5ce7967c8a32a9a4be2e1dc36f2f03d72a1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Question_DeleteQuestion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Question>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteQuestion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditQuestion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(81, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/MyWebApp/418FinalProject/Views/Question/DeleteQuestion.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(125, 223, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n<h2>Are you sure you would like to delete the following question and all its data?</h2>\r\n<hr/>\r\n<div>\r\n    <h4>Questions</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(349, 46, false);
#line 18 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/MyWebApp/418FinalProject/Views/Question/DeleteQuestion.cshtml"
       Write(Html.DisplayNameFor(model => model.QuestionID));

#line default
#line hidden
            EndContext();
            BeginContext(395, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(457, 42, false);
#line 21 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/MyWebApp/418FinalProject/Views/Question/DeleteQuestion.cshtml"
       Write(Html.DisplayFor(model => model.QuestionID));

#line default
#line hidden
            EndContext();
            BeginContext(499, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(560, 48, false);
#line 24 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/MyWebApp/418FinalProject/Views/Question/DeleteQuestion.cshtml"
       Write(Html.DisplayNameFor(model => model.QuestionText));

#line default
#line hidden
            EndContext();
            BeginContext(608, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(670, 44, false);
#line 27 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/MyWebApp/418FinalProject/Views/Question/DeleteQuestion.cshtml"
       Write(Html.DisplayFor(model => model.QuestionText));

#line default
#line hidden
            EndContext();
            BeginContext(714, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(775, 47, false);
#line 30 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/MyWebApp/418FinalProject/Views/Question/DeleteQuestion.cshtml"
       Write(Html.DisplayNameFor(model => model.Answer1Text));

#line default
#line hidden
            EndContext();
            BeginContext(822, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(884, 43, false);
#line 33 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/MyWebApp/418FinalProject/Views/Question/DeleteQuestion.cshtml"
       Write(Html.DisplayFor(model => model.Answer1Text));

#line default
#line hidden
            EndContext();
            BeginContext(927, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(988, 47, false);
#line 36 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/MyWebApp/418FinalProject/Views/Question/DeleteQuestion.cshtml"
       Write(Html.DisplayNameFor(model => model.Answer2Text));

#line default
#line hidden
            EndContext();
            BeginContext(1035, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1097, 43, false);
#line 39 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/MyWebApp/418FinalProject/Views/Question/DeleteQuestion.cshtml"
       Write(Html.DisplayFor(model => model.Answer2Text));

#line default
#line hidden
            EndContext();
            BeginContext(1140, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1201, 47, false);
#line 42 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/MyWebApp/418FinalProject/Views/Question/DeleteQuestion.cshtml"
       Write(Html.DisplayNameFor(model => model.Answer3Text));

#line default
#line hidden
            EndContext();
            BeginContext(1248, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1310, 43, false);
#line 45 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/MyWebApp/418FinalProject/Views/Question/DeleteQuestion.cshtml"
       Write(Html.DisplayFor(model => model.Answer3Text));

#line default
#line hidden
            EndContext();
            BeginContext(1353, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1414, 47, false);
#line 48 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/MyWebApp/418FinalProject/Views/Question/DeleteQuestion.cshtml"
       Write(Html.DisplayNameFor(model => model.Answer4Text));

#line default
#line hidden
            EndContext();
            BeginContext(1461, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1523, 43, false);
#line 51 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/MyWebApp/418FinalProject/Views/Question/DeleteQuestion.cshtml"
       Write(Html.DisplayFor(model => model.Answer4Text));

#line default
#line hidden
            EndContext();
            BeginContext(1566, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1627, 44, false);
#line 54 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/MyWebApp/418FinalProject/Views/Question/DeleteQuestion.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1671, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1733, 40, false);
#line 57 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/MyWebApp/418FinalProject/Views/Question/DeleteQuestion.cshtml"
       Write(Html.DisplayFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1773, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1834, 41, false);
#line 60 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/MyWebApp/418FinalProject/Views/Question/DeleteQuestion.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(1875, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1937, 37, false);
#line 63 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/MyWebApp/418FinalProject/Views/Question/DeleteQuestion.cshtml"
       Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(1974, 36, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
            EndContext();
            BeginContext(2010, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36610f52090402a2db0d1020fec4e743cd04527513108", async() => {
                BeginContext(2044, 40, true);
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(2084, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "36610f52090402a2db0d1020fec4e743cd04527513530", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 69 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/MyWebApp/418FinalProject/Views/Question/DeleteQuestion.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.QuestionID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2128, 86, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-primary\" />\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2221, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2234, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36610f52090402a2db0d1020fec4e743cd04527516739", async() => {
                BeginContext(2296, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/MyWebApp/418FinalProject/Views/Question/DeleteQuestion.cshtml"
                                   WriteLiteral(Model.QuestionID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2304, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2312, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36610f52090402a2db0d1020fec4e743cd04527519097", async() => {
                BeginContext(2334, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2350, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Question> Html { get; private set; }
    }
}
#pragma warning restore 1591