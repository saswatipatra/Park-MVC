#pragma checksum "C:\Users\p403s\Desktop\Parks-mvc\Views\NationalParks\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cce6f71e72a3030705d1ac02e33fd1649603dd55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NationalParks_Details), @"mvc.1.0.view", @"/Views/NationalParks/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NationalParks/Details.cshtml", typeof(AspNetCore.Views_NationalParks_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cce6f71e72a3030705d1ac02e33fd1649603dd55", @"/Views/NationalParks/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"428facb8cae91c4c226bfb1da541ae211417691e", @"/Views/_ViewImports.cshtml")]
    public class Views_NationalParks_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<parks_mvc.Models.NationalPark>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\p403s\Desktop\Parks-mvc\Views\NationalParks\Details.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(72, 21, true);
            WriteLiteral("\r\n<h2>NationalPark - ");
            EndContext();
            BeginContext(94, 14, false);
#line 7 "C:\Users\p403s\Desktop\Parks-mvc\Views\NationalParks\Details.cshtml"
              Write(Model.ParkName);

#line default
#line hidden
            EndContext();
            BeginContext(108, 33, true);
            WriteLiteral("</h2>\r\n<hr>\r\n<ul>\r\n    <li>Name: ");
            EndContext();
            BeginContext(142, 44, false);
#line 10 "C:\Users\p403s\Desktop\Parks-mvc\Views\NationalParks\Details.cshtml"
         Write(Html.DisplayFor(modelItem => Model.ParkName));

#line default
#line hidden
            EndContext();
            BeginContext(186, 31, true);
            WriteLiteral("</li>\r\n    <li>Average Rating: ");
            EndContext();
            BeginContext(218, 15, false);
#line 11 "C:\Users\p403s\Desktop\Parks-mvc\Views\NationalParks\Details.cshtml"
                   Write(Model.AvgRating);

#line default
#line hidden
            EndContext();
            BeginContext(233, 43, true);
            WriteLiteral(")</li>\r\n    \r\n</ul>\r\n<hr>\r\n<h5>Reviews for ");
            EndContext();
            BeginContext(277, 14, false);
#line 15 "C:\Users\p403s\Desktop\Parks-mvc\Views\NationalParks\Details.cshtml"
           Write(Model.ParkName);

#line default
#line hidden
            EndContext();
            BeginContext(291, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 16 "C:\Users\p403s\Desktop\Parks-mvc\Views\NationalParks\Details.cshtml"
 foreach (var review in Model.Reviews)
{

#line default
#line hidden
            BeginContext(341, 30, true);
            WriteLiteral("    <ul>\r\n        <li>Author: ");
            EndContext();
            BeginContext(372, 15, false);
#line 19 "C:\Users\p403s\Desktop\Parks-mvc\Views\NationalParks\Details.cshtml"
               Write(review.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(387, 27, true);
            WriteLiteral("</li>\r\n        <li>Rating: ");
            EndContext();
            BeginContext(415, 13, false);
#line 20 "C:\Users\p403s\Desktop\Parks-mvc\Views\NationalParks\Details.cshtml"
               Write(review.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(428, 27, true);
            WriteLiteral("</li>\r\n        <li>Review: ");
            EndContext();
            BeginContext(456, 17, false);
#line 21 "C:\Users\p403s\Desktop\Parks-mvc\Views\NationalParks\Details.cshtml"
               Write(review.ReviewText);

#line default
#line hidden
            EndContext();
            BeginContext(473, 28, true);
            WriteLiteral("</li>\r\n        \r\n    </ul>\r\n");
            EndContext();
#line 24 "C:\Users\p403s\Desktop\Parks-mvc\Views\NationalParks\Details.cshtml"
}

#line default
#line hidden
            BeginContext(505, 86, false);
#line 25 "C:\Users\p403s\Desktop\Parks-mvc\Views\NationalParks\Details.cshtml"
Write(Html.ActionLink("Add a Review", "Create", "Review", new { id = Model.NationalParkId }));

#line default
#line hidden
            EndContext();
            BeginContext(591, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(594, 32, false);
#line 26 "C:\Users\p403s\Desktop\Parks-mvc\Views\NationalParks\Details.cshtml"
Write(Html.ActionLink("Back", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(626, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<parks_mvc.Models.NationalPark> Html { get; private set; }
    }
}
#pragma warning restore 1591
