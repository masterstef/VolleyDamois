#pragma checksum "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e7d247f8ca679bcb7cdae9820357de0c0c6de8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Matches_Result), @"mvc.1.0.view", @"/Views/Matches/Result.cshtml")]
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
#line 1 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e7d247f8ca679bcb7cdae9820357de0c0c6de8d", @"/Views/Matches/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d22dbc4b75b9df700fdbb9af72bd2d66a362b00b", @"/Views/_ViewImports.cshtml")]
    public class Views_Matches_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VolleyDamois.Models.ViewModelMatches>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateMatches", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/print.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
  
    ViewData["Title"] = "Result";

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
<div id=""pdf"">

    <h1>Résultats</h1>
");
#nullable restore
#line 25 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
      
        Dictionary<DateTime, List<Match>> rounds = Model.rounds;
        List<DateTime> keys = rounds.Keys.ToList();
        IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);
        int i = 0;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"container\">\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e7d247f8ca679bcb7cdae9820357de0c0c6de8d5998", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
                 if (SignInManager.IsSignedIn(User))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <button class=\"btn-primary\" type=\"submit\">Enregistrer les scores</button>\r\n");
#nullable restore
#line 39 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
                  int indexManche = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
                 foreach (DateTime key in keys)
                {
                    indexManche++;

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"bg-dark text-white card shadow py-2 col col-12\">\r\n                        <h2>Manche ");
#nullable restore
#line 45 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
                              Write(indexManche);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 45 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
                                           Write(key.TimeOfDay);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </h2>
                        <div class=""card-body"">

                            <table class="" table table-dark table-striped "">
                                <thead>
                                <tr>
                                    <th scope=""col"">Terrain</th>
                                    <th scope=""col"">Equipe 1</th>
                                    <th scope=""col"">Set 1</th>
                                    <th scope=""col"">Set 2</th>
                                    <th scope=""col"">Equipe 2</th>
                                    <th scope=""col"">Set 1</th>
                                    <th scope=""col"">Set 2</th>
                                </tr>
                                </thead>
");
#nullable restore
#line 60 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
                                 foreach (Match currentMatch in rounds[key])
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tbody>\r\n                                    <tr>\r\n                                        <td scope=\"row\">\r\n                                            ");
#nullable restore
#line 65 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
                                       Write(Html.DisplayFor(match => currentMatch.Terrain.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 68 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
                                       Write(Html.DisplayFor(match => currentMatch.Team1.TeamName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n");
#nullable restore
#line 70 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
                                         if (SignInManager.IsSignedIn(User))
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 3525, "\"", 3544, 3);
                WriteAttributeValue("", 3532, "vmMtu[", 3532, 6, true);
#nullable restore
#line 72 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
WriteAttributeValue("", 3538, i, 3538, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3540, "].Id", 3540, 4, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3545, "\"", 3569, 1);
#nullable restore
#line 72 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
WriteAttributeValue("", 3553, currentMatch.Id, 3553, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            <td>\r\n                                                <input class=\"input-group-sm\"");
                BeginWriteAttribute("name", " name=\"", 3700, "\"", 3722, 3);
                WriteAttributeValue("", 3707, "vmMtu[", 3707, 6, true);
#nullable restore
#line 74 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
WriteAttributeValue("", 3713, i, 3713, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3715, "].Set11", 3715, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3723, "\"", 3754, 1);
#nullable restore
#line 74 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
WriteAttributeValue("", 3731, currentMatch.Team1Set1, 3731, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            </td>\r\n                                            <td>\r\n                                                <input class=\"input-group-sm\"");
                BeginWriteAttribute("name", " name=\"", 3936, "\"", 3958, 3);
                WriteAttributeValue("", 3943, "vmMtu[", 3943, 6, true);
#nullable restore
#line 77 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
WriteAttributeValue("", 3949, i, 3949, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3951, "].Set12", 3951, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3959, "\"", 3990, 1);
#nullable restore
#line 77 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
WriteAttributeValue("", 3967, currentMatch.Team1Set2, 3967, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            </td>\r\n");
#nullable restore
#line 79 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <td>\r\n                                                ");
#nullable restore
#line 83 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
                                           Write(Html.DisplayFor(match => currentMatch.Team1Set1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 86 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
                                           Write(Html.DisplayFor(match => currentMatch.Team1Set2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </td>\r\n");
#nullable restore
#line 88 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td>\r\n                                            ");
#nullable restore
#line 90 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
                                       Write(Html.DisplayFor(match => currentMatch.Team2.TeamName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n");
#nullable restore
#line 92 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
                                         if (SignInManager.IsSignedIn(User))
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <td>\r\n                                                <input class=\"input-group\"");
                BeginWriteAttribute("name", " name=\"", 5058, "\"", 5080, 3);
                WriteAttributeValue("", 5065, "vmMtu[", 5065, 6, true);
#nullable restore
#line 95 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
WriteAttributeValue("", 5071, i, 5071, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5073, "].Set21", 5073, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 5081, "\"", 5112, 1);
#nullable restore
#line 95 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
WriteAttributeValue("", 5089, currentMatch.Team2Set1, 5089, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            </td>\r\n                                            <td>\r\n                                                <input class=\"input-group\"");
                BeginWriteAttribute("name", " name=\"", 5291, "\"", 5313, 3);
                WriteAttributeValue("", 5298, "vmMtu[", 5298, 6, true);
#nullable restore
#line 98 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
WriteAttributeValue("", 5304, i, 5304, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5306, "].Set22", 5306, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 5314, "\"", 5345, 1);
#nullable restore
#line 98 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
WriteAttributeValue("", 5322, currentMatch.Team2Set2, 5322, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            </td>\r\n");
#nullable restore
#line 100 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <td>\r\n                                                ");
#nullable restore
#line 104 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
                                           Write(Html.DisplayFor(match => currentMatch.Team2Set1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 107 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
                                           Write(Html.DisplayFor(match => currentMatch.Team2Set2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </td>\r\n");
#nullable restore
#line 109 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </tr>\r\n                                    </tbody>\r\n");
#nullable restore
#line 112 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
                                    i++;
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </table>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 117 "C:\Users\stef\source\repos\VolleyDamois\VolleyDamois\Views\Matches\Result.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e7d247f8ca679bcb7cdae9820357de0c0c6de8d21212", async() => {
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
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VolleyDamois.Models.ViewModelMatches> Html { get; private set; }
    }
}
#pragma warning restore 1591
