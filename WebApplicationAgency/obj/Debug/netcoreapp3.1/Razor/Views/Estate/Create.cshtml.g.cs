#pragma checksum "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fba382265d457c27b94efda6c453ba2f5870365"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estate_Create), @"mvc.1.0.view", @"/Views/Estate/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fba382265d457c27b94efda6c453ba2f5870365", @"/Views/Estate/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea7edbf78383d6b882fae983ff96c92ebc69b7f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Estate_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Business.Interop.Data.EstateDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Estate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
  
    ViewData["Title"] = "Добавление объекта недвижимости";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fba382265d457c27b94efda6c453ba2f58703654836", async() => {
                WriteLiteral("\r\n    <h4>Создание объекта недвижимости</h4>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fba382265d457c27b94efda6c453ba2f58703655144", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
         if (Model != null)
        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("            <input type=\"hidden\" name=\"Id\"");
                    BeginWriteAttribute("value", " value=\"", 342, "\"", 359, 1);
#nullable restore
#line 15 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
WriteAttributeValue("", 350, Model.Id, 350, 9, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></input>\r\n");
#nullable restore
#line 16 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("    <table class=\"table\">\r\n        <tr>\r\n            <td>Название:</td>\r\n            <td><input type=\"text\" required name=\"Name\"");
                    BeginWriteAttribute("value", " value=\"", 510, "\"", 530, 1);
#nullable restore
#line 20 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
WriteAttributeValue("", 518, Model?.Name, 518, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" /></td>\r\n        </tr>\r\n        <tr>\r\n            <td>Тип недвижимости:</td>\r\n            <td><select name=\"EstateTypeId\" required>\r\n");
#nullable restore
#line 25 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
                 foreach(var estateType in ViewBag.EstateTypes)
                {
                if (Model?.EstateType.Id == estateType.Id)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fba382265d457c27b94efda6c453ba2f58703657481", async() => {
#nullable restore
#line 29 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
                                                   Write(estateType.Name);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
                   WriteLiteral(estateType.Id);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fba382265d457c27b94efda6c453ba2f587036510112", async() => {
#nullable restore
#line 33 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
                                          Write(estateType.Name);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
                   WriteLiteral(estateType.Id);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 34 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
                }
                }

#line default
#line hidden
#nullable disable
                    WriteLiteral("            </select>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>Клиент:</td>\r\n            <td>\r\n                <select name=\"ClientId\" required>\r\n");
#nullable restore
#line 43 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
                     foreach (var client in ViewBag.Clients)
                    {
                        if (Model?.Client.Id == client.Id)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fba382265d457c27b94efda6c453ba2f587036512974", async() => {
#nullable restore
#line 47 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
                                                           Write(client.FullName);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
                               WriteLiteral(client.Id);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fba382265d457c27b94efda6c453ba2f587036515658", async() => {
#nullable restore
#line 51 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
                                                  Write(client.FullName);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
                               WriteLiteral(client.Id);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 52 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                </select>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>Цена:</td>\r\n            <td><input type=\"text\" required name=\"Price\"");
                    BeginWriteAttribute("value", " value=\"", 1891, "\"", 1912, 1);
#nullable restore
#line 59 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
WriteAttributeValue("", 1899, Model?.Price, 1899, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" /></td>\r\n        </tr>\r\n        <tr>\r\n            <td>Площадь:</td>\r\n            <td><input type=\"text\" required name=\"Area\"");
                    BeginWriteAttribute("value", " value=\"", 2038, "\"", 2058, 1);
#nullable restore
#line 63 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
WriteAttributeValue("", 2046, Model?.Area, 2046, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" /></td>\r\n        </tr>\r\n        <tr>\r\n            <td>Год постройки:</td>\r\n            <td><input type=\"text\" required name=\"YearOfConsruction\"");
                    BeginWriteAttribute("value", " value=\"", 2203, "\"", 2236, 1);
#nullable restore
#line 67 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
WriteAttributeValue("", 2211, Model?.YearOfConsruction, 2211, 25, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" /></td>\r\n        </tr>\r\n        <tr>\r\n            <td>Количество комнат:</td>\r\n            <td><input type=\"text\" required name=\"RoomsCount\"");
                    BeginWriteAttribute("value", " value=\"", 2378, "\"", 2404, 1);
#nullable restore
#line 71 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
WriteAttributeValue("", 2386, Model?.RoomsCount, 2386, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" /></td>\r\n        </tr>\r\n        <tr>\r\n            <td>Количество этажей:</td>\r\n            <td><input type=\"text\" required name=\"FloorsCount\"");
                    BeginWriteAttribute("value", " value=\"", 2547, "\"", 2574, 1);
#nullable restore
#line 75 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
WriteAttributeValue("", 2555, Model?.FloorsCount, 2555, 19, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" /></td>\r\n        </tr>\r\n        <tr>\r\n            <td>Улица:</td>\r\n            <td>\r\n                <select name=\"StreetId\" required>\r\n");
#nullable restore
#line 81 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
                     foreach (var street in ViewBag.Streets)
                    {
                        if (Model?.Street.Id == street.Id)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fba382265d457c27b94efda6c453ba2f587036521388", async() => {
#nullable restore
#line 85 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
                                                           Write(street.Name);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
                               WriteLiteral(street.Id);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 86 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fba382265d457c27b94efda6c453ba2f587036524068", async() => {
#nullable restore
#line 89 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
                                                  Write(street.Name);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
                               WriteLiteral(street.Id);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 90 "C:\Users\Ирина\OneDrive\Рабочий стол\WebApplicationAgency\WebApplicationAgency\Views\Estate\Create.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                </select>\r\n            </td>\r\n        </tr>\r\n\r\n    </table>\r\n        <input type=\"submit\" value=\"Создать\" />\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Business.Interop.Data.EstateDto> Html { get; private set; }
    }
}
#pragma warning restore 1591