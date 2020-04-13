#pragma checksum "C:\Users\mdubose\source\repos\CoffeeShop\IceCreamShop\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cf65fc76926a3757e97868d350cad6374a523e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\mdubose\source\repos\CoffeeShop\IceCreamShop\Views\_ViewImports.cshtml"
using IceCreamShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mdubose\source\repos\CoffeeShop\IceCreamShop\Views\_ViewImports.cshtml"
using IceCreamShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cf65fc76926a3757e97868d350cad6374a523e5", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc630d9cdf6a83693066163de1fb3425a64dffe5", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\mdubose\source\repos\CoffeeShop\IceCreamShop\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Admin Index";
    List<Product> Products = (List<Product>)ViewData["Products"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Product Administration**</h1>\r\n");
#nullable restore
#line 8 "C:\Users\mdubose\source\repos\CoffeeShop\IceCreamShop\Views\Admin\Index.cshtml"
 if (TempData["UserMsg"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 10 "C:\Users\mdubose\source\repos\CoffeeShop\IceCreamShop\Views\Admin\Index.cshtml"
  Write(TempData["UserMsg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 11 "C:\Users\mdubose\source\repos\CoffeeShop\IceCreamShop\Views\Admin\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div><a href=\"/Admin/AddForm\">Add</a></div>\r\n\r\n\r\n\r\n");
#nullable restore
#line 18 "C:\Users\mdubose\source\repos\CoffeeShop\IceCreamShop\Views\Admin\Index.cshtml"
 foreach (Product p in Products)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 21 "C:\Users\mdubose\source\repos\CoffeeShop\IceCreamShop\Views\Admin\Index.cshtml"
   Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 21 "C:\Users\mdubose\source\repos\CoffeeShop\IceCreamShop\Views\Admin\Index.cshtml"
            Write(p.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(") ");
#nullable restore
#line 21 "C:\Users\mdubose\source\repos\CoffeeShop\IceCreamShop\Views\Admin\Index.cshtml"
                         Write(p.Price.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 394, "\"", 418, 2);
            WriteAttributeValue("", 401, "/Admin/Edit/", 401, 12, true);
#nullable restore
#line 22 "C:\Users\mdubose\source\repos\CoffeeShop\IceCreamShop\Views\Admin\Index.cshtml"
WriteAttributeValue("", 413, p.Id, 413, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 440, "\"", 466, 2);
            WriteAttributeValue("", 447, "/Admin/Delete/", 447, 14, true);
#nullable restore
#line 23 "C:\Users\mdubose\source\repos\CoffeeShop\IceCreamShop\Views\Admin\Index.cshtml"
WriteAttributeValue("", 461, p.Id, 461, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n    </div>\r\n");
#nullable restore
#line 25 "C:\Users\mdubose\source\repos\CoffeeShop\IceCreamShop\Views\Admin\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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