#pragma checksum "C:\Users\jafru\source\repos\Ecobadge Website\Ecobadge Website\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ff28d2ed73bd1153063b79d5522cc743762da4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ecobadge_Website.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
#line 1 "C:\Users\jafru\source\repos\Ecobadge Website\Ecobadge Website\Pages\_ViewImports.cshtml"
using Ecobadge_Website;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ff28d2ed73bd1153063b79d5522cc743762da4c", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3e0047b77b376c882cc1d8fc91376420ddc4765", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\jafru\source\repos\Ecobadge Website\Ecobadge Website\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ff28d2ed73bd1153063b79d5522cc743762da4c3285", async() => {
                WriteLiteral(@"
  <title>Bootstrap Example</title>
  <meta charset=""utf-8"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
  <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
  <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
  <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
  <style>
    /* Add a gray background color and some padding to the footer */
    footer {
      background-color: #f2f2f2;
      padding: 25px;
    }
    
    /* Hide the carousel text when the screen is less than 600 pixels wide */
    ");
                WriteLiteral("@media (max-width: 600px) {\r\n      .carousel-caption {\r\n        display: none; \r\n      }\r\n    }\r\n  </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ff28d2ed73bd1153063b79d5522cc743762da4c5092", async() => {
                WriteLiteral(@"

<nav class=""navbar navbar-inverse"">
  <div class=""container-fluid"">
    <div class=""navbar-header"">
      <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target=""#myNavbar"">
        <span class=""icon-bar""></span>
        <span class=""icon-bar""></span>
        <span class=""icon-bar""></span>                        
      </button>
      <a class=""navbar-brand"" href=""#"">Logo</a>
    </div>
    <div class=""collapse navbar-collapse"" id=""myNavbar"">
      <ul class=""nav navbar-nav"">
        <li class=""active""><a href=""#"">Home</a></li>
        <li><a href=""#"">About</a></li>
        <li><a href=""#"">Projects</a></li>
        <li><a href=""#"">Contact</a></li>
      </ul>
      <ul class=""nav navbar-nav navbar-right"">
        <li><a href=""#""><span class=""glyphicon glyphicon-log-in""></span> Login</a></li>
      </ul>
    </div>
  </div>
</nav>

<div class=""container"">
<div class=""row"">
  <div class=""col-sm-8"">
    <div id=""myCarousel"" class=""carousel slide"" data-ride=""");
                WriteLiteral(@"carousel"">
      <!-- Indicators -->
      <ol class=""carousel-indicators"">
        <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#myCarousel"" data-slide-to=""1""></li>
      </ol>

      <!-- Wrapper for slides -->
      <div class=""carousel-inner"" role=""listbox"">
        <div class=""item active"">
          <img src=""https://placehold.it/800x400?text=IMAGE"" alt=""Image"">
          <div class=""carousel-caption"">
            <h3>Sell $</h3>
            <p>Money Money.</p>
          </div>      
        </div>

        <div class=""item"">
          <img src=""https://placehold.it/800x400?text=Another Image Maybe"" alt=""Image"">
          <div class=""carousel-caption"">
            <h3>More Sell $</h3>
            <p>Lorem ipsum...</p>
          </div>      
        </div>
      </div>

      <!-- Left and right controls -->
      <a class=""left carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
        <span class=""glyphicon ");
                WriteLiteral(@"glyphicon-chevron-left"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
      </a>
      <a class=""right carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""next"">
        <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
      </a>
    </div>
  </div>
  <div class=""col-sm-4"">
    <div class=""well"">
      <p>Some text..</p>
    </div>
    <div class=""well"">
       <p>Upcoming Events..</p>
    </div>
    <div class=""well"">
       <p>Visit Our Blog</p>
    </div>
  </div>
</div>
<hr>
</div>

<div class=""container text-center"">    
  <h3>What We Do</h3>
  <br>
  <div class=""row"">
    <div class=""col-sm-3"">
      <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image"">
      <p>Current Project</p>
    </div>
    <div class=""col-sm-3""> 
      <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" ");
                WriteLiteral(@"alt=""Image"">
      <p>Project 2</p>    
    </div>
    <div class=""col-sm-3"">
      <div class=""well"">
       <p>Some text..</p>
      </div>
      <div class=""well"">
       <p>Some text..</p>
      </div>
    </div>
    <div class=""col-sm-3"">
      <div class=""well"">
       <p>Some text..</p>
      </div>
      <div class=""well"">
       <p>Some text..</p>
      </div>
    </div>  
  </div>
  <hr>
</div>

<div class=""container text-center"">    
  <h3>Our Partners</h3>
  <br>
  <div class=""row"">
    <div class=""col-sm-2"">
      <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image"">
      <p>Partner 1</p>
    </div>
    <div class=""col-sm-2""> 
      <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image"">
      <p>Partner 2</p>    
    </div>
    <div class=""col-sm-2""> 
      <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image"">");
                WriteLiteral(@"
      <p>Partner 3</p>
    </div>
    <div class=""col-sm-2""> 
      <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image"">
      <p>Partner 4</p>
    </div> 
    <div class=""col-sm-2""> 
      <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image"">
      <p>Partner 5</p>
    </div>     
    <div class=""col-sm-2""> 
      <img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image"">
      <p>Partner 6</p>
    </div> 
  </div>
</div><br>

<footer class=""container-fluid text-center"">
  <p>Footer Text</p>
</footer>

");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
