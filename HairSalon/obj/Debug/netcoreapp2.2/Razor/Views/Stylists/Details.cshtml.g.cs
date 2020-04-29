#pragma checksum "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e9605b08ee457ab0fd3ac0f1f580275f375906b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Details), @"mvc.1.0.view", @"/Views/Stylists/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Details.cshtml", typeof(AspNetCore.Views_Stylists_Details))]
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
#line 5 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Details.cshtml"
using HairSalon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e9605b08ee457ab0fd3ac0f1f580275f375906b", @"/Views/Stylists/Details.cshtml")]
    public class Views_Stylists_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Stylist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Details.cshtml"
  
Layout = "_Layout";

#line default
#line hidden
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(90, 40, true);
            WriteLiteral("\r\n<h2>Stylist Details</h2>\r\n<hr />\r\n<h3>");
            EndContext();
            BeginContext(131, 40, false);
#line 10 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(171, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(174, 36, false);
#line 10 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(210, 15, true);
            WriteLiteral("</h3>\r\n\r\n<ul>\r\n");
            EndContext();
#line 13 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Details.cshtml"
   if (@Model.clients.Count == 0)
  {

#line default
#line hidden
            BeginContext(265, 27, true);
            WriteLiteral("  <p>no clients found</p>\r\n");
            EndContext();
#line 16 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Details.cshtml"
  }

#line default
#line hidden
            BeginContext(297, 79, true);
            WriteLiteral("  <table>\r\n    <tr>\r\n      <td>\r\n        ID\r\n      </td>\r\n      <td>Name</td>\r\n");
            EndContext();
#line 23 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Details.cshtml"
       foreach (Client client in @Model.clients)
      {

#line default
#line hidden
            BeginContext(435, 20, true);
            WriteLiteral("    <tr>\r\n      <td>");
            EndContext();
            BeginContext(456, 15, false);
#line 26 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Details.cshtml"
     Write(client.ClientId);

#line default
#line hidden
            EndContext();
            BeginContext(471, 18, true);
            WriteLiteral("</td>\r\n      <td> ");
            EndContext();
            BeginContext(490, 77, false);
#line 27 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Details.cshtml"
      Write(Html.ActionLink(@client.Name, "Details", "clients", new {id=client.ClientId}));

#line default
#line hidden
            EndContext();
            BeginContext(567, 19, true);
            WriteLiteral(" </td>\r\n    </tr>\r\n");
            EndContext();
#line 29 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(593, 21, true);
            WriteLiteral("\r\n  </table>\r\n\r\n  <p>");
            EndContext();
            BeginContext(615, 44, false);
#line 33 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Details.cshtml"
Write(Html.ActionLink("Back to stylists", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(659, 11, true);
            WriteLiteral("</p>\r\n  <p>");
            EndContext();
            BeginContext(671, 69, false);
#line 34 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Details.cshtml"
Write(Html.ActionLink("Edit Stylist", "Edit", new { id = Model.StylistId }));

#line default
#line hidden
            EndContext();
            BeginContext(740, 11, true);
            WriteLiteral("</p>\r\n  <p>");
            EndContext();
            BeginContext(752, 73, false);
#line 35 "D:\Projects\Programming\HairSalon\hairsalon\Views\Stylists\Details.cshtml"
Write(Html.ActionLink("Delete Stylist", "Delete", new { id = Model.StylistId }));

#line default
#line hidden
            EndContext();
            BeginContext(825, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Stylist> Html { get; private set; }
    }
}
#pragma warning restore 1591
