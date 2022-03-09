#pragma checksum "C:\Users\datgu\Documents\comp2003_2021-group-a\Ecobadge Website revamped\Ecobadge Website\Pages\Directory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "173c8bee94606d5416e3ea82802e5516291ff833"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ecobadge_Website.Pages.Pages_Directory), @"mvc.1.0.razor-page", @"/Pages/Directory.cshtml")]
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
#line 1 "C:\Users\datgu\Documents\comp2003_2021-group-a\Ecobadge Website revamped\Ecobadge Website\Pages\_ViewImports.cshtml"
using Ecobadge_Website;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"173c8bee94606d5416e3ea82802e5516291ff833", @"/Pages/Directory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3e0047b77b376c882cc1d8fc91376420ddc4765", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Directory : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\datgu\Documents\comp2003_2021-group-a\Ecobadge Website revamped\Ecobadge Website\Pages\Directory.cshtml"
  
    ViewData["Title"] = "Directory";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 129, "\"", 171, 1);
#nullable restore
#line 8 "C:\Users\datgu\Documents\comp2003_2021-group-a\Ecobadge Website revamped\Ecobadge Website\Pages\Directory.cshtml"
WriteAttributeValue("", 136, Url.Content("~/css/directory.css"), 136, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n");
            }
            );
            WriteLiteral(@"
<div class=""container wrapper"">

    <div class=""row"">

        <div class=""col-12 text-container"">
            <div class=""row"">
                <div class=""col-6"">
                    <div class=""row"">
                        <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 498, "\"", 506, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""plastic"">
                            <label class=""form-check-label"" for=""plastic"">
                            Less than 20% single use plastic
                        </label>
                    </div>
                    <div class=""row"">
                        <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 833, "\"", 841, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""recycled"">
                        <label class=""form-check-label"" for=""recycled"">
                        More than 80% recycled waste
                        </label>
                    </div>
                    <div class=""row"">
                        <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 1158, "\"", 1166, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""carbon"">
                        <label class=""form-check-label"" for=""carbon"">
                        Carbon neutral
                        </label>
                    </div>
                    <div class=""row"">
                        <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 1465, "\"", 1473, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""renewable"">
                        <label class=""form-check-label"" for=""renewable"">
                        Uses renewable energy
                        </label>
                    </div>
                </div>

                <div class=""col-6"">
                    <div class=""dropdown py-1"">
                        <button class=""btn-block btn-success dropdown-toggle"" type=""button"" data-toggle=""dropdown"">
                            Location
                            <span class=""caret""></span>
                        </button>
                        <ul class=""dropdown-menu"">
                            <li><a href=""#"">Plymouth</a></li>
                            <li><a href=""#"">Exeter</a></li>
                            <li><a href=""#"">Bristol</a></li>
                        </ul>
                    </div>

                    <div class=""dropdown py-1"">
                        <button class=""btn-block btn-success dropdown-toggle"" type=""button"" data-toggle=""dropdown"">
            WriteLiteral(@"
                            Cuisine
                            <span class=""caret""></span>
                        </button>
                        <ul class=""dropdown-menu"">
                            <li><a href=""#"">Burgers</a></li>
                            <li><a href=""#"">Chicken</a></li>
                            <li><a href=""#"">Pizza</a></li>
                        </ul>
                    </div>

                    <div class=""dropdown py-1"">
                        <button class=""btn-block btn-success dropdown-toggle"" type=""button"" data-toggle=""dropdown"">
                            Eco Badge Tier
                            <span class=""caret""></span>
                        </button>
                        <ul class=""dropdown-menu"">
                            <li><a href=""#"">Platinum</a></li>
                            <li><a href=""#"">Gold</a></li>
                            <li><a href=""#"">Silver</a></li>
                            <li><a href=""#"">Bronze</a></li>
            WriteLiteral(@"
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""table-responsive"">
        <div class=""table-wrapper"">

            <table class=""table table-hover"" style=""margin-bottom:0"" id=""businesses"">

                <thead>
                    <tr>
                        <th>Company</th>
                        <th>Address</th>
                        <th>Postcode</th>
                        <th>Tel</th>
                        <th>Email</th>
                        <th>Website</th>
                        <th>Picture</th>
                        <th>Cuisine</th>
                        <th>Score</th>
                        <th>Tier</th>
                        <th>Vegan friendly</th>
                        <th>Doesn't use single use plastic</th>
                        <th>Foodwaste collection scheme</th>
                        <th>Local produce</th>
                    </tr>
              ");
            WriteLiteral(@"  </thead>

                <tbody>

                </tbody>

            </table>
        </div>
    </div>
</div>


<script>

    fetchBookings();

    async function fetchBookings() {

        const url = ""https://localhost:44393/api/business"";
        const raw = await fetch(url);

        const data = await raw.json();

        data.forEach(({ name, address, postcode, tel, email, website, picture, cuisine, tier, vegan, plastic, foodwaste, local }) => {
            $(""#businesses"").find('tbody').append(`<tr id=""LC13"" class=""js-file-line"">
                <td>${name}</td>
                <td>${address}</td>
                <td>${postcode}</td>
                <td>${tel}</td>
                <td>${email}</td>
                <td>${website}</td>
                <td>${picture}</td>
                <td>${cuisine}</td>
                <td>${vegan}</td>
                <td>${plastic}</td>
                <td>${foodwaste}</td>
                <td>${local}</td>
               ");
            WriteLiteral(" </tr>`);\r\n    });\r\n}\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ecobadge_Website.Pages.DirectoryModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ecobadge_Website.Pages.DirectoryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ecobadge_Website.Pages.DirectoryModel>)PageContext?.ViewData;
        public Ecobadge_Website.Pages.DirectoryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591