#pragma checksum "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/Kitchen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e3108d107597adbb9b4a52434a0fdcae5dfc118"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Kitchen), @"mvc.1.0.view", @"/Views/Game/Kitchen.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Game/Kitchen.cshtml", typeof(AspNetCore.Views_Game_Kitchen))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3108d107597adbb9b4a52434a0fdcae5dfc118", @"/Views/Game/Kitchen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"011ad339aa9d387b55f9c2d4ba3c5674a35cf98d", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Kitchen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/f1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 25%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(130, 1455, true);
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
<style>
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
    .w3-modal {
        display: none; /* Hidden by default */
        position: fixed; /* Stay in place */
        z-index: 1; /* Sit on top */
        padding-top: 100px; /* Location of the box */
        left: 0;
        top: 0;
        width: 100%; /* Full width */
        height: 100%; /* Full height */
        overflow: auto; /* Enable scroll if needed */
        background-color: rgb(0,0,0); /* Fallback color */
        background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
    }

    .w3-modal-content {
        background-color: #fefefe;
        margin: auto;
        padding: 20px;
        border: 1px solid #888;
        width: 80%;
    }
    body {
        background-ima");
            WriteLiteral(@"ge: url(""/image/kitchen2.jpg"");
        background-repeat: no-repeat;
        background-size: 100%100%;
    }
    .column {
        float: left;

        text-align: center;

        position: absolute;
        bottom: 50px;
        right: 0;
    }
    #panel, #flip {
        padding: 5px;
        text-align: center;
    }

    #panel {
        display: none;
        text-align: center;
    }

</style>
");
            EndContext();
            BeginContext(1585, 2490, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e3108d107597adbb9b4a52434a0fdcae5dfc1185570", async() => {
                BeginContext(1591, 305, true);
                WriteLiteral(@"


    <div class=""a"">
        <div class=""b"">
            <div style=""position:relative;float:left;right:1100px; bottom:6px;font-weight:bolder;font-size:24px"" id=""flip"">
                Bag
            </div>
            <div id=""panel"" style=""position:relative; padding:15px 40px;right:50px;"">
");
                EndContext();
#line 75 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/Kitchen.cshtml"
                 foreach (var i in Model)
                {

#line default
#line hidden
                BeginContext(1958, 101, true);
                WriteLiteral("                    <p style=\"position:relative;font-size:20px; float:left;right:1080px; bottom:6px\">");
                EndContext();
                BeginContext(2060, 1, false);
#line 77 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/Kitchen.cshtml"
                                                                                                Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(2061, 12, true);
                WriteLiteral("</p><br />\r\n");
                EndContext();
#line 78 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/Kitchen.cshtml"
                }

#line default
#line hidden
                BeginContext(2092, 408, true);
                WriteLiteral(@"            </div>
            <script>
                $(document).ready(function(){
                  $(""#flip"").click(function(){
                    $(""#panel"").slideToggle(""slow"");
                  });
                });
            </script>
        </div>
    </div>
    <a style=""float:right ;position:relative;right:1100px;bottom:120px;font-weight:bolder;font-size:24px;color:rgb(0,0,0)""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2500, "\"", 2534, 1);
#line 89 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/Kitchen.cshtml"
WriteAttributeValue("", 2507, Url.Action("Khint","Game"), 2507, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2535, 179, true);
                WriteLiteral(">Hint</a>\r\n\r\n\r\n\r\n\r\n\r\n    <div class=\"w3-container\">\r\n\r\n        <a onclick=\"document.getElementById(\'id01\').style.display=\'block\'\" style=\"position:absolute;bottom:80px;left:700px\">");
                EndContext();
                BeginContext(2714, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8e3108d107597adbb9b4a52434a0fdcae5dfc1188372", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2759, 361, true);
                WriteLiteral(@"</a>

        <div id=""id01"" class=""w3-modal"">
            <div class=""w3-modal-content"">
                <div class=""w3-container"">
                    <span onclick=""document.getElementById('id01').style.display='none'"" class=""w3-button w3-display-topright"">&times;</span>
                    <p>there are something lying at the bottom of the tank</p>
");
                EndContext();
#line 104 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/Kitchen.cshtml"
                     foreach (var i in Model)
                    {

#line default
#line hidden
#line 105 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/Kitchen.cshtml"
                      if (i == "Fish Rod")
                        {

#line default
#line hidden
                BeginContext(3238, 30, true);
                WriteLiteral("                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3268, "\"", 3307, 1);
#line 107 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/Kitchen.cshtml"
WriteAttributeValue("", 3275, Url.Action("Continue4", "Game"), 3275, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3308, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(3310, 1, false);
#line 107 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/Kitchen.cshtml"
                                                                  Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(3311, 6, true);
                WriteLiteral("</a>\r\n");
                EndContext();
#line 108 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/Kitchen.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(3401, 30, true);
                WriteLiteral("                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3431, "\"", 3466, 1);
#line 111 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/Kitchen.cshtml"
WriteAttributeValue("", 3438, Url.Action("Wrong", "Game"), 3438, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3467, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(3469, 1, false);
#line 111 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/Kitchen.cshtml"
                                                              Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(3470, 6, true);
                WriteLiteral("</a>\r\n");
                EndContext();
#line 112 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/Kitchen.cshtml"
                        }

#line default
#line hidden
#line 112 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/Kitchen.cshtml"
                         
                }

#line default
#line hidden
                BeginContext(3522, 72, true);
                WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
#line 118 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/Kitchen.cshtml"
     foreach (var i in ViewBag.KitchenStory)
    {

#line default
#line hidden
                BeginContext(3647, 48, true);
                WriteLiteral("        <h2 style=\"position:relative; top:0px;\">");
                EndContext();
                BeginContext(3696, 1, false);
#line 120 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/Kitchen.cshtml"
                                           Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(3697, 7, true);
                WriteLiteral("</h2>\r\n");
                EndContext();
#line 121 "/Users/wu/Desktop/INFO6250WEB/BirthdayGameFinal/Game/Views/Game/Kitchen.cshtml"
    }

#line default
#line hidden
                BeginContext(3711, 2, true);
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
