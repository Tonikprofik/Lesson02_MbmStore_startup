#pragma checksum "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af17ac20cd800cba3932f06e5e2c4037fcbb5088"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogue_Index), @"mvc.1.0.view", @"/Views/Catalogue/Index.cshtml")]
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
#line 2 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
using MbmStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af17ac20cd800cba3932f06e5e2c4037fcbb5088", @"/Views/Catalogue/Index.cshtml")]
    public class Views_Catalogue_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
  
    ViewData["Title"] = "Catalogue";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Catalogue</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af17ac20cd800cba3932f06e5e2c4037fcbb50883729", async() => {
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
            WriteLiteral("\r\n<p>\r\n    \r\n");
#nullable restore
#line 11 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
     foreach (Product item in ViewBag.Products)
    {
        if (item is Movie)
        {
            Movie movie = (Movie)item;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>");
#nullable restore
#line 16 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
           Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2><div>Director: ");
#nullable restore
#line 16 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                                           Write(movie.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div> <div>Price: ");
#nullable restore
#line 16 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                                                                             Write(movie.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "af17ac20cd800cba3932f06e5e2c4037fcbb50886287", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 471, "~/Images/", 471, 9, true);
#nullable restore
#line 17 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
AddHtmlAttributeValue("", 480, movie.ImageFileName, 480, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 17 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
AddHtmlAttributeValue("", 507, movie.Title, 507, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n");
#nullable restore
#line 18 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
        }
        else if (item is Book)
        {
        Book book = (Book)item;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <h2>");
#nullable restore
#line 23 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
           Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2> <div>Author: ");
#nullable restore
#line 23 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                                         Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n            <div>Price:  ");
#nullable restore
#line 24 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                    Write(book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div>Publisher: ");
#nullable restore
#line 25 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                       Write(book.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div>Published: ");
#nullable restore
#line 26 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                       Write(book.Published);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div>ISBN: ");
#nullable restore
#line 27 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                  Write(book.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "af17ac20cd800cba3932f06e5e2c4037fcbb508810167", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 910, "~/Images/", 910, 9, true);
#nullable restore
#line 28 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
AddHtmlAttributeValue("", 919, book.ImageUrl, 919, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 28 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
AddHtmlAttributeValue("", 940, book.Title, 940, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n        </div>\r\n");
#nullable restore
#line 30 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
        }
        else if (item is MusicCD)
        {
        MusicCD musicCD = (MusicCD)item;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>");
#nullable restore
#line 35 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
       Write(musicCD.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h3>");
#nullable restore
#line 36 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
       Write(musicCD.Artist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
            WriteLiteral("        <div>");
#nullable restore
#line 38 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
        Write(musicCD.Released);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div>");
#nullable restore
#line 39 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
        Write(musicCD.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div>Price: ");
#nullable restore
#line 40 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
               Write(musicCD.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "af17ac20cd800cba3932f06e5e2c4037fcbb508813717", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1283, "~/Images/", 1283, 9, true);
#nullable restore
#line 41 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
AddHtmlAttributeValue("", 1292, musicCD.ImageUrl, 1292, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 41 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
AddHtmlAttributeValue("", 1316, musicCD.Title, 1316, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n        <ol>\r\n");
#nullable restore
#line 43 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
             foreach (Track track in musicCD.Tracks)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    ");
#nullable restore
#line 46 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
               Write(track.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("\r\n                    ");
#nullable restore
#line 47 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
               Write(track.Length.Minutes);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 47 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                                     Write(track.Length.Seconds);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </li>\r\n");
#nullable restore
#line 50 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </ol>\r\n");
#nullable restore
#line 53 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </ul>\r\n    </p>");
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