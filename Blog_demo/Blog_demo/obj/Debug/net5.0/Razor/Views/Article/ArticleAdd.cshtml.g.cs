#pragma checksum "C:\Users\SYM DMR\source\repos\Blog_demo\Blog_demo\Views\Article\ArticleAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c6a35704ac81a5d288bda66e599bd71ff8e4444"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Article_ArticleAdd), @"mvc.1.0.view", @"/Views/Article/ArticleAdd.cshtml")]
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
#line 1 "C:\Users\SYM DMR\source\repos\Blog_demo\Blog_demo\Views\_ViewImports.cshtml"
using Blog_demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SYM DMR\source\repos\Blog_demo\Blog_demo\Views\_ViewImports.cshtml"
using Blog_demo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c6a35704ac81a5d288bda66e599bd71ff8e4444", @"/Views/Article/ArticleAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a5a00a55bac0f9f4dcfda7e3d4ec7207c637e9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Article_ArticleAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Article>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\SYM DMR\source\repos\Blog_demo\Blog_demo\Views\Article\ArticleAdd.cshtml"
  
    ViewData["Title"] = "ArticleAdd";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ArticleAdd</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\SYM DMR\source\repos\Blog_demo\Blog_demo\Views\Article\ArticleAdd.cshtml"
 using (Html.BeginForm())
{
   


#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n        <li>\r\n            ");
#nullable restore
#line 15 "C:\Users\SYM DMR\source\repos\Blog_demo\Blog_demo\Views\Article\ArticleAdd.cshtml"
       Write(Html.Label("Yazı Başlığı"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n            ");
#nullable restore
#line 16 "C:\Users\SYM DMR\source\repos\Blog_demo\Blog_demo\Views\Article\ArticleAdd.cshtml"
       Write(Html.TextBoxFor(x => x.ArticleTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n            ");
#nullable restore
#line 17 "C:\Users\SYM DMR\source\repos\Blog_demo\Blog_demo\Views\Article\ArticleAdd.cshtml"
       Write(Html.Label("Yazarı"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n            ");
#nullable restore
#line 18 "C:\Users\SYM DMR\source\repos\Blog_demo\Blog_demo\Views\Article\ArticleAdd.cshtml"
       Write(Html.TextBoxFor(x => x.WriterName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n            ");
#nullable restore
#line 19 "C:\Users\SYM DMR\source\repos\Blog_demo\Blog_demo\Views\Article\ArticleAdd.cshtml"
       Write(Html.Label("Kategorisi"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n            ");
#nullable restore
#line 20 "C:\Users\SYM DMR\source\repos\Blog_demo\Blog_demo\Views\Article\ArticleAdd.cshtml"
       Write(Html.TextBoxFor(x => x.Categories));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
            WriteLiteral("\r\n        </li>\r\n\r\n    </ul>\r\n    <input type=\"submit\" value=\"Kaydet\" />\r\n");
#nullable restore
#line 28 "C:\Users\SYM DMR\source\repos\Blog_demo\Blog_demo\Views\Article\ArticleAdd.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Article> Html { get; private set; }
    }
}
#pragma warning restore 1591
