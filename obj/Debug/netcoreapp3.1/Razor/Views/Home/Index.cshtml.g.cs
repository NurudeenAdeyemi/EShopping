#pragma checksum "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb4b7c1dab57f2300b6a40638fcf92d203424ef0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb4b7c1dab57f2300b6a40638fcf92d203424ef0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ede52dd518d7d092ef8e0d4ea00074426d3a3b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Item>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/test_Moment.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/10.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/OIP (1).jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/OIP.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/special.webp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive img-rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("style", async() => {
                WriteLiteral(@"
    <style>
        .carousel-inner img {
            width: 100%; /* Set width to 100% */
            min-height: 200px;
        }

        .btn-add-cart {
            position: absolute;
            right: 15px;
            top: 0px;
        }

        .notification {
            color: white;
            text-decoration: none;
            padding: 5px 3px;
            position: relative;
            display: inline-block;
            border-radius: 2px;
        }



            .notification .badge {
                position: absolute;
                top: -10px;
                right: -10px;
                padding: 5px 10px;
                border-radius: 50%;
                background: red;
                color: white;
            }
    </style>

");
            }
            );
            WriteLiteral(@"

<div class=""container-fluid"">
    <div class=""row"">


        <div class=""col-sm-12"">
            <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
                <!-- Indicators -->
                <ol class=""carousel-indicators"">
                    <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
                    <li data-target=""#myCarousel"" data-slide-to=""1""></li>
                    <li data-target=""#myCarousel"" data-slide-to=""2""></li>
                    <li data-target=""#myCarousel"" data-slide-to=""4""></li>
                    <li data-target=""#myCarousel"" data-slide-to=""5""></li>
                </ol>

                <!-- Wrapper for slides -->
                <div class=""carousel-inner"" role=""listbox"" style=""height:300px"">
                    <div class=""carousel-item active"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bb4b7c1dab57f2300b6a40638fcf92d203424ef08257", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""carousel-caption"">
                            <h3>Flyway</h3>
                            <p>Flyway</p>
                        </div>
                    </div>

                    <div class=""carousel-item"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bb4b7c1dab57f2300b6a40638fcf92d203424ef09645", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""carousel-caption"">
                            <h3>Flyway</h3>
                            <p>Flyway</p>
                        </div>
                    </div>

                    <div class=""carousel-item"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bb4b7c1dab57f2300b6a40638fcf92d203424ef011033", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""carousel-caption"">
                            <h3>Flyway</h3>
                            <p>Flyway</p>
                        </div>
                    </div>
                    <div class=""carousel-item"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bb4b7c1dab57f2300b6a40638fcf92d203424ef012421", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""carousel-caption"">
                            <h3>Flyway</h3>
                            <p>Flyway</p>
                        </div>
                    </div>

                    <div class=""carousel-item"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bb4b7c1dab57f2300b6a40638fcf92d203424ef013810", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""carousel-caption"">
                            <h3>Flyway</h3>
                            <p>Flyway</p>
                        </div>
                    </div>
                </div>

                <!-- Left and right controls -->
                <a class=""carousel-control-prev"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#myCarousel"" role=""button"" data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
            </div>
        </div>
    </div>
    <hr>
</div>

<div class=""container-fluid"">
    <div class=""row"">
        <a href=""#"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bb4b7c1dab57f2300b6a40638fcf92d203424ef015914", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </a>\n    </div>\n</div>\n<br>\n\n<div class=\"text-center \">\n    <p><h4 class=\"font-weight-light\">Featured Products</h4></p>\n    <hr>\n</div>\n<div class=\"container-fluid text-center\">\n    <div class=\"row\">\n\n        <!-- ");
#nullable restore
#line 130 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
              foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-2 border\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bb4b7c1dab57f2300b6a40638fcf92d203424ef017718", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4398, "~/images/", 4398, 9, true);
#nullable restore
#line 133 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4407, item.ItemPictureUrl, 4407, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            <p>");
#nullable restore
#line 134 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
          Write(item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>");
#nullable restore
#line 135 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
          Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <input type=\"submit\" onclick=\"addToCart(this.id)\"");
            BeginWriteAttribute("id", " id=\"", 4610, "\"", 4632, 2);
            WriteAttributeValue("", 4615, "item-", 4615, 5, true);
#nullable restore
#line 136 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
WriteAttributeValue("", 4620, item.ItemId, 4620, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-name=\"");
#nullable restore
#line 136 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
                                                                                           Write(item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-price=\"");
#nullable restore
#line 136 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
                                                                                                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-id=\"");
