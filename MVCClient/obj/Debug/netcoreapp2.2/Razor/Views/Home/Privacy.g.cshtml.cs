#pragma checksum "C:\Users\Администратор\source\repos\KeycloakClient\MVCClient\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dc400e2ff6dcfc64bd0e6d0322408714b8a0f60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy))]
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
#line 1 "C:\Users\Администратор\source\repos\KeycloakClient\MVCClient\Views\_ViewImports.cshtml"
using MVCClient;

#line default
#line hidden
#line 2 "C:\Users\Администратор\source\repos\KeycloakClient\MVCClient\Views\_ViewImports.cshtml"
using MVCClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dc400e2ff6dcfc64bd0e6d0322408714b8a0f60", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e6d0ae0c9d7e6e45ee166fce82a68c9aa028843", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Администратор\source\repos\KeycloakClient\MVCClient\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
            BeginContext(50, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(55, 17, false);
#line 4 "C:\Users\Администратор\source\repos\KeycloakClient\MVCClient\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(72, 76, true);
            WriteLiteral("</h1>\r\n\r\n<p>Use this page to detail your site\'s privacy policy.</p>\r\n<div>\r\n");
            EndContext();
#line 8 "C:\Users\Администратор\source\repos\KeycloakClient\MVCClient\Views\Home\Privacy.cshtml"
     foreach (var c in ViewBag.Claims)
    {

#line default
#line hidden
            BeginContext(195, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(207, 6, false);
#line 10 "C:\Users\Администратор\source\repos\KeycloakClient\MVCClient\Views\Home\Privacy.cshtml"
      Write(c.Type);

#line default
#line hidden
            EndContext();
            BeginContext(213, 3, true);
            WriteLiteral(" : ");
            EndContext();
            BeginContext(217, 7, false);
#line 10 "C:\Users\Администратор\source\repos\KeycloakClient\MVCClient\Views\Home\Privacy.cshtml"
                Write(c.Value);

#line default
#line hidden
            EndContext();
            BeginContext(224, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 11 "C:\Users\Администратор\source\repos\KeycloakClient\MVCClient\Views\Home\Privacy.cshtml"
    }

#line default
#line hidden
            BeginContext(237, 6, true);
            WriteLiteral("</div>");
            EndContext();
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
