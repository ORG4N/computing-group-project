#pragma checksum "C:\Users\aclev\Documents\GitHub\comp2003_2021-group-a\Ecobadge Website\Ecobadge Website\Pages\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faa6ef7fbccbdd4b8fa70f31b95c49db901186bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ecobadge_Website.Pages.Pages_UserProfile), @"mvc.1.0.razor-page", @"/Pages/UserProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faa6ef7fbccbdd4b8fa70f31b95c49db901186bc", @"/Pages/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3e0047b77b376c882cc1d8fc91376420ddc4765", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UserProfile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\aclev\Documents\GitHub\comp2003_2021-group-a\Ecobadge Website\Ecobadge Website\Pages\UserProfile.cshtml"
  
    ViewData["Title"] = "User Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 133, "\"", 177, 1);
#nullable restore
#line 8 "C:\Users\aclev\Documents\GitHub\comp2003_2021-group-a\Ecobadge Website\Ecobadge Website\Pages\UserProfile.cshtml"
WriteAttributeValue("", 140, Url.Content("~/css/userprofile.css"), 140, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\"/>\r\n");
            }
            );
            WriteLiteral(@"

<div class=""container wrapper"">
    <h3 class=""text-center"">User Profile</h3>
    <div class=""row"">
        <div class=""col-4 image-container"">
            --Image Placeholder--
        </div>

        <div class=""col-8 text-container"">
            <div");
            BeginWriteAttribute("class", " class=\"", 483, "\"", 491, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi fringilla blandit mauris, sit amet gravida erat sodales in. Nunc rutrum blandit augue, a dictum nibh dictum quis. Quisque pretium lorem consectetur orci placerat sodales. Aliquam id elit libero. Duis in ex nisi. Praesent a risus est. In et pharetra erat. In condimentum, mi ut placerat dapibus, arcu nunc sagittis sem, non euismod eros libero id ex. Donec ut pharetra risus. Duis fringilla est et cursus ultrices. Nulla mollis nec metus sed elementum. Phasellus et odio eget elit euismod dictum.</div>
        </div>
    </div>
    <br>

    <div class=""text-center text-header""");
            BeginWriteAttribute("style", " style=\"", 1140, "\"", 1148, 0);
            EndWriteAttribute();
            WriteLiteral(@">Recent places you've visited</div>
    <div class=""col-12 text-container"">

        <div class=""col-md-12 text-center"">
            <div class=""pt-2"">
                <br>
                <p>Click for full PDF</p>
                <br>
            </div>
        </div>
    </div>
    <br>
    <div class=""text-center text-header"">Your Personal Assessment Score</div>

    <div class=""row justify-content-center"">
        <div class=""col-4 image-container"">
            --Image Placeholder--
        </div>
    </div>
</div>

<div class=""modal fade"" id=""contact"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header text-center"">
                <h5 class=""modal-title w-100"">Contact us</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>

            <");
            WriteLiteral(@"div class=""modal-body"">

                <div class=""input-group input-group-lg mx-auto"">
                    <input type=""text"" class=""form-control"" placeholder=""Name"" id=""name"">
                </div>

                <div class=""input-group input-group-lg mx-auto"">
                    <input type=""email"" class=""form-control"" placeholder=""Email"" id=""email"">
                </div>

                <div class=""input-group input-group-lg mx-auto"">
                    <input type=""text"" class=""form-control"" placeholder=""Your message"" id=""message"">
                </div>

                <div class=""input-group input-group-lg mx-auto"" style=""padding-top:5px"">
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 2970, "\"", 2978, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""mail"">
                        <label class=""form-check-label"" for=""flexCheckDefault"">
                            I consent to my email address being used for marketing and
                            promotional reasons, and subscribe to the ECO Badge mailing list.
                        </label>
                    </div>
                </div>

                <div class=""input-group input-group-lg mx-auto"">
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 3527, "\"", 3535, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""terms"">
                        <label class=""form-check-label"" for=""flexCheckDefault"">
                            I agree to the <a href=""#""> Terms and Conditions</a>
                            and <a href=""#""> Policy</a>
                            , and give consent to the use of my details and information for the purpose of responding to my message.
                        </label>
                    </div>
                </div>

                <div class=""d-flex justify-content-center"" style=""padding:15px"">
                    <button type=""button"" class=""btn btn-dark"" style=""width:40%"">Submit</button>
                </div>

            </div>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ecobadge_Website.Pages.UserProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ecobadge_Website.Pages.UserProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ecobadge_Website.Pages.UserProfileModel>)PageContext?.ViewData;
        public Ecobadge_Website.Pages.UserProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
