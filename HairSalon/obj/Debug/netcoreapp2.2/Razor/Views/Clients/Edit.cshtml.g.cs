#pragma checksum "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06217f2152851718ad35f5f09fabb0e55efbddce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Edit), @"mvc.1.0.view", @"/Views/Clients/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Edit.cshtml", typeof(AspNetCore.Views_Clients_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06217f2152851718ad35f5f09fabb0e55efbddce", @"/Views/Clients/Edit.cshtml")]
    public class Views_Clients_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Edit.cshtml"
  
Layout = "_Layout";

#line default
#line hidden
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(62, 39, true);
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n<h4>Edit this task: ");
            EndContext();
            BeginContext(102, 36, false);
#line 9 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Edit.cshtml"
               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(138, 9, true);
            WriteLiteral("</h4>\r\n\r\n");
            EndContext();
#line 11 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(180, 39, false);
#line 13 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Edit.cshtml"
Write(Html.HiddenFor(model => model.ClientId));

#line default
#line hidden
            EndContext();
            BeginContext(226, 39, false);
#line 15 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Edit.cshtml"
Write(Html.LabelFor(model =>model.First_Name));

#line default
#line hidden
            EndContext();
            BeginContext(270, 42, false);
#line 16 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Edit.cshtml"
Write(Html.TextBoxFor(model => model.First_Name));

#line default
#line hidden
            EndContext();
            BeginContext(317, 39, false);
#line 17 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Edit.cshtml"
Write(Html.LabelFor(model => Model.Last_Name));

#line default
#line hidden
            EndContext();
            BeginContext(361, 41, false);
#line 18 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Edit.cshtml"
Write(Html.TextBoxFor(model => Model.Last_Name));

#line default
#line hidden
            EndContext();
            BeginContext(407, 39, false);
#line 19 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Edit.cshtml"
Write(Html.LabelFor(model => model.StylistId));

#line default
#line hidden
            EndContext();
#line 19 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Edit.cshtml"
                                          ;
  

#line default
#line hidden
            BeginContext(452, 30, false);
#line 20 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Edit.cshtml"
Write(Html.DropDownList("StylistId"));

#line default
#line hidden
            EndContext();
            BeginContext(486, 40, true);
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\r\n");
            EndContext();
#line 23 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(529, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(535, 40, false);
#line 25 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Edit.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(575, 4, true);
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
