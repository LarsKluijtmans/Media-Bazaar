#pragma checksum "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Denied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "223e63ec89815f95c15cf7daf81effeece665919"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MediaBazzar.Pages.Pages_Denied), @"mvc.1.0.razor-page", @"/Pages/Denied.cshtml")]
namespace MediaBazzar.Pages
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
#line 1 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\_ViewImports.cshtml"
using MediaBazzar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"223e63ec89815f95c15cf7daf81effeece665919", @"/Pages/Denied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17501a10c88cb0ed86a29bb7145f1f0900b6a7f5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Denied : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Denied.cshtml"
  
    ViewData["Title"] = "Access Denied";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Permission Denied</h1>\r\n<p>You do not have the rights to the page you are attempting to access</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MediaBazzar.Pages.DeniedModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MediaBazzar.Pages.DeniedModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MediaBazzar.Pages.DeniedModel>)PageContext?.ViewData;
        public MediaBazzar.Pages.DeniedModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
