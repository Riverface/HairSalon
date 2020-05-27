#pragma checksum "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca6977d577a27c645e4ae33732856aba6f228c52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Index), @"mvc.1.0.view", @"/Views/Stylists/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Index.cshtml", typeof(AspNetCore.Views_Stylists_Index))]
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
#line 5 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Index.cshtml"
using HairSalon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca6977d577a27c645e4ae33732856aba6f228c52", @"/Views/Stylists/Index.cshtml")]
    public class Views_Stylists_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HairSalon.Models.Stylist>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(98, 23, true);
            WriteLiteral("\r\n<h1>Stylists</h1>\r\n\r\n");
            EndContext();
#line 10 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(149, 45, true);
            WriteLiteral("  <h3>No Stylists have been added yet!</h3>\r\n");
            EndContext();
#line 13 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Index.cshtml"
} 

else
{

#line default
#line hidden
            BeginContext(209, 100, true);
            WriteLiteral("  <table>\r\n    <tr>\r\n      <td>\r\n        ID\r\n      </td>\r\n      <td>Stylist Name</td>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 25 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Index.cshtml"
   foreach (Stylist Stylist in Model)
  {

#line default
#line hidden
            BeginContext(353, 20, true);
            WriteLiteral("    <tr>\r\n      <td>");
            EndContext();
            BeginContext(374, 17, false);
#line 28 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Index.cshtml"
     Write(Stylist.StylistId);

#line default
#line hidden
            EndContext();
            BeginContext(391, 18, true);
            WriteLiteral("</td> \r\n      <td>");
            EndContext();
            BeginContext(410, 77, false);
#line 29 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Index.cshtml"
     Write(Html.ActionLink($"{Stylist.Name}", "Details", new { id = Stylist.StylistId }));

#line default
#line hidden
            EndContext();
            BeginContext(487, 20, true);
            WriteLiteral("</td>\r\n    </tr>  \r\n");
            EndContext();
#line 31 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Index.cshtml"
  }

#line default
#line hidden
            BeginContext(512, 16, true);
            WriteLiteral("  \r\n  </table>\r\n");
            EndContext();
#line 34 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Index.cshtml"
}

#line default
#line hidden
            BeginContext(531, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(537, 44, false);
#line 36 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Index.cshtml"
Write(Html.ActionLink("Add new Stylist", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(581, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(591, 40, false);
#line 37 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(631, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HairSalon.Models.Stylist>> Html { get; private set; }
    }
}
#pragma warning restore 1591
