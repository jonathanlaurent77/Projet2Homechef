#pragma checksum "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\CatalogueHomechef2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a391e52aa6260ce96ec3c7ea546dbb7982c6db2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_CatalogueHomechef2), @"mvc.1.0.view", @"/Views/Service/CatalogueHomechef2.cshtml")]
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
#line 2 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\CatalogueHomechef2.cshtml"
using Projet2Homechef.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a391e52aa6260ce96ec3c7ea546dbb7982c6db2f", @"/Views/Service/CatalogueHomechef2.cshtml")]
    #nullable restore
    public class Views_Service_CatalogueHomechef2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Projet2Homechef.Models.Prestation.Service>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 5 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\CatalogueHomechef2.cshtml"
  
    ViewBag.Title = "CatalogueHomechef";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2><img id =\"imgTitre\" src=\"/images/sousmenu catalog.png\"  /></h2>\n\t\t\n\t\t<div class=\"row justify-content-start\">\n\n");
#nullable restore
#line 14 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\CatalogueHomechef2.cshtml"
             foreach(var service in Model)
			{
				

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<!-- -->\n");
            WriteLiteral(@"				<!--div class=""card col-6 m-5"" style=""width: 18rem;""-->
				<div class=""card col-6 m-5"" style=""width: 36rem;"">
					<div class=""card-body d-flex flex-column justify-content-between"">  
                        <div>
                            <h5 class=""card-title"">");
#nullable restore
#line 23 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\CatalogueHomechef2.cshtml"
                                              Write(service.Titre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                            <div class=\"my-3\">\n                               \n                            </div>\n\t\t\t\t\t\t\t<div class=\"row\">\n\t\t\t\t\t\t\t<div class=\"col-lg-4 ms-auto\">\n\t\t\t\t\t\t\t\t<img id=\"imgCard\"");
            BeginWriteAttribute("src", " src=\"", 807, "\"", 831, 1);
#nullable restore
#line 29 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\CatalogueHomechef2.cshtml"
WriteAttributeValue("", 813, service.ImagePath, 813, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200\" height=\"200\" />\n                            </div>\n\t\t\t\t\t\t\t<div class=\"col-lg-4 ms-auto\">\n\t\t\t\t\t\t\t\t<p class=\"card-text\">");
#nullable restore
#line 32 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\CatalogueHomechef2.cshtml"
                                                Write(service.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\t\t\t\t\t\t\t\t\n\t\t\t\t\t\t\t\t<p class=\"card-text\">Proposé par :</p>\n\t\t\t\t\t\t\t\t<p class=\"card-text\">");
#nullable restore
#line 34 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\CatalogueHomechef2.cshtml"
                                                Write(service.Chef.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\t\t\t\t\t\t\t\t<div id=\"right\">\n\t\t\t\t\t\t\t\t<button1 class=\"btn btn-success btn-xl\" type=\"submit\">");
#nullable restore
#line 36 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\CatalogueHomechef2.cshtml"
                                                                                 Write(Html.ActionLink("Demander", "Demander", "Service",  new {idService =@service.Id} ));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </button1>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t</div>\n                        </div>\n\t\t\t\t\t\t\n\t\t\t\t\t\t<div>\n   \n\t\t\t\t\t\t\t<td>  </td>\n                            \n\n                        </div>\n                        \n\t\t\t\t\t\t\n\n\t\t\t\t\t</div>\n\t\t\t\t</div>\n");
#nullable restore
#line 53 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\CatalogueHomechef2.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\n\n\t\t</div>\n\n\t\t");
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