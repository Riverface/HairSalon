#pragma checksum "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "061b84afa27a7c4819869aa76b883e4fd574a40a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Create), @"mvc.1.0.view", @"/Views/Clients/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Create.cshtml", typeof(AspNetCore.Views_Clients_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"061b84afa27a7c4819869aa76b883e4fd574a40a", @"/Views/Clients/Create.cshtml")]
    public class Views_Clients_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(64, 29, true);
            WriteLiteral("\r\n<h4>Add a new task</h4>\r\n\r\n");
            EndContext();
#line 9 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(128, 39, false);
#line 11 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Create.cshtml"
Write(Html.LabelFor(model =>model.first_name));

#line default
#line hidden
            EndContext();
            BeginContext(174, 42, false);
#line 12 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Create.cshtml"
Write(Html.TextBoxFor(model => model.first_name));

#line default
#line hidden
            EndContext();
            BeginContext(223, 39, false);
#line 13 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Create.cshtml"
Write(Html.LabelFor(model => Model.last_name));

#line default
#line hidden
            EndContext();
            BeginContext(269, 41, false);
#line 14 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Create.cshtml"
Write(Html.TextBoxFor(model => Model.last_name));

#line default
#line hidden
            EndContext();
            BeginContext(319, 39, false);
#line 16 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Create.cshtml"
Write(Html.LabelFor(model => model.StylistId));

#line default
#line hidden
            EndContext();
#line 16 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Create.cshtml"
                                            ;
    

#line default
#line hidden
            BeginContext(366, 30, false);
#line 17 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Create.cshtml"
Write(Html.DropDownList("StylistId"));

#line default
#line hidden
            EndContext();
#line 17 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Create.cshtml"
                                   ;


#line default
#line hidden
            BeginContext(401, 74, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add new item\" class=\"btn btn-default\" />\r\n");
            EndContext();
#line 20 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Create.cshtml"
}

#line default
#line hidden
            BeginContext(478, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(482, 42, false);
#line 21 "D:\Projects\Programming\HairSalon\hairsalon\Views\Clients\Create.cshtml"
Write(Html.ActionLink("Show all items", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(524, 4, true);
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