#nullable restore
#line 136 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
                                                                                                                                             Write(item.ItemId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" value=\"ADD TO CART\" class=\"btn btn-sm btn-success\" style=\"width:70%\" />\n        </div>\n");
#nullable restore
#line 138 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\n    </div>\n</div>\n<hr />\n<br />\n<div class=\"container-fluid\">\n    <div class=\"row\">\n        <div class=\"col-sm-3 border-right\" style=\"height:300px\">\n            <div");
            BeginWriteAttribute("class", " class=\"", 4974, "\"", 4982, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <h4 class=""mb-0 m-0 text-success font-weight-light"">Category </h4>
            </div>

            <nav class=""nav flex-column mb-0 m-0 text-dark"">
                <small><a class=""nav-link active mb-0 text-dark "" href=""#"">Fresh Fruits</a></small>
                <small><a class=""nav-link mb-0 text-dark "" href=""#"">Fresh Veggies</a></small>
                <small><a class=""nav-link mb-0 text-dark "" href=""#"">Spices, Herbs and Seasonings</a></small>
                <small><a class=""nav-link mb-0 text-dark "" href=""#"">Organic Fruits and Vegetables</a></small>
                <small><a class=""nav-link mb-0 text-dark "" href=""#"">Exotic Fruits and Veggies</a></small>
                <small><a class=""nav-link text-dark "" href=""#"">Dry Fruits</a></small>
            </nav>
        </div>

        <div class=""col-sm-9"">
            <p><h6 class=""font-weight-light"">ALL PRODUCTS &#128526</h6></p>
            <hr>
            <div class=""container"">
                <div class=""row text-center"">
");
#nullable restore
#line 165 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-3 border active img-responsive\">\n            <a href=\"#\" title=\"Vegebasket\" data-toggle=\"popover\" data-trigger=\"hover\" data-content=\"Click add to cart to enjoy our fresh products\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bb4b7c1dab57f2300b6a40638fcf92d203424ef023521", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6300, "~/images/", 6300, 9, true);
#nullable restore
#line 169 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 6309, item.ItemPictureUrl, 6309, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </a>\n            <p class=\"mb-0\">");
#nullable restore
#line 171 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
                       Write(item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>&#8358 ");
#nullable restore
#line 172 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
                 Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n            <button type=\"submit\" onclick=\"addToCart(this)\"");
            BeginWriteAttribute("id", " id=\"", 6548, "\"", 6570, 2);
            WriteAttributeValue("", 6553, "item-", 6553, 5, true);
#nullable restore
#line 173 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
WriteAttributeValue("", 6558, item.ItemId, 6558, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-name=\"");
#nullable restore
#line 173 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
                                                                                         Write(item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-price=\"");
#nullable restore
#line 173 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
                                                                                                                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-id=\"");
#nullable restore
#line 173 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
                                                                                                                                           Write(item.ItemId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-sm btn-outline-success font-weight-bold\" style=\"width:70%\"><span class=\"spinner-grow spinner-grow-sm\"></span><small>ADD TO CART</small></button>\n        </div>");
