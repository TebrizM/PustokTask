#pragma checksum "C:\Users\wacht\OneDrive\Desktop\p124_asp_12_partialview-TebrizM\PustokTask\PustokTask\Views\Shared\_BookSlider.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29656b3566ab0bec162bc209415baf41ce78e468"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BookSlider), @"mvc.1.0.view", @"/Views/Shared/_BookSlider.cshtml")]
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
#line 1 "C:\Users\wacht\OneDrive\Desktop\p124_asp_12_partialview-TebrizM\PustokTask\PustokTask\Views\_ViewImports.cshtml"
using PustokTask.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wacht\OneDrive\Desktop\p124_asp_12_partialview-TebrizM\PustokTask\PustokTask\Views\_ViewImports.cshtml"
using PustokTask.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wacht\OneDrive\Desktop\p124_asp_12_partialview-TebrizM\PustokTask\PustokTask\Views\_ViewImports.cshtml"
using PustokTask.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29656b3566ab0bec162bc209415baf41ce78e468", @"/Views/Shared/_BookSlider.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45c3050c1df3a6183a52cbfee0850810f3ce48a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BookSlider : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "getbook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("single-btn open-books-modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""product-slider multiple-row  slider-border-multiple-row  sb-slick-slider""
     data-slick-setting='{
                            ""autoplay"": true,
                            ""autoplaySpeed"": 8000,
                            ""slidesToShow"": 5,
                            ""rows"":1,
                            ""dots"":true
                        }' data-slick-responsive='[
                            {""breakpoint"":1200, ""settings"": {""slidesToShow"": 3} },
                            {""breakpoint"":768, ""settings"": {""slidesToShow"": 2} },
                            {""breakpoint"":480, ""settings"": {""slidesToShow"": 1} },
                            {""breakpoint"":320, ""settings"": {""slidesToShow"": 1} }
                        ]'>

");
#nullable restore
#line 16 "C:\Users\wacht\OneDrive\Desktop\p124_asp_12_partialview-TebrizM\PustokTask\PustokTask\Views\Shared\_BookSlider.cshtml"
     foreach (var book in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"single-slide\">\r\n            <div class=\"product-card\">\r\n                <div class=\"product-header\">\r\n                    <a href=\"#\" class=\"author\">\r\n                        ");
#nullable restore
#line 22 "C:\Users\wacht\OneDrive\Desktop\p124_asp_12_partialview-TebrizM\PustokTask\PustokTask\Views\Shared\_BookSlider.cshtml"
                   Write(book.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                    <h3>\r\n                        <a href=\"product-details.html\">\r\n                            ");
#nullable restore
#line 26 "C:\Users\wacht\OneDrive\Desktop\p124_asp_12_partialview-TebrizM\PustokTask\PustokTask\Views\Shared\_BookSlider.cshtml"
                       Write(book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </h3>\r\n                </div>\r\n                <div class=\"product-card--body\">\r\n                    <div class=\"card-image\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "29656b3566ab0bec162bc209415baf41ce78e4687092", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1392, "~/assets/image/products/", 1392, 24, true);
#nullable restore
#line 32 "C:\Users\wacht\OneDrive\Desktop\p124_asp_12_partialview-TebrizM\PustokTask\PustokTask\Views\Shared\_BookSlider.cshtml"
AddHtmlAttributeValue("", 1416, book.BookImages.FirstOrDefault(x=>x.BookStatus==true)?.Image, 1416, 61, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div class=\"hover-contents\">\r\n                            <a href=\"product-details.html\" class=\"hover-image\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "29656b3566ab0bec162bc209415baf41ce78e4688936", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1665, "~/assets/image/products/", 1665, 24, true);
#nullable restore
#line 35 "C:\Users\wacht\OneDrive\Desktop\p124_asp_12_partialview-TebrizM\PustokTask\PustokTask\Views\Shared\_BookSlider.cshtml"
AddHtmlAttributeValue("", 1689, book.BookImages.FirstOrDefault(x=>x.BookStatus==false)?.Image, 1689, 62, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </a>
                            <div class=""hover-btns"">
                                <a href=""cart.html"" class=""single-btn"">
                                    <i class=""fas fa-shopping-basket""></i>
                                </a>
                                <a href=""wishlist.html"" class=""single-btn"">
                                    <i class=""fas fa-heart""></i>
                                </a>
                                <a href=""compare.html"" class=""single-btn"">
                                    <i class=""fas fa-random""></i>
                                </a>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29656b3566ab0bec162bc209415baf41ce78e46811292", async() => {
                WriteLiteral("\r\n                                    <i class=\"fas fa-eye\"></i>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\wacht\OneDrive\Desktop\p124_asp_12_partialview-TebrizM\PustokTask\PustokTask\Views\Shared\_BookSlider.cshtml"
                                                                                WriteLiteral(book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"price-block\">\r\n");
#nullable restore
#line 55 "C:\Users\wacht\OneDrive\Desktop\p124_asp_12_partialview-TebrizM\PustokTask\PustokTask\Views\Shared\_BookSlider.cshtml"
                         if (book.DiscountPercent > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"price\">£");
#nullable restore
#line 57 "C:\Users\wacht\OneDrive\Desktop\p124_asp_12_partialview-TebrizM\PustokTask\PustokTask\Views\Shared\_BookSlider.cshtml"
                                             Write((book.SalePrice * (1- book.DiscountPercent/100)).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <del class=\"price-old\">£");
#nullable restore
#line 58 "C:\Users\wacht\OneDrive\Desktop\p124_asp_12_partialview-TebrizM\PustokTask\PustokTask\Views\Shared\_BookSlider.cshtml"
                                               Write(book.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n                            <span class=\"price-discount\">");
#nullable restore
#line 59 "C:\Users\wacht\OneDrive\Desktop\p124_asp_12_partialview-TebrizM\PustokTask\PustokTask\Views\Shared\_BookSlider.cshtml"
                                                    Write(book.DiscountPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n");
#nullable restore
#line 60 "C:\Users\wacht\OneDrive\Desktop\p124_asp_12_partialview-TebrizM\PustokTask\PustokTask\Views\Shared\_BookSlider.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"price\">£");
#nullable restore
#line 63 "C:\Users\wacht\OneDrive\Desktop\p124_asp_12_partialview-TebrizM\PustokTask\PustokTask\Views\Shared\_BookSlider.cshtml"
                                            Write(book.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 64 "C:\Users\wacht\OneDrive\Desktop\p124_asp_12_partialview-TebrizM\PustokTask\PustokTask\Views\Shared\_BookSlider.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 70 "C:\Users\wacht\OneDrive\Desktop\p124_asp_12_partialview-TebrizM\PustokTask\PustokTask\Views\Shared\_BookSlider.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
