#pragma checksum "C:\Users\Jose Alejandro\Documents\asp .net\Projects\TheSims\TheSims\TheSims\Views\Sim\FilterForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23a590176d2461c93e0be3c926d22674c9de6494"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sim_FilterForm), @"mvc.1.0.view", @"/Views/Sim/FilterForm.cshtml")]
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
#line 1 "C:\Users\Jose Alejandro\Documents\asp .net\Projects\TheSims\TheSims\TheSims\Views\_ViewImports.cshtml"
using TheSims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jose Alejandro\Documents\asp .net\Projects\TheSims\TheSims\TheSims\Views\_ViewImports.cshtml"
using TheSims.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23a590176d2461c93e0be3c926d22674c9de6494", @"/Views/Sim/FilterForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829f4db2b230ed92fff8cf69652125178e0c9aed", @"/Views/_ViewImports.cshtml")]
    public class Views_Sim_FilterForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TheSims.Models.Sim>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Fill the spaces so you filter the list of Sims to be displayed</h2>\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Jose Alejandro\Documents\asp .net\Projects\TheSims\TheSims\TheSims\Views\Sim\FilterForm.cshtml"
 using (Html.BeginForm("Consult", "Sim"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 7 "C:\Users\Jose Alejandro\Documents\asp .net\Projects\TheSims\TheSims\TheSims\Views\Sim\FilterForm.cshtml"
   Write(Html.LabelFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 8 "C:\Users\Jose Alejandro\Documents\asp .net\Projects\TheSims\TheSims\TheSims\Views\Sim\FilterForm.cshtml"
   Write(Html.TextBoxFor(m => m.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 12 "C:\Users\Jose Alejandro\Documents\asp .net\Projects\TheSims\TheSims\TheSims\Views\Sim\FilterForm.cshtml"
   Write(Html.LabelFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 13 "C:\Users\Jose Alejandro\Documents\asp .net\Projects\TheSims\TheSims\TheSims\Views\Sim\FilterForm.cshtml"
   Write(Html.TextBoxFor(m => m.LastName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Search</button>\r\n");
#nullable restore
#line 16 "C:\Users\Jose Alejandro\Documents\asp .net\Projects\TheSims\TheSims\TheSims\Views\Sim\FilterForm.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TheSims.Models.Sim> Html { get; private set; }
    }
}
#pragma warning restore 1591
