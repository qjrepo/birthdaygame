#pragma checksum "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adbf6a1a6bca91dfcf33ed6b556e4ca387715d30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_DiningRoom), @"mvc.1.0.view", @"/Views/Game/DiningRoom.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Game/DiningRoom.cshtml", typeof(AspNetCore.Views_Game_DiningRoom))]
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
#line 1 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/_ViewImports.cshtml"
using Game;

#line default
#line hidden
#line 2 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/_ViewImports.cshtml"
using Game.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adbf6a1a6bca91dfcf33ed6b556e4ca387715d30", @"/Views/Game/DiningRoom.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"011ad339aa9d387b55f9c2d4ba3c5674a35cf98d", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_DiningRoom : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Guess>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Game", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Robot", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" position: relative; top:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" top:20px;  position: relative; left:20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(619, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(864, 1158, true);
            WriteLiteral(@"<style>
    div.a {
        position: relative;
        width: 100%;
        height: 120px;
    }

    div.b {
        position: absolute;
        right: 0;
        width: 100px;
        height: 120px;
    }
    h1 {
        position: relative;
        left: 5px;
        font-size: 20px;
    }

    h2 {
        position: relative;
        left: 20px;
        font-size: 40px;
        font-family: fantasy;
        font-weight: bolder;
        color: rgb(0,0,0);
        top: 10px;
    }

    h3 {
        position: relative;
        left: 20px;
        font-size: 28px;
        color: rgb(0,0,0);
        font-family: fantasy;
        top: 10px;
    }

    h4 {
        font-size: 20px;
        color: rgb(0,0,0);
        position: relative;
        left: 10px;
        font-weight: bolder;
    }

    span {
        position: relative;
        left: 5px;
    }

    body {
        background-image: url(""/image/Image004.jpeg "");
    }
    #panel, #flip {
        pad");
            WriteLiteral("ding: 5px;\r\n        text-align: center;\r\n    }\r\n\r\n    #panel {\r\n        display: none;\r\n        text-align: center;\r\n    }\r\n</style>\r\n");
            EndContext();
            BeginContext(2022, 6442, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adbf6a1a6bca91dfcf33ed6b556e4ca387715d306310", async() => {
                BeginContext(2028, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2754, 271, true);
                WriteLiteral(@"
    <div id=""outerBody"" style="" position:relative;top:80px; width:1000px;height:400px;margin:0 Auto;"">

        <div id=""left section"" style="" background-color:rgba(255,255,255,0.7); float:left;position:relative;left:0px; width:500px;height:500px;"">
            <h2>");
                EndContext();
                BeginContext(3026, 18, false);
#line 112 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
           Write(ViewData["Intro1"]);

#line default
#line hidden
                EndContext();
                BeginContext(3044, 77, true);
                WriteLiteral("</h2>\r\n\r\n            <h3 style=\" position:relative;left:4px; font-size:20px\">");
                EndContext();
                BeginContext(3122, 16, false);
#line 114 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
                                                               Write(ViewData["clue"]);

#line default
#line hidden
                EndContext();
                BeginContext(3138, 23, true);
                WriteLiteral("</h3>\r\n\r\n\r\n            ");
                EndContext();
                BeginContext(3161, 195, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adbf6a1a6bca91dfcf33ed6b556e4ca387715d307936", async() => {
                    BeginContext(3205, 147, true);
                    WriteLiteral("\r\n                <img class=\"over-img\" src=\"/image/Image003.png\" style=\" position:relative;left:122px;width:100px;height:140px\" />\r\n\r\n            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3356, 212, true);
                WriteLiteral("<br />\r\n            <div class=\"w3-panel w3-pale-green\" style=\"position:relative;left: 10px; font-weight: bolder; font-family:monospace; color:rgb(0,0,0); padding:10px;width:450px;height:140px\">\r\n                ");
                EndContext();
                BeginContext(3569, 17, false);
#line 122 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
           Write(ViewData["Intro"]);

#line default
#line hidden
                EndContext();
                BeginContext(3586, 40, true);
                WriteLiteral("\r\n            </div><br />\r\n            ");
                EndContext();
                BeginContext(3626, 214, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adbf6a1a6bca91dfcf33ed6b556e4ca387715d3010350", async() => {
                    BeginContext(3632, 201, true);
                    WriteLiteral("\r\n                <input formaction=\"/Game/Dining1\" style=\"position:sticky;background-color:rgb(153, 204, 255); border-radius: 12px; top:5px; left:5px\" type=\"submit\" value=\"Back\" /><br />\r\n            ");
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
                BeginContext(3840, 153, true);
                WriteLiteral("\r\n\r\n        </div>\r\n        <div id=\"right section\" style=\"background-color:rgba(255,255,255,0.7); float:right; width:450px;height:500px;\">\r\n            ");
                EndContext();
                BeginContext(3993, 1463, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adbf6a1a6bca91dfcf33ed6b556e4ca387715d3012241", async() => {
                    BeginContext(4037, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 131 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
                 using (Html.BeginForm("Click2", "Game"))
                {

#line default
#line hidden
                    BeginContext(4117, 164, true);
                    WriteLiteral("                    <h4 style=\" float:left;position: relative; left:10px\">Most wanted present:</h4>\r\n                    <span style=\"position: relative;left:35px\">");
                    EndContext();
                    BeginContext(4282, 25, false);
#line 134 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
                                                          Write(Html.TextBoxFor(m => m.a));

#line default
#line hidden
                    EndContext();
                    BeginContext(4307, 166, true);
                    WriteLiteral("</span><br />\r\n                    <br />\r\n                    <h4 style=\" float:left;\">Second:</h4>\r\n                    <span style=\"position: relative;left:160px\">");
                    EndContext();
                    BeginContext(4474, 25, false);
#line 137 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
                                                           Write(Html.TextBoxFor(m => m.b));

#line default
#line hidden
                    EndContext();
                    BeginContext(4499, 165, true);
                    WriteLiteral("</span><br />\r\n                    <br />\r\n                    <h4 style=\" float:left;\">Third:</h4>\r\n                    <span style=\"position: relative;left:180px\">");
                    EndContext();
                    BeginContext(4665, 25, false);
#line 140 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
                                                           Write(Html.TextBoxFor(m => m.c));

#line default
#line hidden
                    EndContext();
                    BeginContext(4690, 166, true);
                    WriteLiteral("</span><br />\r\n                    <br />\r\n                    <h4 style=\" float:left;\">Fourth:</h4>\r\n                    <span style=\"position: relative;left:170px\">");
                    EndContext();
                    BeginContext(4857, 25, false);
#line 143 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
                                                           Write(Html.TextBoxFor(m => m.d));

#line default
#line hidden
                    EndContext();
                    BeginContext(4882, 173, true);
                    WriteLiteral("</span><br />\r\n                    <br />\r\n                    <h4 style=\" float:left;\"> Least wanted:</h4>\r\n                    <span style=\"position: relative;left:105px\">");
                    EndContext();
                    BeginContext(5056, 25, false);
#line 146 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
                                                           Write(Html.TextBoxFor(m => m.e));

#line default
#line hidden
                    EndContext();
                    BeginContext(5081, 43, true);
                    WriteLiteral("</span><br />\r\n                    <br />\r\n");
                    EndContext();
                    BeginContext(5126, 186, true);
                    WriteLiteral("                    <input style=\"position:relative;left:130px; border-radius: 12px;background-color:rgb(230, 230, 0); float:left\" type=\"submit\" formaction=\"/Game/Click2\" value=\"OK\" />\r\n");
                    EndContext();
                    BeginContext(5333, 28, false);
#line 150 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
               Write(Html.Raw(TempData["empty2"]));

#line default
#line hidden
                    EndContext();
                    BeginContext(5384, 28, false);
#line 151 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
               Write(Html.Raw(TempData["empty3"]));

#line default
#line hidden
                    EndContext();
#line 151 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
                                                 


                }

#line default
#line hidden
                    BeginContext(5437, 12, true);
                    WriteLiteral("            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5456, 16, true);
                WriteLiteral("\r\n\r\n            ");
                EndContext();
                BeginContext(5472, 325, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adbf6a1a6bca91dfcf33ed6b556e4ca387715d3018390", async() => {
                    BeginContext(5478, 223, true);
                    WriteLiteral("\r\n                <input formaction=\"/Game/Shuffle1\" style=\"float:left; border-radius: 12px;background-color:rgb(230, 230, 0); position:relative;top:10px; left:180px\" type=\"submit\" value=\"Shuffle\" /><br />\r\n                ");
                    EndContext();
                    BeginContext(5702, 28, false);
#line 159 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
           Write(Html.Raw(TempData["empty1"]));

#line default
#line hidden
                    EndContext();
                    BeginContext(5730, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(5749, 27, false);
#line 160 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
           Write(Html.Raw(TempData["empty"]));

#line default
#line hidden
                    EndContext();
                    BeginContext(5776, 14, true);
                    WriteLiteral("\r\n            ");
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
                BeginContext(5797, 20, true);
                WriteLiteral("<br />\r\n            ");
                EndContext();
                BeginContext(5817, 1065, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adbf6a1a6bca91dfcf33ed6b556e4ca387715d3020948", async() => {
                    BeginContext(5873, 148, true);
                    WriteLiteral("\r\n                <input style=\"border-radius: 12px; background-color:rgb(204, 255, 204)\" formaction=\"/Game/Click3\" type=\"submit\" value=\"Guess\" />\r\n");
                    EndContext();
#line 164 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
                 if (!string.IsNullOrEmpty(ViewBag.Message))
                {

#line default
#line hidden
                    BeginContext(6102, 91, true);
                    WriteLiteral("                    <script type=\"text/javascript\">\r\n                               alert(\"");
                    EndContext();
                    BeginContext(6194, 15, false);
#line 167 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
                                 Write(ViewBag.Message);

#line default
#line hidden
                    EndContext();
                    BeginContext(6209, 34, true);
                    WriteLiteral("\");\r\n                    </script>");
                    EndContext();
#line 168 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
                             }

#line default
#line hidden
                    BeginContext(6244, 295, true);
                    WriteLiteral(@"<br />
                <p style=""float:left;position:relative;top:10px;font-size:28px"">Is it</p>
                <div class=""w3-panel w3-pale-green"" style="" float:left;top:18px; color:white; position:relative;left:10px; background-color:black; width:200px;height:30px"">

                    ");
                    EndContext();
                    BeginContext(6540, 17, false);
#line 172 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
               Write(ViewData["first"]);

#line default
#line hidden
                    EndContext();
                    BeginContext(6557, 94, true);
                    WriteLiteral("\r\n                </div><p style=\"position:relative;left:28px;top:8px; font-size:30px\">?</p>\r\n");
                    EndContext();
                    BeginContext(6772, 16, true);
                    WriteLiteral("                ");
                    EndContext();
                    BeginContext(6789, 26, false);
#line 175 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
           Write(Html.Raw(TempData["hint"]));

#line default
#line hidden
                    EndContext();
                    BeginContext(6815, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(6834, 27, false);
#line 176 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
           Write(Html.Raw(TempData["empty"]));

#line default
#line hidden
                    EndContext();
                    BeginContext(6861, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6882, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(6896, 776, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adbf6a1a6bca91dfcf33ed6b556e4ca387715d3025538", async() => {
                    BeginContext(6902, 194, true);
                    WriteLiteral("\r\n                <input formaction=\"/Game/No\" type=\"submit\" style=\" position:relative; border-radius: 12px;  top:24px;left:22px;background-color:rgb(204, 255, 204); float:left;\" value=\"No\" />\r\n");
                    EndContext();
#line 180 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
                 if (!string.IsNullOrEmpty(ViewBag.Message))
                {

#line default
#line hidden
                    BeginContext(7177, 90, true);
                    WriteLiteral("                    <script type=\"text/javascript\">\r\n                              alert(\"");
                    EndContext();
                    BeginContext(7268, 15, false);
#line 183 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
                                Write(ViewBag.Message);

#line default
#line hidden
                    EndContext();
                    BeginContext(7283, 34, true);
                    WriteLiteral("\");\r\n                    </script>");
                    EndContext();
#line 184 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
                             }

#line default
#line hidden
                    BeginContext(7320, 16, true);
                    WriteLiteral("                ");
                    EndContext();
                    BeginContext(7337, 28, false);
#line 185 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
           Write(Html.Raw(TempData["empty1"]));

#line default
#line hidden
                    EndContext();
                    BeginContext(7365, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 187 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
                 if (!string.IsNullOrEmpty(ViewBag.MessageNo))
                {

#line default
#line hidden
                    BeginContext(7497, 90, true);
                    WriteLiteral("                    <script type=\"text/javascript\">\r\n                              alert(\"");
                    EndContext();
                    BeginContext(7588, 17, false);
#line 190 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
                                Write(ViewBag.MessageNo);

#line default
#line hidden
                    EndContext();
                    BeginContext(7605, 34, true);
                    WriteLiteral("\");\r\n                    </script>");
                    EndContext();
#line 191 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
                             }

#line default
#line hidden
                    BeginContext(7653, 12, true);
                    WriteLiteral("            ");
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
                BeginContext(7672, 16, true);
                WriteLiteral("\r\n\r\n            ");
                EndContext();
                BeginContext(7688, 735, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adbf6a1a6bca91dfcf33ed6b556e4ca387715d3029922", async() => {
                    BeginContext(7694, 206, true);
                    WriteLiteral("\r\n                <input formaction=\"/Game/Yes\" style=\"position:relative;background-color:rgb(204, 255, 204); border-radius: 12px;  left:60px;top:24px\" type=\"submit\" value=\"Yes\" /><br />\r\n\r\n                ");
                    EndContext();
                    BeginContext(7901, 17, false);
#line 197 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
           Write(ViewData["yesno"]);

#line default
#line hidden
                    EndContext();
                    BeginContext(7918, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 198 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
                 if (!string.IsNullOrEmpty(ViewBag.Message1))
                {

#line default
#line hidden
                    BeginContext(8002, 82, true);
                    WriteLiteral("                    <script type=\"text/javascript\">\r\n                      alert(\"");
                    EndContext();
                    BeginContext(8085, 16, false);
#line 201 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
                        Write(ViewBag.Message1);

#line default
#line hidden
                    EndContext();
                    BeginContext(8101, 34, true);
                    WriteLiteral("\");\r\n                    </script>");
                    EndContext();
#line 202 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
                             }

#line default
#line hidden
                    BeginContext(8138, 16, true);
                    WriteLiteral("                ");
                    EndContext();
#line 203 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
                 if (!string.IsNullOrEmpty(ViewBag.Message2))
                {

#line default
#line hidden
                    BeginContext(8220, 82, true);
                    WriteLiteral("                    <script type=\"text/javascript\">\r\n                      alert(\"");
                    EndContext();
                    BeginContext(8303, 16, false);
#line 206 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
                        Write(ViewBag.Message2);

#line default
#line hidden
                    EndContext();
                    BeginContext(8319, 34, true);
                    WriteLiteral("\");\r\n                    </script>");
                    EndContext();
#line 207 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
                             }

#line default
#line hidden
                    BeginContext(8356, 16, true);
                    WriteLiteral("                ");
                    EndContext();
                    BeginContext(8373, 27, false);
#line 208 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/DiningRoom.cshtml"
           Write(Html.Raw(TempData["hint1"]));

#line default
#line hidden
                    EndContext();
                    BeginContext(8400, 16, true);
                    WriteLiteral("\r\n\r\n            ");
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
                BeginContext(8423, 34, true);
                WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Guess> Html { get; private set; }
    }
}
#pragma warning restore 1591