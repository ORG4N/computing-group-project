#pragma checksum "C:\Users\aclev\Documents\GitHub\comp2003_2021-group-a\Ecobadge Website\Ecobadge Website\Pages\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b841efc81de5e4b5c86bd85b8d6354c8a7d9b7ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ecobadge_Website.Pages.Pages_Login), @"mvc.1.0.razor-page", @"/Pages/Login.cshtml")]
namespace Ecobadge_Website.Pages
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
#line 1 "C:\Users\aclev\Documents\GitHub\comp2003_2021-group-a\Ecobadge Website\Ecobadge Website\Pages\_ViewImports.cshtml"
using Ecobadge_Website;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b841efc81de5e4b5c86bd85b8d6354c8a7d9b7ba", @"/Pages/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3e0047b77b376c882cc1d8fc91376420ddc4765", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\aclev\Documents\GitHub\comp2003_2021-group-a\Ecobadge Website\Ecobadge Website\Pages\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 120, "\"", 158, 1);
#nullable restore
#line 8 "C:\Users\aclev\Documents\GitHub\comp2003_2021-group-a\Ecobadge Website\Ecobadge Website\Pages\Login.cshtml"
WriteAttributeValue("", 127, Url.Content("~/css/login.css"), 127, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n");
            }
            );
            WriteLiteral(@"
<div class=""wrapper"">
    <div class=""container text-center"">
        <h1>Log In</h1>
    </div>

    <div class=""input-group input-group-lg mx-auto"">
        <input type=""email"" class=""form-control"" placeholder=""Email"" id=""emailUsername"">
    </div>

    <div class=""input-group input-group-lg mx-auto"">
        <input type=""password"" class=""form-control"" placeholder=""Password"" id=""password"">
        <div class=""input-group-append"">
            <button class=""btn btn-primary btn-dark"" type=""button"" id=""loginBtn"">SUBMIT</button>
        </div>
    </div>
</div>

<hr>

<div class=""wrapper"" style=""padding-top:20px"">
    <div class=""container text-center"">
        <h1>Not a member? Sign up:</h1>
    </div>

    <div class=""input-group input-group-lg mx-auto"">
        <input type=""text"" class=""form-control"" placeholder=""Forename"" id=""forename"">
        <input type=""text"" class=""form-control"" placeholder=""Surname"" id=""surname"">
    </div>

    <div class=""input-group input-group-lg mx-");
            WriteLiteral("auto\">\r\n        <input type=\"email\" class=\"form-control\" placeholder=\"Email\" id=\"email\">\r\n    </div>\r\n\r\n    <div class=\"input-group input-group-lg mx-auto\">\r\n            <select class=\"custom-select\" id=\"inputGroupSelect01\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b841efc81de5e4b5c86bd85b8d6354c8a7d9b7ba5750", async() => {
                WriteLiteral("Choose Account Type...");
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
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b841efc81de5e4b5c86bd85b8d6354c8a7d9b7ba7047", async() => {
                WriteLiteral("Free member - (recommended for Personal use)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b841efc81de5e4b5c86bd85b8d6354c8a7d9b7ba8256", async() => {
                WriteLiteral("Paid member - (recommended for Businesses)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </select>
    </div>

    <div class=""input-group input-group-lg mx-auto"">
        <input type=""password"" class=""form-control"" placeholder=""Password"" id=""password"">
        <input type=""password"" class=""form-control"" placeholder=""Confirm Password"" id=""password2"">
    </div>

    <div class=""input-group input-group-lg mx-auto"" style=""padding-top:5px"">
        <div class=""form-check"">
            <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 2147, "\"", 2155, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""mail"">
            <label class=""form-check-label"" for=""flexCheckDefault"">
                I would like to subscribe to the ECO Badge mailing list
            </label>
        </div>
    </div>

    <div class=""input-group input-group-lg mx-auto"">
        <div class=""form-check"">
            <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 2510, "\"", 2518, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""mail"">
            <label class=""form-check-label"" for=""flexCheckDefault"">
                    I agree to the <a href=""#"" data-toggle=""modal"" data-target=""#terms""> Terms and Conditions</a>
            </label>
        </div>
    </div>

    <div class=""d-flex justify-content-center"" style=""padding:15px"">
        <button type=""button"" class=""btn btn-dark"" style=""width:40%"">Create Account</button>
    </div>

</div>

<div class=""modal fade"" id=""terms"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-lg modal-dialog-scrollable"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Terms and Conditions</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>
                    Lorem ipsum dolor sit amet, cons");
            WriteLiteral(@"ectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Donec ultrices tincidunt arcu non sodales neque sodales ut. Non odio euismod lacinia at quis risus sed vulputate. Commodo nulla facilisi nullam vehicula ipsum a. Pretium fusce id velit ut tortor. Gravida dictum fusce ut placerat orci nulla. Arcu odio ut sem nulla pharetra. Ac turpis egestas maecenas pharetra. Neque egestas congue quisque egestas diam in arcu cursus. Morbi tristique senectus et netus et malesuada fames. Viverra suspendisse potenti nullam ac tortor vitae purus faucibus. Morbi tempus iaculis urna id volutpat lacus laoreet. Amet mauris commodo quis imperdiet massa tincidunt nunc pulvinar sapien. Risus ultricies tristique nulla aliquet enim tortor at auctor. Accumsan tortor posuere ac ut consequat semper viverra nam libero.
                    Dui vivamus arcu felis bibendum. At urna condimentum mattis pellentesque id nibh. Urna cursus eget nunc scelerisque viverra mauris. Ornare massa eget egestas purus v");
            WriteLiteral(@"iverra. Massa vitae tortor condimentum lacinia quis vel. Amet consectetur adipiscing elit duis tristique sollicitudin. Risus pretium quam vulputate dignissim suspendisse in. In hac habitasse platea dictumst vestibulum rhoncus. Ut etiam sit amet nisl purus in. Quis lectus nulla at volutpat diam ut venenatis. Amet consectetur adipiscing elit pellentesque. At elementum eu facilisis sed. Maecenas accumsan lacus vel facilisis volutpat est velit egestas dui. Nunc pulvinar sapien et ligula. Tortor at auctor urna nunc id cursus metus aliquam eleifend.
                    Est ullamcorper eget nulla facilisi etiam dignissim diam quis. Tortor consequat id porta nibh venenatis cras sed felis. Quisque id diam vel quam elementum pulvinar. Blandit cursus risus at ultrices mi tempus. Volutpat diam ut venenatis tellus in metus vulputate eu. Sit amet porttitor eget dolor morbi non arcu risus quis. Lacinia at quis risus sed vulputate odio ut enim blandit. At tempor commodo ullamcorper a. Amet volutpat consequat mauris nunc con");
            WriteLiteral(@"gue nisi. Non curabitur gravida arcu ac tortor dignissim convallis. Enim tortor at auctor urna nunc id cursus metus aliquam. Aenean et tortor at risus viverra adipiscing at in. Pellentesque pulvinar pellentesque habitant morbi tristique. Purus faucibus ornare suspendisse sed nisi lacus sed viverra. Est lorem ipsum dolor sit amet. Imperdiet sed euismod nisi porta lorem mollis. Consectetur adipiscing elit ut aliquam. Volutpat sed cras ornare arcu dui vivamus.
                    At quis risus sed vulputate. Rhoncus urna neque viverra justo nec ultrices dui sapien. Nisi est sit amet facilisis magna etiam tempor orci. Ut consequat semper viverra nam libero justo laoreet sit amet. Pellentesque adipiscing commodo elit at imperdiet dui. Egestas tellus rutrum tellus pellentesque. Sit amet massa vitae tortor. Ante in nibh mauris cursus mattis molestie a. Quam vulputate dignissim suspendisse in est ante in nibh mauris. Lorem ipsum dolor sit amet. Vitae purus faucibus ornare suspendisse sed nisi lacus. Vitae purus fauc");
            WriteLiteral(@"ibus ornare suspendisse sed nisi lacus sed. Et tortor at risus viverra adipiscing at in tellus integer. Consequat interdum varius sit amet mattis vulputate enim nulla.
                    Nisl nisi scelerisque eu ultrices vitae auctor. Aliquam sem fringilla ut morbi tincidunt augue interdum velit. Tristique magna sit amet purus gravida quis blandit. Feugiat nibh sed pulvinar proin gravida hendrerit lectus. Commodo nulla facilisi nullam vehicula ipsum a arcu. Eu turpis egestas pretium aenean pharetra magna. Tincidunt vitae semper quis lectus. Ipsum dolor sit amet consectetur adipiscing elit duis tristique sollicitudin. Varius morbi enim nunc faucibus a pellentesque sit. Vel turpis nunc eget lorem. Quis blandit turpis cursus in hac habitasse. Dignissim enim sit amet venenatis urna cursus eget nunc scelerisque. Suspendisse in est ante in nibh mauris cursus. Montes nascetur ridiculus mus mauris vitae ultricies leo integer malesuada. Sit amet mattis vulputate enim.
                </p>
            </div>
     ");
            WriteLiteral("   </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ecobadge_Website.Pages.LoginModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ecobadge_Website.Pages.LoginModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ecobadge_Website.Pages.LoginModel>)PageContext?.ViewData;
        public Ecobadge_Website.Pages.LoginModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
