#pragma checksum "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a312f545bfafba4a8c3a9ae3a6d4a18c56b1966"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Details), @"mvc.1.0.view", @"/Views/Clients/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Details.cshtml", typeof(AspNetCore.Views_Clients_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a312f545bfafba4a8c3a9ae3a6d4a18c56b1966", @"/Views/Clients/Details.cshtml")]
    public class Views_Clients_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(64, 37, true);
            WriteLiteral("<h2>Client Details</h2>\r\n<hr />\r\n<h3>");
            EndContext();
            BeginContext(102, 40, false);
#line 8 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(142, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(145, 36, false);
#line 8 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(181, 11, true);
            WriteLiteral("</h3>\r\n<H3>");
            EndContext();
            BeginContext(193, 10, false);
#line 9 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(203, 10, true);
            WriteLiteral("</H3>\r\n<p>");
            EndContext();
            BeginContext(214, 40, false);
#line 10 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Details.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(254, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(264, 67, false);
#line 11 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Details.cshtml"
Write(Html.ActionLink("Edit Client", "Edit", new { id = Model.ClientId }));

#line default
#line hidden
            EndContext();
            BeginContext(331, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(341, 71, false);
#line 12 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Details.cshtml"
Write(Html.ActionLink("Delete Client", "Delete", new { id = Model.ClientId }));

#line default
#line hidden
            EndContext();
            BeginContext(412, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
