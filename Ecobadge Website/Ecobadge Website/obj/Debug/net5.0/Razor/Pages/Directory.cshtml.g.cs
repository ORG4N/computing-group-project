#pragma checksum "F:\comp2003_2021-group-a\Ecobadge Website\Ecobadge Website\Pages\Directory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb7411ce7cce89eaca4b7eabf32772f61b4be0e5"
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
#line 1 "F:\comp2003_2021-group-a\Ecobadge Website\Ecobadge Website\Pages\_ViewImports.cshtml"
using Ecobadge_Website;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb7411ce7cce89eaca4b7eabf32772f61b4be0e5", @"/Pages/Directory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3e0047b77b376c882cc1d8fc91376420ddc4765", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Directory : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\comp2003_2021-group-a\Ecobadge Website\Ecobadge Website\Pages\Directory.cshtml"
  
    ViewData["Title"] = "Directory";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 129, "\"", 171, 1);
#nullable restore
#line 8 "F:\comp2003_2021-group-a\Ecobadge Website\Ecobadge Website\Pages\Directory.cshtml"
WriteAttributeValue("", 136, Url.Content("~/css/directory.css"), 136, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://unpkg.com/feather-icons\"></script>\r\n    <script>\r\n        feather.replace()\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"
<div class=""container-fluid wrapper"">

    <div class=""row"">

        <div class=""col-6 offset-3 text-container"">
            <div class=""row"">
                <div class=""col-5"">
                    <div class=""row"">
                        <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 654, "\"", 662, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""plastic"">
                            <label class=""form-check-label"" for=""plastic"">
                            Less than 20% single use plastic
                        </label>
                    </div>
                    <div class=""row"">
                        <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 989, "\"", 997, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""recycled"">
                        <label class=""form-check-label"" for=""recycled"">
                        More than 80% recycled waste
                        </label>
                    </div>
                    <div class=""row"">
                        <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 1314, "\"", 1322, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""carbon"">
                        <label class=""form-check-label"" for=""carbon"">
                        Carbon neutral
                        </label>
                    </div>
                    <div class=""row"">
                        <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 1621, "\"", 1629, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""renewable"">
                        <label class=""form-check-label"" for=""renewable"">
                        Uses renewable energy
                        </label>
                    </div>
                </div>

                <div class=""col-5"">
                    <div class=""dropdown py-1"">
                        <button class=""btn-block btn-success dropdown-toggle"" type=""button"" data-toggle=""dropdown"">
                            Location
                            <span class=""caret""></span>
                        </button>
                        <div class=""dropdown-menu"" id=""locations"">

                        </div>
                    </div>

                    <div class=""dropdown py-1"">
                        <button class=""btn-block btn-success dropdown-toggle"" type=""button"" data-toggle=""dropdown"">
                            Cuisine
                            <span class=""caret""></span>
                        </button>
                        <div class=""d");
            WriteLiteral(@"ropdown-menu"" id=""cuisines"">
                        </div>
                    </div>

                    <div class=""dropdown py-1"">
                        <button class=""btn-block btn-success dropdown-toggle"" type=""button"" data-toggle=""dropdown"">
                            Eco Badge Tier
                            <span class=""caret""></span>
                        </button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"">Bronze</a>
                            <a class=""dropdown-item"" href=""#"">Silver</a>
                            <a class=""dropdown-item"" href=""#"">Gold</a>
                            <a class=""dropdown-item"" href=""#"">Platinum</a>
                        </div>
                    </div>
                </div>

                <div class=""col-2"">
                    <button type=""button"" class=""btn btn-primary btn-lg btn-block"" style=""display: block; width: 100%; height:100%;"" >
                      ");
            WriteLiteral(@"  <i data-feather=""refresh-cw""></i>
                    </button>
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
                        <th>County</th>
                        <th>Street</th>
                        <th>Postcode</th>
                        <th>Telephone</th>
                        <th>Tier</th>
                        <th>Cuisines</th>
                        <th>Vegan friendly</th>
                        <th>Doesn't use single use plastic</th>
                        <th>Foodwaste collection scheme</th>
                        <th>Local produce</th>
                    </tr>
                </thead>

                <tbody>

                </tbody>

            </table>
        </div>
");
            WriteLiteral(@"    </div>
</div>


<script>
    const element = document.getElementById(""parent"");
    element.classList.remove(""container"");
    element.classList.add(""container-fluid"");

    const locations = [];
    const cuisines = {};

    fetchCompanies().then(fetchCuisines).then(fetchCompanyCuisines).then(function() {
        locationFilters();
        cuisineFilters();
    })

    function locationFilters(){

        locations.sort();

        for(i=0; i<locations.length; i++){
            const value = locations[i];
            $(""#locations"").append(`<a class=""dropdown-item"" href=""#"">${value}</a>`);
        }
    }

    function cuisineFilters(){

        const cuisineList  = [];

        for (var key in cuisines){
            const value = cuisines[key];
            cuisineList.push(value);
        }

        // Easier to sort a list than a dictionary so export all cuisine names within the dict to cuisineList
        cuisineList.sort();

        // Print the alpabetical orde");
            WriteLiteral(@"ring of cuisines
        for(i=0; i<cuisineList.length; i++){
            var value = cuisineList[i];
            $(""#cuisines"").append(`<a class=""dropdown-item"" href=""#"">${value}</a>`);
        }
    }

    async function fetchCompanies() {

        const url = ""https://localhost:44393/api/companies"";
        const raw = await fetch(url);

        const data = await raw.json();

        data.forEach(({ companyId, companyName, county, address, postcode, tel, cuisine, ecobadgeTier, veganDishes, singleUsePlastic, foodWasteCollectionScheme, localProduce }) => {
            $(""#businesses"").find('tbody').append(`<tr id=""${companyId}"" class=""js-file-line"">
                <td>${companyName}</td>
                <td>${county}</td>
                <td>${address}</td>
                <td>${postcode}</td>
                <td>${tel}</td>
                <td>${ecobadgeTier}</td>
                <td style=""text-align:center""></td>
                <td>${veganDishes}</td>
                <td>${singl");
            WriteLiteral(@"eUsePlastic}</td>
                <td>${foodWasteCollectionScheme}</td>
                <td>${localProduce}</td>
                </tr>`);

            if (!locations.includes(county)){
                locations.push(county);
            }
        });
    }

    async function fetchCuisines() {

        const url = ""https://localhost:44393/api/cuisines"";
        const raw = await fetch(url);

        const data = await raw.json();

        data.forEach(({cuisineId, cuisineName }) => {
            cuisines[cuisineId] = cuisineName;
        });
        console.table(cuisines);
    }

    async function fetchCompanyCuisines(){
        const url = ""https://localhost:44393/api/companycuisines"";
        const raw = await fetch(url);

        const data = await raw.json();

        data.forEach(({cuisineId, companyId }) => {

            const row = document.getElementById(companyId);
            const value = cuisines[cuisineId];
            const col = row.getElementsByTagName('td'");
            WriteLiteral(")[6];\r\n            col.innerText += value + \"\\n\";\r\n        });\r\n\r\n    }\r\n\r\n</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ecobadge_Website.Pages.DirectoryModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ecobadge_Website.Pages.DirectoryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ecobadge_Website.Pages.DirectoryModel>)PageContext?.ViewData;
        public Ecobadge_Website.Pages.DirectoryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
