#pragma checksum "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\MonCatalogue.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50dd5e9c40c3699cd7b61f93e977d2ea7e327b30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_MonCatalogue), @"mvc.1.0.view", @"/Views/Service/MonCatalogue.cshtml")]
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
#line 2 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\MonCatalogue.cshtml"
using Projet2Homechef.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50dd5e9c40c3699cd7b61f93e977d2ea7e327b30", @"/Views/Service/MonCatalogue.cshtml")]
    #nullable restore
    public class Views_Service_MonCatalogue : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Projet2Homechef.Models.Prestation.Service>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 5 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\MonCatalogue.cshtml"
  
    ViewBag.Title = "MonCatalogue";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2><img id =\"imgTitre\" src=\"/images/sousmenu meservices.png\"  /></h2>\n\t\t\n\n\t\t<div class=\"row justify-content-start\">\n\n");
#nullable restore
#line 15 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\MonCatalogue.cshtml"
             foreach(var service in Model)
			{
				

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"card col-6 m-5\" style=\"width: 18rem;\">\n\t\t\t\t\t<div class=\"card-body d-flex flex-column justify-content-between\">\n                        <div>\n                            <h5 class=\"card-title\">");
#nullable restore
#line 21 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\MonCatalogue.cshtml"
                                              Write(service.Titre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                            <div class=\"my-3\">\n                               \n                            </div>\n                            <img");
            BeginWriteAttribute("src", " src=\"", 666, "\"", 690, 1);
#nullable restore
#line 25 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\MonCatalogue.cshtml"
WriteAttributeValue("", 672, service.ImagePath, 672, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200\" height=\"200\" />\n                            \n                            <p class=\"card-text\">");
#nullable restore
#line 27 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\MonCatalogue.cshtml"
                                            Write(service.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\t\t\t\t\t\t\t<p class=\"card-text\">");
#nullable restore
#line 28 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\MonCatalogue.cshtml"
                                            Write(service.Valider);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n                        </div>\n\t\t\t\n                        \n\t\t\t\t\t\t\n\n\t\t\t\t\t</div>\n\t\t\t\t</div>\n");
#nullable restore
#line 37 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\MonCatalogue.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"			<div class=""col-4 m-5"" style=""width: 18rem;"">
				<a href=""/Service/CreerService"">
					<svg xmlns=""http://www.w3.org/2000/svg"" width=""160"" height=""160"" fill=""black"" class=""align-middle bi bi-plus"" viewBox=""0 0 16 16"">
						<path class=""plus"" d=""M8 4a.5.5 0 0 1 .5.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3A.5.5 0 0 1 8 4z"" />
					</svg>
				</a>
			</div>

		</div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Projet2Homechef.Models.Prestation.Service>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
