#pragma checksum "D:\AspCore\DictionaryApp\DictionaryApp\DictionaryApp\Views\Home\UnPublished.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e6c309cb06b6e8eece3b31fcdb558351f69b3b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UnPublished), @"mvc.1.0.view", @"/Views/Home/UnPublished.cshtml")]
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
#line 1 "D:\AspCore\DictionaryApp\DictionaryApp\DictionaryApp\Views\_ViewImports.cshtml"
using DictionaryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AspCore\DictionaryApp\DictionaryApp\DictionaryApp\Views\_ViewImports.cshtml"
using DictionaryApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e6c309cb06b6e8eece3b31fcdb558351f69b3b2", @"/Views/Home/UnPublished.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e5a7ded9b615df01bb231983bcb9ef08c52e73d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UnPublished : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DictionaryApp.Models.Word>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManageWord", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Publish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\AspCore\DictionaryApp\DictionaryApp\DictionaryApp\Views\Home\UnPublished.cshtml"
  
    ViewData["Title"] = "UnPublished";
    string noun = "";
    string pro_noun = "";
    string bangla = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>UnPublished List</h1>\r\n<hr />\r\n<div class=\"container word-table\">\r\n    <h4 class=\"text-secondary\">Word List (Total Unpublished Words - <span class=\"totalWord\">");
#nullable restore
#line 13 "D:\AspCore\DictionaryApp\DictionaryApp\DictionaryApp\Views\Home\UnPublished.cshtml"
                                                                                       Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>)</h4>
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Word
                </th>
                <th>
                    Translation
                </th>
                <th>
                    Noun
                </th>

                <th>
                    Pro-Noun
                </th>

                <th>
                    Marked
                </th>
                <th>
                    IsPublished
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 41 "D:\AspCore\DictionaryApp\DictionaryApp\DictionaryApp\Views\Home\UnPublished.cshtml"
             foreach (var item in Model)

            {
                noun = "";
                pro_noun = "";
                bangla = "";
                string newNoun = "";
                string newProNoun = "";
                string newbangla = "";
                if (item.nouns != null && item.nouns.Count() > 0)
                {
                    foreach (var nounItem in item.nouns)
                    {
                        noun += nounItem.NounMappingWord.text + ", ";
                    }
                    newNoun = noun.Substring(0, noun.Length - 2);
                }
                if (item.proNouns != null && item.proNouns.Count() > 0)
                {
                    foreach (var proNounItem in item.proNouns)
                    {
                        pro_noun += proNounItem.ProNounMappingWord.text + ", ";
                    }
                    newProNoun = pro_noun.Substring(0, pro_noun.Length - 2);
                }
                if (item.banglaWordMappings != null && item.banglaWordMappings.Count() > 0)
                {
                    foreach (var banglaItem in item.banglaWordMappings)
                    {
                        bangla += banglaItem.banglaWord.text + ", ";
                    }
                    newbangla = bangla.Substring(0, bangla.Length - 2);
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 76 "D:\AspCore\DictionaryApp\DictionaryApp\DictionaryApp\Views\Home\UnPublished.cshtml"
                   Write(Html.DisplayFor(modelItem => item.text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 79 "D:\AspCore\DictionaryApp\DictionaryApp\DictionaryApp\Views\Home\UnPublished.cshtml"
                   Write(newbangla);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 82 "D:\AspCore\DictionaryApp\DictionaryApp\DictionaryApp\Views\Home\UnPublished.cshtml"
                   Write(newNoun);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 85 "D:\AspCore\DictionaryApp\DictionaryApp\DictionaryApp\Views\Home\UnPublished.cshtml"
                   Write(newProNoun);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>");
#nullable restore
#line 88 "D:\AspCore\DictionaryApp\DictionaryApp\DictionaryApp\Views\Home\UnPublished.cshtml"
                   Write(item.Mark);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 90 "D:\AspCore\DictionaryApp\DictionaryApp\DictionaryApp\Views\Home\UnPublished.cshtml"
                   Write(item.IsPublished);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e6c309cb06b6e8eece3b31fcdb558351f69b3b28956", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-word", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "D:\AspCore\DictionaryApp\DictionaryApp\DictionaryApp\Views\Home\UnPublished.cshtml"
                                                       WriteLiteral(item.text);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["word"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-word", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["word"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e6c309cb06b6e8eece3b31fcdb558351f69b3b211162", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "D:\AspCore\DictionaryApp\DictionaryApp\DictionaryApp\Views\Home\UnPublished.cshtml"
                                                 WriteLiteral(item.WordId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n                       \r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e6c309cb06b6e8eece3b31fcdb558351f69b3b213386", async() => {
                WriteLiteral("Publish");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-word", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "D:\AspCore\DictionaryApp\DictionaryApp\DictionaryApp\Views\Home\UnPublished.cshtml"
                                                        WriteLiteral(item.text);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["word"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-word", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["word"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        \r\n\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 104 "D:\AspCore\DictionaryApp\DictionaryApp\DictionaryApp\Views\Home\UnPublished.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DictionaryApp.Models.Word>> Html { get; private set; }
    }
}
#pragma warning restore 1591
