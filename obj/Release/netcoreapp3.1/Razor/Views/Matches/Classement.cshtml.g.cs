#pragma checksum "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Classement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9421b2b346f5bd7abb3ea57897eba290ac2feadd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Matches_Classement), @"mvc.1.0.view", @"/Views/Matches/Classement.cshtml")]
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
#line 1 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\_ViewImports.cshtml"
using VolleyDamois;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\_ViewImports.cshtml"
using VolleyDamois.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Classement.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9421b2b346f5bd7abb3ea57897eba290ac2feadd", @"/Views/Matches/Classement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d22dbc4b75b9df700fdbb9af72bd2d66a362b00b", @"/Views/_ViewImports.cshtml")]
    public class Views_Matches_Classement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VolleyDamois.Models.ViewModel.ViewModelClassement>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateMatchDay2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/daySwitchButton.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/print.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Classement.cshtml"
  
    ViewData["Title"] = "Classement";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <button class=""btn-primary border-0 row float-right"" onclick=""printJS({
    printable: 'pdf',
    type: 'html',
    documentTitle: title,
    scanStyles: false,
    style: 'td, th { border-style: solid; border-width: thin; text-align: center; } h4, table, { width: 40px}, .notBreak{page-break-inside: avoid;}'})"">
        <svg class=""m-2"" width=""2em"" height=""2em"" viewBox=""0 0 16 16"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
            <path d=""M4 1h5v1H4a1 1 0 0 0-1 1v10a1 1 0 0 0 1 1h8a1 1 0 0 0 1-1V6h1v7a2 2 0 0 1-2 2H4a2 2 0 0 1-2-2V3a2 2 0 0 1 2-2z"" />
            <path d=""M9 4.5V1l5 5h-3.5A1.5 1.5 0 0 1 9 4.5z"" />
            <path fill-rule=""evenodd"" d=""M5 11.5a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 0 1h-2a.5.5 0 0 1-.5-.5zm0-2a.5.5 0 0 1 .5-.5h5a.5.5 0 0 1 0 1h-5a.5.5 0 0 1-.5-.5zm0-2a.5.5 0 0 1 .5-.5h5a.5.5 0 0 1 0 1h-5a.5.5 0 0 1-.5-.5z"" />
        </svg>
    </button>
    <div class=""pdf"">

        <h1>Classement</h1>

        <div>
            <label class=""control-label""");
            WriteLiteral(">Classement pour :</label>\r\n            <select onchange=\"DayHasChanged()\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9421b2b346f5bd7abb3ea57897eba290ac2feadd6200", async() => {
                WriteLiteral("Jour 1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
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
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9421b2b346f5bd7abb3ea57897eba290ac2feadd7485", async() => {
                WriteLiteral("Jour 2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </select>\r\n\r\n");
#nullable restore
#line 32 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Classement.cshtml"
             if (SignInManager.IsSignedIn(User))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9421b2b346f5bd7abb3ea57897eba290ac2feadd8750", async() => {
                WriteLiteral("\r\n                    <button class=\"btn-primary\">Creér les match pour le jour 2</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Classement.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div id=\"day1\">\r\n");
#nullable restore
#line 39 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Classement.cshtml"
                  
                    int i = 1;
                    foreach (var c1 in Model.classementDay1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h2>Poule ");
#nullable restore
#line 43 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Classement.cshtml"
                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <table class=""table table-dark table-striped "">
                            <thead>
                            <th scope=""col"">Place</th>
                            <th scope=""col"">Equipe</th>
                            <th scope=""col"">Points</th>
                            <th scope=""col"">Pour</th>
                            <th scope=""col"">Contre</th>
                            </thead>
                            <tbody>

");
#nullable restore
#line 54 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Classement.cshtml"
                                  int place = 1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Classement.cshtml"
                                 foreach (Team team in c1.Keys)
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 59 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Classement.cshtml"
                                       Write(place);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 60 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Classement.cshtml"
                                       Write(team.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 61 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Classement.cshtml"
                                       Write(c1[team][0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 62 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Classement.cshtml"
                                       Write(c1[team][1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 63 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Classement.cshtml"
                                       Write(c1[team][2]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 65 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Classement.cshtml"
                                    place++;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n");
#nullable restore
#line 70 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Classement.cshtml"
                        i++;
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div id=\"day2\">\r\n");
#nullable restore
#line 75 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Classement.cshtml"
                  
                    var keys = Model.classementDay2.Keys.ToList();
                    keys.Remove(LevelMatch.Poule);
                    foreach (var LevelKey in keys)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h2>");
#nullable restore
#line 80 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Classement.cshtml"
                       Write(LevelKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <table class=\"table table-dark table-striped \">\r\n                            <thead>\r\n                            <th>Equipe Victorieuses</th>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 86 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Classement.cshtml"
                                 foreach (Team team in Model.classementDay2[LevelKey])
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 89 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Classement.cshtml"
                                       Write(team.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 91 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Classement.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n");
#nullable restore
#line 94 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Classement.cshtml"
                        i++;
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9421b2b346f5bd7abb3ea57897eba290ac2feadd16852", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9421b2b346f5bd7abb3ea57897eba290ac2feadd17952", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            WriteLiteral("\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VolleyDamois.Models.ViewModel.ViewModelClassement> Html { get; private set; }
    }
}
#pragma warning restore 1591
