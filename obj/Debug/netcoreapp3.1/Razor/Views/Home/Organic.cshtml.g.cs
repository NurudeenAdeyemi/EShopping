#pragma checksum "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Organic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e920be7508cb6f66eb579b06596e054ca9181c6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Organic), @"mvc.1.0.view", @"/Views/Home/Organic.cshtml")]
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
#line 1 "C:\Users\nurudeen\source\repos\EShopping\Views\_ViewImports.cshtml"
using EShopping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nurudeen\source\repos\EShopping\Views\_ViewImports.cshtml"
using EShopping.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e920be7508cb6f66eb579b06596e054ca9181c6e", @"/Views/Home/Organic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ede52dd518d7d092ef8e0d4ea00074426d3a3b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Organic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Item>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Vegebasket"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("popover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-trigger", new global::Microsoft.AspNetCore.Html.HtmlString("hover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-content", new global::Microsoft.AspNetCore.Html.HtmlString("Click add to cart to enjoy our fresh products"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n<div");
            BeginWriteAttribute("class", " class=\"", 30, "\"", 38, 0);
            EndWriteAttribute();
            WriteLiteral(">\n    <p><h6 class=\"font-weight-bolder\">Organic Products</h6></p>\n    <hr>\n    <div class=\"container\">\n        <div class=\"row text-center\">\n");
#nullable restore
#line 8 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Organic.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-sm-3 border active img-responsive  mb-2\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e920be7508cb6f66eb579b06596e054ca9181c6e6887", async() => {
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e920be7508cb6f66eb579b06596e054ca9181c6e7148", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 513, "~/images/", 513, 9, true);
#nullable restore
#line 12 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Organic.cshtml"
AddHtmlAttributeValue("", 522, item.ItemPictureUrl, 522, 20, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Organic.cshtml"
                                                    WriteLiteral(item.ItemId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    <p class=\"mb-0\">");
#nullable restore
#line 14 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Organic.cshtml"
               Write(item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>&#8358 ");
#nullable restore
#line 15 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Organic.cshtml"
         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n    <button type=\"submit\" onclick=\"addToCart(this)\"");
            BeginWriteAttribute("id", " id=\"", 729, "\"", 751, 2);
            WriteAttributeValue("", 734, "item-", 734, 5, true);
#nullable restore
#line 16 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Organic.cshtml"
WriteAttributeValue("", 739, item.ItemId, 739, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-name=\"");
#nullable restore
#line 16 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Organic.cshtml"
                                                                                 Write(item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-price=\"");
#nullable restore
#line 16 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Organic.cshtml"
                                                                                                             Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-id=\"");
#nullable restore
#line 16 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Organic.cshtml"
                                                                                                                                   Write(item.ItemId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-sm btn-outline-success font-weight-bold\" style=\"width:70%\"><span class=\"spinner-grow spinner-grow-sm\"></span><small>ADD TO CART</small></button>\n</div>            ");
#nullable restore
#line 17 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Organic.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>

    </div>
</div>



<div id=""cart-modal"" class=""modal fade align-content-center"" tabindex=""-1"">
    <div class=""modal-dialog modal-dialog-centered "">
        <div class=""modal-content"">
            <div class=""container bg-light"">
                <div class=""row justify-content-center"">
                    <div>
                        <h5 class=""text-dark"">VEGEBASKET CART </h5>
                    </div>
                </div>
            </div>
            <div class=""modal-header "">

                <h5 class=""modal-title text-success"" id=""item-name""> </h5>

                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>

            <div class=""modal-body"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            &#8358 <h5 id=""item-price"" class=""text-dark font-");
            WriteLiteral(@"weight-light""></h5>
                        </div>
                        <div class=""col-sm-4"">
                            <input id=""quantity"" class=""form-control col-sm-12"" min=""1"" type=""number"" placeholder=""Quantity"" />
                        </div>
                        <div class=""col-sm-4"">
                            &#8358 <h5 id=""item-total"" class=""text-primary font-weight-light""></h5>
                        </div>
                    </div>
                </div>
            </div>


            <div class=""modal-footer bg-light"">
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
                <button type=""button"" id=""save"" class=""btn btn-success"">Add to Cart</button>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591
