#pragma checksum "C:\Users\Led\Desktop (2)\ASP course\Bookss Add done\Bookss Add done\Bookss\Views\Items\ItemList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "708b108a1dfbf36ce9bfeed8ea2f693059e75a38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_ItemList), @"mvc.1.0.view", @"/Views/Items/ItemList.cshtml")]
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
#line 1 "C:\Users\Led\Desktop (2)\ASP course\Bookss Add done\Bookss Add done\Bookss\Views\_ViewImports.cshtml"
using Bookss.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Led\Desktop (2)\ASP course\Bookss Add done\Bookss Add done\Bookss\Views\_ViewImports.cshtml"
using Domains;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"708b108a1dfbf36ce9bfeed8ea2f693059e75a38", @"/Views/Items/ItemList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bfd7c89201beff647fea99eb283ade503924936", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_ItemList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Modules/Helper.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Modules/ClsItems.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Modules/ClsCategory.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Led\Desktop (2)\ASP course\Bookss Add done\Bookss Add done\Bookss\Views\Items\ItemList.cshtml"
  
    ViewData["Title"] = "ItemList";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""ht__bradcaump__area bg-image--6"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""bradcaump__inner text-center"">
                    <h2 class=""bradcaump-title"">Shop Grid</h2>
                    <nav class=""bradcaump-content"">
                        <a class=""breadcrumb_item"" href=""index.html"">Home</a>
                        <span class=""brd-separetor"">/</span>
                        <span class=""breadcrumb_item active"">Shop Grid</span>
                    </nav>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""page-shop-sidebar left--sidebar bg--white section-padding--lg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3 col-12 order-2 order-lg-1 md-mt-40 sm-mt-40"">
                <div class=""shop__sidebar"">
                    <aside class=""wedget__categories poroduct--cat"">
                        <h3 class=""wedget__titl");
            WriteLiteral(@"e"">Product Categories</h3>
                        <ul id=""Categories"">
                        </ul>
                    </aside>
                </div>
            </div>
            <div class=""col-lg-9 col-12 order-1 order-lg-2"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""shop__list__wrapper d-flex flex-wrap flex-md-nowrap justify-content-between"">
                            <div class=""shop__list nav justify-content-center"" role=""tablist"">
                                <a class=""nav-item nav-link active"" data-toggle=""tab"" href=""#nav-grid"" role=""tab""><i class=""fa fa-th""></i></a>
                                <a class=""nav-item nav-link"" data-toggle=""tab"" href=""#nav-list"" role=""tab""><i class=""fa fa-list""></i></a>
                            </div>
                            <p>Showing 1–12 of 40 results</p>
                            <div class=""orderby__wrapper"">
                                <span>Sort By</spa");
            WriteLiteral("n>\r\n                                <select class=\"shot__byselect\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "708b108a1dfbf36ce9bfeed8ea2f693059e75a386923", async() => {
                WriteLiteral("Default sorting");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "708b108a1dfbf36ce9bfeed8ea2f693059e75a387926", async() => {
                WriteLiteral("HeadPhone");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "708b108a1dfbf36ce9bfeed8ea2f693059e75a388923", async() => {
                WriteLiteral("Furniture");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "708b108a1dfbf36ce9bfeed8ea2f693059e75a389920", async() => {
                WriteLiteral("Jewellery");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "708b108a1dfbf36ce9bfeed8ea2f693059e75a3810917", async() => {
                WriteLiteral("Handmade");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "708b108a1dfbf36ce9bfeed8ea2f693059e75a3811914", async() => {
                WriteLiteral("Kids");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </select>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""tab__container"">
                    <div class=""shop-grid tab-pane fade show active"" id=""nav-grid"" role=""tabpanel"">
                        <div id=""DivTemplate1"" class=""row"">

                        </div>
                        <ul class=""wn__pagination"">
                            <li class=""active""><a href=""#"">1</a></li>
                            <li><a href=""#"">2</a></li>
                            <li><a href=""#"">3</a></li>
                            <li><a href=""#"">4</a></li>
                            <li><a href=""#""><i class=""zmdi zmdi-chevron-right""></i></a></li>
                        </ul>
                    </div>

                    <div class=""shop-grid tab-pane fade"" id=""nav-list"" role=""tabpanel"">
                        <div class=""list__view__wrapper"">
                      ");
            WriteLiteral(@"      <!-- Start Single Product -->
                            <div class=""list__view"">
                                <div class=""thumb"">
                                    <a class=""first__img"" href=""single-product.html""><img src=""images/product/1.jpg"" alt=""product images""></a>
                                    <a class=""second__img animation1"" href=""single-product.html""><img src=""images/product/2.jpg"" alt=""product images""></a>
                                </div>
                                <div class=""content"">
                                    <h2><a href=""single-product.html"">Ali Smith</a></h2>
                                    <ul class=""rating d-flex"">
                                        <li class=""on""><i class=""fa fa-star-o""></i></li>
                                        <li class=""on""><i class=""fa fa-star-o""></i></li>
                                        <li class=""on""><i class=""fa fa-star-o""></i></li>
                                        <li class=""on""><i cla");
            WriteLiteral(@"ss=""fa fa-star-o""></i></li>
                                        <li><i class=""fa fa-star-o""></i></li>
                                        <li><i class=""fa fa-star-o""></i></li>
                                    </ul>
                                    <ul class=""prize__box"">
                                        <li>$111.00</li>
                                        <li class=""old__prize"">$220.00</li>
                                    </ul>
                                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam fringilla augue nec est tristique auctor. Donec non est at libero vulputate rutrum. Morbi ornare lectus quis justo gravida semper. Nulla tellus mi, vulputate adipiscing cursus eu, suscipit id nulla.</p>
                                    <ul class=""cart__action d-flex"">
                                        <li class=""cart""><a href=""cart.html"">Add to cart</a></li>
                                        <li class=""wishlist""><a href=""cart.html""><");
            WriteLiteral(@"/a></li>
                                        <li class=""compare""><a href=""cart.html""></a></li>
                                    </ul>

                                </div>
                            </div>
                            <!-- End Single Product -->
                            <!-- Start Single Product -->
                            <div class=""list__view mt--40"">
                                <div class=""thumb"">
                                    <a class=""first__img"" href=""single-product.html""><img src=""images/product/2.jpg"" alt=""product images""></a>
                                    <a class=""second__img animation1"" href=""single-product.html""><img src=""images/product/4.jpg"" alt=""product images""></a>
                                </div>
                                <div class=""content"">
                                    <h2><a href=""single-product.html"">Blood In Water</a></h2>
                                    <ul class=""rating d-flex"">
                  ");
            WriteLiteral(@"                      <li class=""on""><i class=""fa fa-star-o""></i></li>
                                        <li class=""on""><i class=""fa fa-star-o""></i></li>
                                        <li class=""on""><i class=""fa fa-star-o""></i></li>
                                        <li class=""on""><i class=""fa fa-star-o""></i></li>
                                        <li><i class=""fa fa-star-o""></i></li>
                                        <li><i class=""fa fa-star-o""></i></li>
                                    </ul>
                                    <ul class=""prize__box"">
                                        <li>$111.00</li>
                                        <li class=""old__prize"">$220.00</li>
                                    </ul>
                                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam fringilla augue nec est tristique auctor. Donec non est at libero vulputate rutrum. Morbi ornare lectus quis justo gravida semper. Nulla tellu");
            WriteLiteral(@"s mi, vulputate adipiscing cursus eu, suscipit id nulla.</p>
                                    <ul class=""cart__action d-flex"">
                                        <li class=""cart""><a href=""cart.html"">Add to cart</a></li>
                                        <li class=""wishlist""><a href=""cart.html""></a></li>
                                        <li class=""compare""><a href=""cart.html""></a></li>
                                    </ul>

                                </div>
                            </div>
                            <!-- End Single Product -->
                            <!-- Start Single Product -->
                            <div class=""list__view mt--40"">
                                <div class=""thumb"">
                                    <a class=""first__img"" href=""single-product.html""><img src=""images/product/3.jpg"" alt=""product images""></a>
                                    <a class=""second__img animation1"" href=""single-product.html""><img src=""images/p");
            WriteLiteral(@"roduct/6.jpg"" alt=""product images""></a>
                                </div>
                                <div class=""content"">
                                    <h2><a href=""single-product.html"">Madeness Overated</a></h2>
                                    <ul class=""rating d-flex"">
                                        <li class=""on""><i class=""fa fa-star-o""></i></li>
                                        <li class=""on""><i class=""fa fa-star-o""></i></li>
                                        <li class=""on""><i class=""fa fa-star-o""></i></li>
                                        <li class=""on""><i class=""fa fa-star-o""></i></li>
                                        <li><i class=""fa fa-star-o""></i></li>
                                        <li><i class=""fa fa-star-o""></i></li>
                                    </ul>
                                    <ul class=""prize__box"">
                                        <li>$111.00</li>
                                        <li cl");
            WriteLiteral(@"ass=""old__prize"">$220.00</li>
                                    </ul>
                                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam fringilla augue nec est tristique auctor. Donec non est at libero vulputate rutrum. Morbi ornare lectus quis justo gravida semper. Nulla tellus mi, vulputate adipiscing cursus eu, suscipit id nulla.</p>
                                    <ul class=""cart__action d-flex"">
                                        <li class=""cart""><a href=""cart.html"">Add to cart</a></li>
                                        <li class=""wishlist""><a href=""cart.html""></a></li>
                                        <li class=""compare""><a href=""cart.html""></a></li>
                                    </ul>

                                </div>
                            </div>
                            <!-- End Single Product -->
                            <!-- Start Single Product -->
                            <div class=""list__view mt--40");
            WriteLiteral(@""">
                                <div class=""thumb"">
                                    <a class=""first__img"" href=""single-product.html""><img src=""images/product/4.jpg"" alt=""product images""></a>
                                    <a class=""second__img animation1"" href=""single-product.html""><img src=""images/product/6.jpg"" alt=""product images""></a>
                                </div>
                                <div class=""content"">
                                    <h2><a href=""single-product.html"">Watching You</a></h2>
                                    <ul class=""rating d-flex"">
                                        <li class=""on""><i class=""fa fa-star-o""></i></li>
                                        <li class=""on""><i class=""fa fa-star-o""></i></li>
                                        <li class=""on""><i class=""fa fa-star-o""></i></li>
                                        <li class=""on""><i class=""fa fa-star-o""></i></li>
                                        <li><i class=""f");
            WriteLiteral(@"a fa-star-o""></i></li>
                                        <li><i class=""fa fa-star-o""></i></li>
                                    </ul>
                                    <ul class=""prize__box"">
                                        <li>$111.00</li>
                                        <li class=""old__prize"">$220.00</li>
                                    </ul>
                                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam fringilla augue nec est tristique auctor. Donec non est at libero vulputate rutrum. Morbi ornare lectus quis justo gravida semper. Nulla tellus mi, vulputate adipiscing cursus eu, suscipit id nulla.</p>
                                    <ul class=""cart__action d-flex"">
                                        <li class=""cart""><a href=""cart.html"">Add to cart</a></li>
                                        <li class=""wishlist""><a href=""cart.html""></a></li>
                                        <li class=""compare""><a href=""cart.");
            WriteLiteral(@"html""></a></li>
                                    </ul>

                                </div>
                            </div>
                            <!-- End Single Product -->
                            <!-- Start Single Product -->
                            <div class=""list__view mt--40"">
                                <div class=""thumb"">
                                    <a class=""first__img"" href=""single-product.html""><img src=""images/product/5.jpg"" alt=""product images""></a>
                                    <a class=""second__img animation1"" href=""single-product.html""><img src=""images/product/9.jpg"" alt=""product images""></a>
                                </div>
                                <div class=""content"">
                                    <h2><a href=""single-product.html"">Court Wings Run</a></h2>
                                    <ul class=""rating d-flex"">
                                        <li class=""on""><i class=""fa fa-star-o""></i></li>
           ");
            WriteLiteral(@"                             <li class=""on""><i class=""fa fa-star-o""></i></li>
                                        <li class=""on""><i class=""fa fa-star-o""></i></li>
                                        <li class=""on""><i class=""fa fa-star-o""></i></li>
                                        <li><i class=""fa fa-star-o""></i></li>
                                        <li><i class=""fa fa-star-o""></i></li>
                                    </ul>
                                    <ul class=""prize__box"">
                                        <li>$111.00</li>
                                        <li class=""old__prize"">$220.00</li>
                                    </ul>
                                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam fringilla augue nec est tristique auctor. Donec non est at libero vulputate rutrum. Morbi ornare lectus quis justo gravida semper. Nulla tellus mi, vulputate adipiscing cursus eu, suscipit id nulla.</p>
                     ");
            WriteLiteral(@"               <ul class=""cart__action d-flex"">
                                        <li class=""cart""><a href=""cart.html"">Add to cart</a></li>
                                        <li class=""wishlist""><a href=""cart.html""></a></li>
                                        <li class=""compare""><a href=""cart.html""></a></li>
                                    </ul>
                                </div>
                            </div>
                            <!-- End Single Product -->
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "708b108a1dfbf36ce9bfeed8ea2f693059e75a3826641", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "708b108a1dfbf36ce9bfeed8ea2f693059e75a3827741", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "708b108a1dfbf36ce9bfeed8ea2f693059e75a3828841", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
