#pragma checksum "D:\С#\Shop\Shop\Views\Cars\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c216c36f1da91030e5b23304c3589902383c4a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_List), @"mvc.1.0.view", @"/Views/Cars/List.cshtml")]
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
#line 1 "D:\С#\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.ViewsModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c216c36f1da91030e5b23304c3589902383c4a8", @"/Views/Cars/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0835504628163a4591dab8d50263afc23bec3570", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\t<h1>Всі автомобілі </h1>\r\n\t<h3>");
#nullable restore
#line 3 "D:\С#\Shop\Shop\Views\Cars\List.cshtml"
   Write(Model.carCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 4 "D:\С#\Shop\Shop\Views\Cars\List.cshtml"
      
        foreach(var Car in  Model.allCars) {


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div>\r\n\t\t\t\t<h2>Модель: ");
#nullable restore
#line 8 "D:\С#\Shop\Shop\Views\Cars\List.cshtml"
                       Write(Car.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\t\t\t\t<p>Ціна: ");
#nullable restore
#line 9 "D:\С#\Shop\Shop\Views\Cars\List.cshtml"
                    Write(Car.price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 11 "D:\С#\Shop\Shop\Views\Cars\List.cshtml"
			
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
