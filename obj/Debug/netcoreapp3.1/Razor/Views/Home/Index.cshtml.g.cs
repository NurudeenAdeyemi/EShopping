#pragma checksum "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8b399f465ecd7c2be106bfe4d607bc29c26a84c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8b399f465ecd7c2be106bfe4d607bc29c26a84c", @"/Views/Home/Index.cshtml")]
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
            WriteLiteral("\r\n");
            DefineSection("style", async() => {
                WriteLiteral("\r\n    <style>\r\n        .carousel-inner img {\r\n            width: 100%; /* Set width to 100% */\r\n            min-height: 200px;\r\n        }\r\n    </style>\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8b399f465ecd7c2be106bfe4d607bc29c26a84c7695", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8b399f465ecd7c2be106bfe4d607bc29c26a84c9091", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8b399f465ecd7c2be106bfe4d607bc29c26a84c10487", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8b399f465ecd7c2be106bfe4d607bc29c26a84c11882", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8b399f465ecd7c2be106bfe4d607bc29c26a84c13279", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8b399f465ecd7c2be106bfe4d607bc29c26a84c15409", async() => {
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
            WriteLiteral("\r\n        </a>\r\n    </div>\r\n</div>\r\n<br>\r\n\r\n<div class=\"text-center \">\r\n    <p ><h4 class=\"font-weight-light\">Featured Products</h4></p>\r\n    <hr>\r\n</div>\r\n<div class=\"container-fluid text-center\">\r\n    <div class=\"row\">\r\n        <!-- ");
#nullable restore
#line 104 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
              foreach (var item in Model)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("     <div class=\"col-sm-2 border\">\r\n         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8b399f465ecd7c2be106bfe4d607bc29c26a84c17231", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3888, "~/images/", 3888, 9, true);
#nullable restore
#line 107 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3897, item.ItemPictureUrl, 3897, 20, false);

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
            WriteLiteral("\r\n         <p>");
#nullable restore
#line 108 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
       Write(item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n         <p>");
#nullable restore
#line 109 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n         <input type=\"submit\" onclick=\"addToCart(this.id)\"");
            BeginWriteAttribute("id", " id=\"", 4094, "\"", 4116, 2);
            WriteAttributeValue("", 4099, "item-", 4099, 5, true);
#nullable restore
#line 110 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
WriteAttributeValue("", 4104, item.ItemId, 4104, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-name=\"");
#nullable restore
#line 110 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
                                                                                        Write(item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-price=\"");
#nullable restore
#line 110 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
                                                                                                                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-id=\"");
#nullable restore
#line 110 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
                                                                                                                                          Write(item.ItemId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" value=\"ADD TO CART\" class=\"btn btn-sm btn-success\" style=\"width:70%\" />\r\n     </div>\r\n");
#nullable restore
#line 112 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n    </div>\r\n</div>\r\n<hr />\r\n<br />\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-3 border-right\" style=\"height:300px\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 4462, "\"", 4470, 0);
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
                <div class=""row ");
            WriteLiteral("text-center\">\r\n");
#nullable restore
#line 139 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-sm-3 border active img-responsive"">
                            <a href=""#"" title=""Vegebasket"" data-toggle=""popover"" data-trigger=""hover"" data-content=""Click add to cart to enjoy our fresh products"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8b399f465ecd7c2be106bfe4d607bc29c26a84c23141", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5867, "~/images/", 5867, 9, true);
#nullable restore
#line 143 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 5876, item.ItemPictureUrl, 5876, 20, false);

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
            WriteLiteral("</a>\r\n                            <p class=\"mb-0\">");
#nullable restore
#line 144 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
                                       Write(item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p>&#8358 ");
#nullable restore
#line 145 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
                                 Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                            <button type=\"submit\" onclick=\"addToCart(this.id)\"");
            BeginWriteAttribute("id", " id=\"", 6156, "\"", 6178, 2);
            WriteAttributeValue("", 6161, "item-", 6161, 5, true);
#nullable restore
#line 146 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
WriteAttributeValue("", 6166, item.ItemId, 6166, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-name=\"");
#nullable restore
#line 146 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
                                                                                                            Write(item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-price=\"");
#nullable restore
#line 146 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
                                                                                                                                        Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-id=\"");
#nullable restore
#line 146 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
                                                                                                                                                              Write(item.ItemId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-sm btn-outline-success font-weight-bold\" style=\"width:70%\"><span class=\"spinner-grow spinner-grow-sm\"></span><small>ADD TO CART</small></button>\r\n                        </div>\r\n");
#nullable restore
#line 148 "C:\Users\nurudeen\source\repos\EShopping\Views\Home\Index.cshtml"
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
                        <div class=""col-sm-4");
            WriteLiteral(@""">
                             &#8358 <h5 id=""item-price"" class=""text-dark font-weight-light""></h5>
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

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>
    function addToCart(id)
    {
        $('#cart-modal').modal('show')
        let price = parseInt($('#' + id).attr(""data-price""));
        let name = $('#' + id).attr(""data-name"");
        $('#item-name').attr(""data-id"", id);
        document.querySelector('#item-name').innerHTML = name;
        document.querySelector('#item-price').innerHTML = 'Unit Price '+ price;
        $('#quantity').on('change', function () {
            let quantity = parseInt(document.querySelector('#quantity').value)
            document.querySelector('#item-total').innerHTML ='Total' + ( quantity * price);
        });
    }

    $('#save').on('click', function () {
        let id = $('#item-name').attr(""data-id"");
        let price = parseInt($('#' + id).attr(""data-price""));
        let name = $('#' + id).attr(""data-name"");
        let quantity = parseInt(document.querySelector('#quantity').value)
        const item = { id, name, quantity, price };
        let cart = JSON.parse(localStorage.getItem");
                WriteLiteral(@"('cart')) || [];
        cart.push(item);
        localStorage.setItem('cart', JSON.stringify(cart));
        $('#cart-modal').modal('toggle');
        updateCartMenu();
    });

    function updateCartMenu() {
        let cart = JSON.parse(localStorage.getItem('cart')) || [];
        let cartMenu = document.querySelector('#cart-menu');
        let elements = ``;
        cart.forEach(item => {
            elements += `<a class=""dropdown-item"" href=""#"">${item.name}- ${item.price} ${item.quantity}</a>`
        });
        cartMenu.innerHTML = elements;
    }
    updateCartMenu();


    $(document).ready(function () {
        $('[data-toggle=""popover""]').popover();
    });
</script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
