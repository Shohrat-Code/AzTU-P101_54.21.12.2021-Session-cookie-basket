#pragma checksum "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\54.21.12.2021-Session, cookie, basket\Codes\OneHealth\OneHealth\Views\News\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30607ca50d7a99f439592f3ca3fe99ce8bfe041c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Index), @"mvc.1.0.view", @"/Views/News/Index.cshtml")]
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
#line 1 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\54.21.12.2021-Session, cookie, basket\Codes\OneHealth\OneHealth\Views\_ViewImports.cshtml"
using OneHealth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\54.21.12.2021-Session, cookie, basket\Codes\OneHealth\OneHealth\Views\_ViewImports.cshtml"
using OneHealth.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\54.21.12.2021-Session, cookie, basket\Codes\OneHealth\OneHealth\Views\_ViewImports.cshtml"
using OneHealth.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\54.21.12.2021-Session, cookie, basket\Codes\OneHealth\OneHealth\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30607ca50d7a99f439592f3ca3fe99ce8bfe041c", @"/Views/News/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7885a7453245dfc02cf1556aec42e1a631756a6", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_bannerPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\54.21.12.2021-Session, cookie, basket\Codes\OneHealth\OneHealth\Views\News\Index.cshtml"
  
    ViewData["Title"] = "Index";

    VmBannerPartial bannerPartial = new VmBannerPartial()
    {
        Title = "News",
        Breadcrum = "Blog"
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "30607ca50d7a99f439592f3ca3fe99ce8bfe041c5460", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 12 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\54.21.12.2021-Session, cookie, basket\Codes\OneHealth\OneHealth\Views\News\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = bannerPartial;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""page-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8"">
                <div class=""row"">
                    <div class=""col-sm-6 py-3"">
                        <div class=""card-blog"">
                            <div class=""header"">
                                <div class=""post-category"">
                                    <a href=""#"">Covid19</a>
                                </div>
                                <a href=""blog-details"" class=""post-thumb"">
                                    <img src=""../assets/img/blog/blog_1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 851, "\"", 857, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""body"">
                                <h5 class=""post-title""><a href=""blog-details.html"">List of Countries without Coronavirus case</a></h5>
                                <div class=""site-info"">
                                    <div class=""avatar mr-2"">
                                        <div class=""avatar-img"">
                                            <img src=""../assets/img/person/person_1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1393, "\"", 1399, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <span>Roger Adams</span>
                                    </div>
                                    <span class=""mai-time""></span> 1 week ago
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""col-sm-6 py-3"">
                        <div class=""card-blog"">
                            <div class=""header"">
                                <div class=""post-category"">
                                    <a href=""#"">Dental</a>
                                </div>
                                <a href=""blog-details"" class=""post-thumb"">
                                    <img src=""../assets/img/blog/blog_3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2239, "\"", 2245, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""body"">
                                <h5 class=""post-title""><a href=""blog-details.html"">What is the impact of eating too much sugar?</a></h5>
                                <div class=""site-info"">
                                    <div class=""avatar mr-2"">
                                        <div class=""avatar-img"">
                                            <img src=""../assets/img/person/person_4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2783, "\"", 2789, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <span>Wizdom Jack</span>
                                    </div>
                                    <span class=""mai-time""></span> 2 weeks ago
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""col-sm-6 py-3"">
                        <div class=""card-blog"">
                            <div class=""header"">
                                <div class=""post-category"">
                                    <a href=""#"">Covid19</a>
                                </div>
                                <a href=""blog-details"" class=""post-thumb"">
                                    <img src=""../assets/img/blog/blog_3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3631, "\"", 3637, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""body"">
                                <h5 class=""post-title""><a href=""blog-details.html"">Shifting goalposts: Research in the time of the coronavirus</a></h5>
                                <div class=""site-info"">
                                    <div class=""avatar mr-2"">
                                        <div class=""avatar-img"">
                                            <img src=""../assets/img/person/person_3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4190, "\"", 4196, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <span>Adams Collier</span>
                                    </div>
                                    <span class=""mai-time""></span> 4 weeks ago
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-sm-6 py-3"">
                        <div class=""card-blog"">
                            <div class=""header"">
                                <div class=""post-category"">
                                    <a href=""#"">Neurology</a>
                                </div>
                                <a href=""blog-details"" class=""post-thumb"">
                                    <img src=""../assets/img/blog/blog_4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5040, "\"", 5046, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""body"">
                                <h5 class=""post-title""><a href=""blog-details.html"">What are the nonmedical factors most closely linked to death risk?</a></h5>
                                <div class=""site-info"">
                                    <div class=""avatar mr-2"">
                                        <div class=""avatar-img"">
                                            <img src=""../assets/img/person/person_1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5606, "\"", 5612, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <span>Roger Adams</span>
                                    </div>
                                    <span class=""mai-time""></span> 4 weeks ago
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-sm-6 py-3"">
                        <div class=""card-blog"">
                            <div class=""header"">
                                <div class=""post-category"">
                                    <a href=""#"">Cardiology</a>
                                </div>
                                <a href=""blog-details"" class=""post-thumb"">
                                    <img src=""../assets/img/blog/blog_5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6455, "\"", 6461, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""body"">
                                <h5 class=""post-title""><a href=""blog-details.html"">Do gut bacteria contribute to ethnic health disparities</a></h5>
                                <div class=""site-info"">
                                    <div class=""avatar mr-2"">
                                        <div class=""avatar-img"">
                                            <img src=""../assets/img/person/person_1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7010, "\"", 7016, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <span>Roger Adams</span>
                                    </div>
                                    <span class=""mai-time""></span> 4 weeks ago
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-sm-6 py-3"">
                        <div class=""card-blog"">
                            <div class=""header"">
                                <div class=""post-category"">
                                    <a href=""#"">Patient Services</a>
                                </div>
                                <a href=""blog-details"" class=""post-thumb"">
                                    <img src=""../assets/img/blog/blog_1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7865, "\"", 7871, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""body"">
                                <h5 class=""post-title""><a href=""blog-details.html"">The Recovery Room: News beyond the pandemic</a></h5>
                                <div class=""site-info"">
                                    <div class=""avatar mr-2"">
                                        <div class=""avatar-img"">
                                            <img src=""../assets/img/person/person_1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8408, "\"", 8414, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <span>Roger Adams</span>
                                    </div>
                                    <span class=""mai-time""></span> 1 month ago
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-sm-6 py-3"">
                        <div class=""card-blog"">
                            <div class=""header"">
                                <div class=""post-category"">
                                    <a href=""#"">General Health</a>
                                </div>
                                <a href=""blog-details"" class=""post-thumb"">
                                    <img src=""../assets/img/blog/blog_2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9261, "\"", 9267, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""body"">
                                <h5 class=""post-title""><a href=""blog-details.html"">Racism in mental healthcare: An invisible barrier</a></h5>
                                <div class=""site-info"">
                                    <div class=""avatar mr-2"">
                                        <div class=""avatar-img"">
                                            <img src=""../assets/img/person/person_1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9810, "\"", 9816, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <span>Roger Adams</span>
                                    </div>
                                    <span class=""mai-time""></span> 2 months ago
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""col-sm-6 py-3"">
                        <div class=""card-blog"">
                            <div class=""header"">
                                <div class=""post-category"">
                                    <a href=""#"">Covid19</a>
                                </div>
                                <a href=""blog-details"" class=""post-thumb"">
                                    <img src=""../assets/img/blog/blog_2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10659, "\"", 10665, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""body"">
                                <h5 class=""post-title""><a href=""blog-details.html"">COVID-19 live updates: Total number of cases passes 11.6 million</a></h5>
                                <div class=""site-info"">
                                    <div class=""avatar mr-2"">
                                        <div class=""avatar-img"">
                                            <img src=""../assets/img/person/person_2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11223, "\"", 11229, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <span>Diego Simmons</span>
                                    </div>
                                    <span class=""mai-time""></span> 4 weeks ago
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""col-12 my-5"">
                        <nav aria-label=""Page Navigation"">
                            <ul class=""pagination justify-content-center"">
                                <li class=""page-item disabled"">
                                    <a class=""page-link"" href=""#"" tabindex=""-1"" aria-disabled=""true"">Previous</a>
                                </li>
                                <li class=""page-item active"" aria-current=""page"">
                                    <a class=""page-link"" href=""#"">1 <span class=""sr-only"">(current)</span></a>
                                </li>
       ");
            WriteLiteral(@"                         <li class=""page-item"">
                                    <a class=""page-link"" href=""#"">2</a>
                                </li>
                                <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                                <li class=""page-item"">
                                    <a class=""page-link"" href=""#"">Next</a>
                                </li>
                            </ul>
                        </nav>
                    </div>
                </div> <!-- .row -->
            </div>
            <div class=""col-lg-4"">
                <div class=""sidebar"">
                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Search</h3>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30607ca50d7a99f439592f3ca3fe99ce8bfe041c22373", async() => {
                WriteLiteral(@"
                            <div class=""form-group"">
                                <input type=""text"" class=""form-control"" placeholder=""Type a keyword and hit enter"">
                                <button type=""submit"" class=""btn""><span class=""icon mai-search""></span></button>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Categories</h3>
                        <ul class=""categories"">
                            <li><a href=""#"">Food <span>12</span></a></li>
                            <li><a href=""#"">Dish <span>22</span></a></li>
                            <li><a href=""#"">Desserts <span>37</span></a></li>
                            <li><a href=""#"">Drinks <span>42</span></a></li>
                            <li><a href=""#"">Ocassion <span>14</span></a></li>
                        </ul>
                    </div>

                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Recent Blog</h3>
                        <div class=""blog-item"">
                            <a class=""post-thumb""");
            BeginWriteAttribute("href", " href=\"", 14293, "\"", 14300, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"../assets/img/blog/blog_1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 14376, "\"", 14382, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <div class=""content"">
                                <h5 class=""post-title""><a href=""#"">Even the all-powerful Pointing has no control</a></h5>
                                <div class=""meta"">
                                    <a href=""#""><span class=""mai-calendar""></span> July 12, 2018</a>
                                    <a href=""#""><span class=""mai-person""></span> Admin</a>
                                    <a href=""#""><span class=""mai-chatbubbles""></span> 19</a>
                                </div>
                            </div>
                        </div>
                        <div class=""blog-item"">
                            <a class=""post-thumb""");
            BeginWriteAttribute("href", " href=\"", 15140, "\"", 15147, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"../assets/img/blog/blog_2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 15223, "\"", 15229, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <div class=""content"">
                                <h5 class=""post-title""><a href=""#"">Even the all-powerful Pointing has no control</a></h5>
                                <div class=""meta"">
                                    <a href=""#""><span class=""mai-calendar""></span> July 12, 2018</a>
                                    <a href=""#""><span class=""mai-person""></span> Admin</a>
                                    <a href=""#""><span class=""mai-chatbubbles""></span> 19</a>
                                </div>
                            </div>
                        </div>
                        <div class=""blog-item"">
                            <a class=""post-thumb""");
            BeginWriteAttribute("href", " href=\"", 15987, "\"", 15994, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"../assets/img/blog/blog_3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 16070, "\"", 16076, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <div class=""content"">
                                <h5 class=""post-title""><a href=""#"">Even the all-powerful Pointing has no control</a></h5>
                                <div class=""meta"">
                                    <a href=""#""><span class=""mai-calendar""></span> July 12, 2018</a>
                                    <a href=""#""><span class=""mai-person""></span> Admin</a>
                                    <a href=""#""><span class=""mai-chatbubbles""></span> 19</a>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Tag Cloud</h3>
                        <div class=""tagcloud"">
                            <a href=""#"" class=""tag-cloud-link"">dish</a>
                            <a href=""#"" class=""tag-cloud-link"">menu</a>
                          ");
            WriteLiteral(@"  <a href=""#"" class=""tag-cloud-link"">food</a>
                            <a href=""#"" class=""tag-cloud-link"">sweet</a>
                            <a href=""#"" class=""tag-cloud-link"">tasty</a>
                            <a href=""#"" class=""tag-cloud-link"">delicious</a>
                            <a href=""#"" class=""tag-cloud-link"">desserts</a>
                            <a href=""#"" class=""tag-cloud-link"">drinks</a>
                        </div>
                    </div>

                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Paragraph</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ducimus itaque, autem necessitatibus voluptate quod mollitia delectus aut, sunt placeat nam vero culpa sapiente consectetur similique, inventore eos fugit cupiditate numquam!</p>
                    </div>
                </div>
            </div>
        </div> <!-- .row -->
    </div> <!-- .container -->
</div> <!-- .page-secti");
            WriteLiteral("on -->");
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