#nullable restore
#line 174 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>

            </div>
        </div>
    </div>
    <hr>
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
                            ");
            WriteLiteral(@"&#8358 <h5 id=""item-price"" class=""text-dark font-weight-light""></h5>
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
</div>
<!-- Modal -->
");
            WriteLiteral("\n\n\n\n\n<!-- Modal -->\n");
            WriteLiteral("\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        const cartModal = $('#cart-modal');
        const cartMenu = $('#cart-menu');
        const totalQuantityLabel = $('#total-quantity-label');
        const modalItemNameLabel = $('#item-name');
        const modalItemPriceLabel = $(""#item-price"");
        const modalItemQuantityInput = $(""#quantity"");
        const modalItemTotalLabel = $(""#item-total"");

        function addToCart(itemHTMLElement) {
            const itemElement = $(itemHTMLElement);
            const price = parseInt(itemElement.data(""price""));
            const name = itemElement.data(""name"");
            const itemId = itemElement.data(""id"");

            modalItemNameLabel.data(""elementId"", itemHTMLElement.id);
            modalItemNameLabel.html(name);
            modalItemPriceLabel.html(`Unit Price: ${price}`);

            function onQuantityChanged() {
                let quantity = parseInt(this.value);
                if (isNaN(quantity)) {
                    quantity = 0;
                }
                mo");
                WriteLiteral(@"dalItemTotalLabel.html(`Total: : ${quantity * price}`);
            }

            modalItemQuantityInput.on('keyup', onQuantityChanged);
            modalItemQuantityInput.on('change', onQuantityChanged);

            setInitialQuantityAndTotalPrice(itemId, price);
            cartModal.modal('show')
        }

        function setInitialQuantityAndTotalPrice(itemId) {
            const cart = getCart();
            const i = indexOfItemInCart(cart, itemId);
            if (i >= 0) {
                modalItemQuantityInput.val(cart[i].quantity + 1);
            }
            else {
                modalItemQuantityInput.val(1);
            }
            modalItemQuantityInput.trigger(""change"");
        }

        function indexOfItemInCart(cart, itemId) {
            for (const i in cart) {
                const cartItem = cart[i];

                if (cartItem.itemId === itemId) {
                    return i;
                }
            }

            return -1;
        }

        function ");
                WriteLiteral(@"updateOrAddToCart(cart, item) {
            var i = indexOfItemInCart(cart, item.itemId);
            if (i >= 0) {
                cart[i].quantity = item.quantity;
            }
            else {
                cart.push(item);
            }
        }

        function getCart() {
            return JSON.parse(localStorage.getItem('cart')) || [];
        }

        $('#save').on('click', function () {
            const elementId = modalItemNameLabel.data(""elementId"");
            const itemElement = $(`#${elementId}`);

            const price = parseInt(itemElement.data(""price""));
            const name = itemElement.data(""name"");
            const quantity = parseInt(modalItemQuantityInput.val());
            const itemId = itemElement.data(""id"");

            const item = { itemId, name, quantity, price };
            const cart = getCart();
            updateOrAddToCart(cart, item);
            updateCart(cart);
            updateCartMenu();
            cartModal.modal('toggle');
        });

   ");
                WriteLiteral(@"     function updateCart(cart) {
            localStorage.setItem('cart', JSON.stringify(cart));
        }

        function updateCartMenu() {
            const cart = getCart();
            let elements = '';
            let totalPrice = 0;
            cart.forEach(item => {
                itemTotalPrice = item.quantity * item.price;
                totalPrice += itemTotalPrice;
                elements += `<a class=""dropdown-item"" href=""#"">${item.name} - ${item.price} ${item.quantity} - ${itemTotalPrice}</a>`
            });
            elements += `<a class=""dropdown-item"" href=""#"">${totalPrice}</a>`
            cartMenu.html(elements);
            var totalQuantity = getTotalQuantity();
            totalQuantityLabel.html(totalQuantity);
        }
        updateCartMenu();

        function getTotalQuantity() {
            const cart = getCart();
            let sum = 0;
            cart.forEach(item => {
                sum += item.quantity;
            });
            return sum;
        }

   ");
                WriteLiteral(@"     function clearCart() {
            const cart = [];
            updateCart(cart);
        }

        function deleteItemFromCart(itemId, cart) {
            const i = indexOfItemInCart(cart, itemId);
            if (i > -1) {
                array.splice(i, 1);
            }
            updateCart(cart);
            updateCartMenu();
        }


        $(document).ready(function () {
            $('[data-toggle=""popover""]').popover();
        });

");
                WriteLiteral("\n\n    </script>\n");
            }
            );
            WriteLiteral("\n\n\n\n");
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
