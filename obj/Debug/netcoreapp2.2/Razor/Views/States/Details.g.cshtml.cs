#pragma checksum "C:\Users\p403s\Desktop\Parks-mvc\Views\States\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab2d62a550c58232f1fcadb3e0ac271776fb2ce6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_States_Details), @"mvc.1.0.view", @"/Views/States/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/States/Details.cshtml", typeof(AspNetCore.Views_States_Details))]
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
#line 1 "C:\Users\p403s\Desktop\Parks-mvc\Views\_ViewImports.cshtml"
using Parks_mvc;

#line default
#line hidden
#line 2 "C:\Users\p403s\Desktop\Parks-mvc\Views\_ViewImports.cshtml"
using Parks_mvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab2d62a550c58232f1fcadb3e0ac271776fb2ce6", @"/Views/States/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"428facb8cae91c4c226bfb1da541ae211417691e", @"/Views/_ViewImports.cshtml")]
    public class Views_States_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<parks_mvc.Models.State>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\p403s\Desktop\Parks-mvc\Views\States\Details.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(65, 14, true);
            WriteLiteral("\r\n<h2>State - ");
            EndContext();
            BeginContext(80, 15, false);
#line 7 "C:\Users\p403s\Desktop\Parks-mvc\Views\States\Details.cshtml"
       Write(Model.StateName);

#line default
#line hidden
            EndContext();
            BeginContext(95, 13, true);
            WriteLiteral("</h2>\r\n<hr>\r\n");
            EndContext();
            BeginContext(109, 65, false);
#line 9 "C:\Users\p403s\Desktop\Parks-mvc\Views\States\Details.cshtml"
Write(Html.ActionLink("Edit State", "Edit", new { id = Model.StateId }));

#line default
#line hidden
            EndContext();
            BeginContext(174, 6, true);
            WriteLiteral("<br>\r\n");
            EndContext();
            BeginContext(181, 69, false);
#line 10 "C:\Users\p403s\Desktop\Parks-mvc\Views\States\Details.cshtml"
Write(Html.ActionLink("Delete State", "Delete", new { id = Model.StateId }));

#line default
#line hidden
            EndContext();
            BeginContext(250, 28, true);
            WriteLiteral("\r\n<hr>\r\n<ul>\r\n    <li>Name: ");
            EndContext();
            BeginContext(279, 45, false);
#line 13 "C:\Users\p403s\Desktop\Parks-mvc\Views\States\Details.cshtml"
         Write(Html.DisplayFor(modelItem => Model.StateName));

#line default
#line hidden
            EndContext();
            BeginContext(324, 24, true);
            WriteLiteral("</li>\r\n    <li>Country: ");
            EndContext();
            BeginContext(349, 43, false);
#line 14 "C:\Users\p403s\Desktop\Parks-mvc\Views\States\Details.cshtml"
            Write(Html.DisplayFor(modelItem => Model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(392, 21, true);
            WriteLiteral("</li>\r\n    <li>City: ");
            EndContext();
            BeginContext(414, 40, false);
#line 15 "C:\Users\p403s\Desktop\Parks-mvc\Views\States\Details.cshtml"
         Write(Html.DisplayFor(modelItem => Model.City));

#line default
#line hidden
            EndContext();
            BeginContext(454, 42, true);
            WriteLiteral("</li>\r\n</ul>\r\n<hr>\r\n<h5>NationalParks for ");
            EndContext();
            BeginContext(497, 15, false);
#line 18 "C:\Users\p403s\Desktop\Parks-mvc\Views\States\Details.cshtml"
                 Write(Model.StateName);

#line default
#line hidden
            EndContext();
            BeginContext(512, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 19 "C:\Users\p403s\Desktop\Parks-mvc\Views\States\Details.cshtml"
 foreach (var nationalPark in Model.NationalParks)
{

#line default
#line hidden
            BeginContext(574, 33, true);
            WriteLiteral("    <ul>\r\n        <li>Park Name: ");
            EndContext();
            BeginContext(608, 21, false);
#line 22 "C:\Users\p403s\Desktop\Parks-mvc\Views\States\Details.cshtml"
                  Write(nationalPark.ParkName);

#line default
#line hidden
            EndContext();
            BeginContext(629, 35, true);
            WriteLiteral("</li>\r\n        <li>Average Rating: ");
            EndContext();
            BeginContext(665, 22, false);
#line 23 "C:\Users\p403s\Desktop\Parks-mvc\Views\States\Details.cshtml"
                       Write(nationalPark.AvgRating);

#line default
#line hidden
            EndContext();
            BeginContext(687, 19, true);
            WriteLiteral(")</li>\r\n    </ul>\r\n");
            EndContext();
#line 25 "C:\Users\p403s\Desktop\Parks-mvc\Views\States\Details.cshtml"
}

#line default
#line hidden
            BeginContext(710, 91, false);
#line 26 "C:\Users\p403s\Desktop\Parks-mvc\Views\States\Details.cshtml"
Write(Html.ActionLink("Add a NationalPark", "Create", "NationalPark", new { id = Model.StateId }));

#line default
#line hidden
            EndContext();
            BeginContext(801, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(804, 32, false);
#line 27 "C:\Users\p403s\Desktop\Parks-mvc\Views\States\Details.cshtml"
Write(Html.ActionLink("Back", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(836, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<parks_mvc.Models.State> Html { get; private set; }
    }
}
#pragma warning restore 1591
