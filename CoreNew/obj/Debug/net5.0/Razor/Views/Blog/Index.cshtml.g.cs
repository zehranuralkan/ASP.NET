#pragma checksum "C:\Users\HP\source\repos\CoreNew\CoreNew\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a04c36c1847cd15081257b1d9e4a1683cb5787c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\HP\source\repos\CoreNew\CoreNew\Views\_ViewImports.cshtml"
using CoreNew;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\CoreNew\CoreNew\Views\_ViewImports.cshtml"
using CoreNew.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\HP\source\repos\CoreNew\CoreNew\Views\Blog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a04c36c1847cd15081257b1d9e4a1683cb5787c", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dfa8bc43f5fa3eeb5c891e36c2769445d50c5ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\HP\source\repos\CoreNew\CoreNew\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">Bloglar</h3>
        <div class=""inner-sec"">
            <!--left-->
            <div class=""left-blog-info-w3layouts-agileits text-left"">
                <div class=""row"">
");
#nullable restore
#line 15 "C:\Users\HP\source\repos\CoreNew\CoreNew\Views\Blog\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 card\">\n                        <a href=\"single.html\">\n                            <img");
            BeginWriteAttribute("src", " src=\"", 610, "\"", 631, 1);
#nullable restore
#line 19 "C:\Users\HP\source\repos\CoreNew\CoreNew\Views\Blog\Index.cshtml"
WriteAttributeValue("", 616, item.BlogImage, 616, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 663, "\"", 669, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </a>
                        <div class=""card-body"">
                            <ul class=""blog-icons my-4"">
                                <li>
                                    <a href=""#"">
                                        <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 25 "C:\Users\HP\source\repos\CoreNew\CoreNew\Views\Blog\Index.cshtml"
                                                                        Write(((DateTime)item.CreateDate).ToString("dd-MMM-yyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </a>
                                </li> 
                                <li class=""mx-2"">
                                    <a href=""#"">
                                        <i class=""far fa-comment""></i> 0
                                    </a>
                                </li>
                                <li>
                                    <a href=""#"">
                                        <i class=""fas fa-eye""></i> ");
#nullable restore
#line 35 "C:\Users\HP\source\repos\CoreNew\CoreNew\Views\Blog\Index.cshtml"
                                                              Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </a>\n                                </li>\n\n                            </ul>\n                            <h5 class=\"card-title\">\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1734, "\"", 1772, 3);
            WriteAttributeValue("", 1741, "/Blog/BlogReadAll/", 1741, 18, true);
#nullable restore
#line 41 "C:\Users\HP\source\repos\CoreNew\CoreNew\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1759, item.BlogID, 1759, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1771, "/", 1771, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 41 "C:\Users\HP\source\repos\CoreNew\CoreNew\Views\Blog\Index.cshtml"
                                                                     Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                            </h5>\n                            <p class=\"card-text mb-3\">");
#nullable restore
#line 43 "C:\Users\HP\source\repos\CoreNew\CoreNew\Views\Blog\Index.cshtml"
                                                 Write(item.BlogContent.Substring(0,item.BlogContent.Substring(0,130).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2001, "\"", 2038, 2);
            WriteAttributeValue("", 2008, "/Blog/BlogReadAll/", 2008, 18, true);
#nullable restore
#line 44 "C:\Users\HP\source\repos\CoreNew\CoreNew\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2026, item.BlogID, 2026, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Devamını Oku</a>\n                        </div>\n                    </div>\n                    <br />\n");
#nullable restore
#line 48 "C:\Users\HP\source\repos\CoreNew\CoreNew\Views\Blog\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n                <!--//left-->\n            </div>\n        </div>\n    </div>\n</section>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
