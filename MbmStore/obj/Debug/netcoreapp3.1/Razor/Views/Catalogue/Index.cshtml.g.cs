#pragma checksum "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f344d414005d8ed50eb255e5db41d9d909ffb57b"
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
#line 2 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\_ViewImports.cshtml"
using MbmStore.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
using MbmStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
using MbmStore.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f344d414005d8ed50eb255e5db41d9d909ffb57b", @"/Views/Catalogue/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fde4e2bdb918ee381fd601730c8e198e944962b", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogue_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-classes-enabled", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", new global::Microsoft.AspNetCore.Html.HtmlString("btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", new global::Microsoft.AspNetCore.Html.HtmlString("btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group pull-right m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::MbmStore.Infrastructure.PageLinkTagHelper __MbmStore_Infrastructure_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
      
   
    ViewData["Title"] = "Catalogue";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f344d414005d8ed50eb255e5db41d9d909ffb57b6662", async() => {
                WriteLiteral("\r\n        <title>Catalogue</title>\r\n    ");
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
            WriteLiteral("\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f344d414005d8ed50eb255e5db41d9d909ffb57b7676", async() => {
                WriteLiteral("\r\n        <h1>Catalogue</h1>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f344d414005d8ed50eb255e5db41d9d909ffb57b7972", async() => {
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
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 21 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
         if (Model.Products.OfType<Book>().ToList().Count > 0 )
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"products\" style=\"clear:both\">\r\n                <h2>Books</h2>\r\n");
#nullable restore
#line 25 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                 foreach (Book book in Model.Products.OfType<Book>().ToList())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
               Write(await Html.PartialAsync("ProductSummaryBook", book));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                                                                        
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n");
#nullable restore
#line 30 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
         if (Model.Products.OfType<MusicCD>().ToList().Count() > 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"products\" style=\"clear:both\">\r\n                <h2>Music CD</h2>\r\n");
#nullable restore
#line 36 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                 foreach (MusicCD cd in Model.Products.OfType<MusicCD>().ToList())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
               Write(await Html.PartialAsync("ProductSummaryMusicCD", cd));

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div>\r\n                        <strong>Tracks:</strong>\r\n\r\n                        <ol>\r\n\r\n");
#nullable restore
#line 44 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                             foreach (Track track in @cd.Tracks)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li>");
#nullable restore
#line 46 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                               Write(track.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
                WriteLiteral(" ");
#nullable restore
#line 46 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                                                                  Write(track.Length.Minutes);

#line default
#line hidden
#nullable disable
                WriteLiteral(":");
#nullable restore
#line 46 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                                                                                        Write(track.Length.Seconds);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </li>\r\n");
#nullable restore
#line 47 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </ol>\r\n                            <p><strong>Total playing time</strong>: ");
#nullable restore
#line 50 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                                                               Write(cd.GetPlayingTime().Minutes);

#line default
#line hidden
#nullable disable
                WriteLiteral(":");
#nullable restore
#line 50 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                                                                                            Write(cd.GetPlayingTime().Seconds);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    </div>\r\n");
#nullable restore
#line 52 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("             </div>\r\n");
#nullable restore
#line 54 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
         if (Model.Products.OfType<Movie>().ToList().Count > 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"products\" style=\"clear:both\">\r\n                <h2>Movies</h2>\r\n");
#nullable restore
#line 60 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                 foreach (Movie movie in Model.Products.OfType<Movie>().ToList())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
               Write(await Html.PartialAsync("ProductSummMovies", movie));

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
                                                                        
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n");
#nullable restore
#line 65 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f344d414005d8ed50eb255e5db41d9d909ffb57b15997", async() => {
                }
                );
                __MbmStore_Infrastructure_PageLinkTagHelper = CreateTagHelper<global::MbmStore.Infrastructure.PageLinkTagHelper>();
                __tagHelperExecutionContext.Add(__MbmStore_Infrastructure_PageLinkTagHelper);
#nullable restore
#line 66 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
__MbmStore_Infrastructure_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __MbmStore_Infrastructure_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __MbmStore_Infrastructure_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                if (__MbmStore_Infrastructure_PageLinkTagHelper.PageUrlValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("page-url-category", "MbmStore.Infrastructure.PageLinkTagHelper", "PageUrlValues"));
                }
#nullable restore
#line 68 "C:\Treihard\VS C#\Lesson02_MbmStore_startup\MbmStore\Views\Catalogue\Index.cshtml"
__MbmStore_Infrastructure_PageLinkTagHelper.PageUrlValues["category"] = Model.CurrentCategory;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("page-url-category", __MbmStore_Infrastructure_PageLinkTagHelper.PageUrlValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n</html>\r\n        ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
