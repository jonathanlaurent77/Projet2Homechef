#pragma checksum "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\CreerService.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae1d1979f99cfb21dba9d51bcd9060dc29bbd4d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_CreerService), @"mvc.1.0.view", @"/Views/Service/CreerService.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae1d1979f99cfb21dba9d51bcd9060dc29bbd4d1", @"/Views/Service/CreerService.cshtml")]
    #nullable restore
    public class Views_Service_CreerService : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Projet2Homechef.Models.Prestation.Service>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\CreerService.cshtml"
  
    ViewBag.Title = "CreerService";
    Layout = "_LayoutHomeChefVuesSecondaires";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h3 class=\"titre\">CreerService (Désactivé)</h3>\n\n<div class=\"col-lg-8 col-xl-7\">\n");
#nullable restore
#line 10 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\CreerService.cshtml"
     using (Html.BeginForm("CreerService","Service",FormMethod.Post, new {enctype="multipart/form-data"}))
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-floating mb-3\">\n            ");
#nullable restore
#line 13 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\CreerService.cshtml"
       Write(Html.TextBoxFor(model => model.Titre, new { @class = "form-control", placeholder = "Titre" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 14 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\CreerService.cshtml"
       Write(Html.LabelFor(model => model.Titre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 15 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\CreerService.cshtml"
       Write(Html.ValidationMessageFor(model => model.Titre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"form-floating mb-3\">\n            ");
#nullable restore
#line 18 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\CreerService.cshtml"
       Write(Html.TextBoxFor(model => model.Description, new { @class = "form-control", placeholder = "Description" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 19 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\CreerService.cshtml"
       Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 20 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\CreerService.cshtml"
       Write(Html.ValidationMessageFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n");
#nullable restore
#line 23 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\CreerService.cshtml"
   Write(Html.HiddenFor(model=>model.ImagePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"d-flex flex-row my-3\">\n                        <div class=\"mb-3 d-flex\">\n                            <div>\n                                <li>");
#nullable restore
#line 27 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\CreerService.cshtml"
                               Write(Html.LabelFor(model => model.Image, new { id = "imageLabel", @style = "text-align:center;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                <li>");
#nullable restore
#line 28 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\CreerService.cshtml"
                               Write(Html.TextBoxFor(model => model.Image, new { placeholder = "Description", @type = "file" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>

                            </div>
                        </div>
                        <div class=""text-center"">
                            
                        </div>
                    </div>
                        <!-- Submit Button-->
        <button class=""btn btn-primary btn-xl"" type=""submit"">Désactivé</button>
");
#nullable restore
#line 38 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Service\CreerService.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projet2Homechef.Models.Prestation.Service> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
