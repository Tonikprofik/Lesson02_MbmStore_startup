#pragma checksum "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06a74277143599ece2b0530a9cbbf6d21a47210d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06a74277143599ece2b0530a9cbbf6d21a47210d", @"/Views/Movie/Index.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Movie\Index.cshtml"
  
    ViewData["Title"] = "Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06a74277143599ece2b0530a9cbbf6d21a47210d3358", async() => {
                WriteLiteral("Home");
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
            WriteLiteral("\r\n\r\n\r\n<h2>");
#nullable restore
#line 11 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Movie\Index.cshtml"
Write(ViewBag.JungleBook.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3>");
#nullable restore
#line 12 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Movie\Index.cshtml"
Write(ViewBag.JungleBook.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<p>Price: ");
#nullable restore
#line 13 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Movie\Index.cshtml"
     Write(String.Format("{0:0.00}", ViewBag.JungleBook.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><img");
            BeginWriteAttribute("src", " src=\"", 326, "\"", 373, 2);
            WriteAttributeValue("", 332, "/Images/", 332, 8, true);
#nullable restore
#line 14 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Movie\Index.cshtml"
WriteAttributeValue("", 340, ViewBag.JungleBook.ImageFileName, 340, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 374, "\"", 405, 1);
#nullable restore
#line 14 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Movie\Index.cshtml"
WriteAttributeValue("", 380, ViewBag.JungleBook.Title, 380, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></p>\r\n\r\n<h2>");
#nullable restore
#line 16 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Movie\Index.cshtml"
Write(ViewBag.LittleWoman.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3>");
#nullable restore
#line 17 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Movie\Index.cshtml"
Write(ViewBag.LittleWoman.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<p>Price: ");
#nullable restore
#line 18 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Movie\Index.cshtml"
     Write(String.Format("{0:0.00}", ViewBag.LittleWoman.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><img");
            BeginWriteAttribute("src", " src=\"", 570, "\"", 618, 2);
            WriteAttributeValue("", 576, "/Images/", 576, 8, true);
#nullable restore
#line 19 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Movie\Index.cshtml"
WriteAttributeValue("", 584, ViewBag.LittleWoman.ImageFileName, 584, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 619, "\"", 651, 1);
#nullable restore
#line 19 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Movie\Index.cshtml"
WriteAttributeValue("", 625, ViewBag.LittleWoman.Title, 625, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></p>\r\n\r\n<h2>");
#nullable restore
#line 21 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Movie\Index.cshtml"
Write(ViewBag.HarryPotter.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3>");
#nullable restore
#line 22 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Movie\Index.cshtml"
Write(ViewBag.HarryPotter.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<p>Price: ");
#nullable restore
#line 23 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Movie\Index.cshtml"
     Write(String.Format("{0:0.00}", ViewBag.HarryPotter.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><img");
            BeginWriteAttribute("src", " src=\"", 816, "\"", 864, 2);
            WriteAttributeValue("", 822, "/Images/", 822, 8, true);
#nullable restore
#line 24 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Movie\Index.cshtml"
WriteAttributeValue("", 830, ViewBag.HarryPotter.ImageFileName, 830, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 865, "\"", 897, 1);
#nullable restore
#line 24 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Movie\Index.cshtml"
WriteAttributeValue("", 871, ViewBag.HarryPotter.Title, 871, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></p>");
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
