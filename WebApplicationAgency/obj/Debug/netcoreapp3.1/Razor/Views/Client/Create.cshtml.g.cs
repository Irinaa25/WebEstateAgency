#pragma checksum "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Client\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96023503f1bb6b6ec555b996216a2520fd1c291e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Create), @"mvc.1.0.view", @"/Views/Client/Create.cshtml")]
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
#line 1 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\_ViewImports.cshtml"
using WebApplicationAgency;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\_ViewImports.cshtml"
using WebApplicationAgency.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96023503f1bb6b6ec555b996216a2520fd1c291e", @"/Views/Client/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea7edbf78383d6b882fae983ff96c92ebc69b7f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Business.Interop.Data.ClientDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Client", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Client\Create.cshtml"
  
    ViewData["Title"] = "Добавление клиента";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96023503f1bb6b6ec555b996216a2520fd1c291e4691", async() => {
                WriteLiteral("\r\n    <h4>Создание клиента</h4>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96023503f1bb6b6ec555b996216a2520fd1c291e4986", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Client\Create.cshtml"
         if(Model != null)
        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("        <input type=\"hidden\" name=\"Id\"");
                    BeginWriteAttribute("value", " value=\"", 311, "\"", 328, 1);
#nullable restore
#line 15 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Client\Create.cshtml"
WriteAttributeValue("", 319, Model.Id, 319, 9, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></input>\r\n");
#nullable restore
#line 16 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Client\Create.cshtml"
        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("        <table class=\"table\">\r\n            <tr>\r\n                <td>ФИО клиента:</td>\r\n                <td><input type=\"text\" required name=\"FullName\"");
                    BeginWriteAttribute("value", " value=\"", 502, "\"", 526, 1);
#nullable restore
#line 20 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Client\Create.cshtml"
WriteAttributeValue("", 510, Model?.FullName, 510, 16, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td>Телефон:</td>\r\n                <td><input type=\"text\" required name=\"Phone\"");
                    BeginWriteAttribute("value", " value=\"", 669, "\"", 690, 1);
#nullable restore
#line 24 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Client\Create.cshtml"
WriteAttributeValue("", 677, Model?.Phone, 677, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" /></td>\r\n            </tr>\r\n           \r\n        </table>\r\n        <input type=\"submit\" value=\"Создать\" />\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Business.Interop.Data.ClientDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
