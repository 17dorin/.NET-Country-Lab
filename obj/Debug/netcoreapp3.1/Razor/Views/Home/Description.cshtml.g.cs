#pragma checksum "C:\Users\17dor\source\repos\CountriesDotNet\Views\Home\Description.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "898febae8402dc0465b567f3c17ce1ee3d257669"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Description), @"mvc.1.0.view", @"/Views/Home/Description.cshtml")]
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
#line 1 "C:\Users\17dor\source\repos\CountriesDotNet\Views\_ViewImports.cshtml"
using CountriesDotNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\17dor\source\repos\CountriesDotNet\Views\_ViewImports.cshtml"
using CountriesDotNet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"898febae8402dc0465b567f3c17ce1ee3d257669", @"/Views/Home/Description.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c117d98f37f04f8dae4c680f9bf44975eb1363fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Description : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\17dor\source\repos\CountriesDotNet\Views\Home\Description.cshtml"
   
    if(TempData.ContainsKey("description"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 4 "C:\Users\17dor\source\repos\CountriesDotNet\Views\Home\Description.cshtml"
      Write(TempData.Peek("description"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 5 "C:\Users\17dor\source\repos\CountriesDotNet\Views\Home\Description.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No country selected</p>\r\n");
#nullable restore
#line 9 "C:\Users\17dor\source\repos\CountriesDotNet\Views\Home\Description.cshtml"
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
