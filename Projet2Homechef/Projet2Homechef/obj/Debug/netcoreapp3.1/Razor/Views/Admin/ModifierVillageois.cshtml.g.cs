#pragma checksum "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc60031d140338ad9a559dbab75e879138d2520e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ModifierVillageois), @"mvc.1.0.view", @"/Views/Admin/ModifierVillageois.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc60031d140338ad9a559dbab75e879138d2520e", @"/Views/Admin/ModifierVillageois.cshtml")]
    #nullable restore
    public class Views_Admin_ModifierVillageois : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Projet2Homechef.Models.Villageois>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
  
    ViewBag.Title = "ModifierVillageois";
    Layout = "_LayoutHomeChefVuesSecondaires";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 class=""page-section-heading text-center text-uppercase text-secondary mb-0"">Villageois</h2>
        <!-- Icon Divider-->
        <div class=""divider-custom"">
            <div class=""divider-custom-line""></div>
            <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
            <div class=""divider-custom-line""></div>
        </div>
        <div class=""row justify-content-center"">
            <div class=""col-lg-8 col-xl-7"">
              <div class=""form-floating mb-3"">
");
#nullable restore
#line 18 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
                   using (Html.BeginForm())
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <fieldset>\n                                <legend>Modifier un Villageois: </legend>\n                                ");
#nullable restore
#line 22 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
                           Write(Html.LabelFor(m => Model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 23 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
                           Write(Html.TextBoxFor(m => Model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 24 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
                           Write(Html.ValidationMessageFor(m => Model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                <br />\n                               ");
#nullable restore
#line 26 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
                          Write(Html.LabelFor(m => Model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 27 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
                           Write(Html.TextBoxFor(m => Model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 28 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
                           Write(Html.ValidationMessageFor(m => Model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                <br />\n                                ");
#nullable restore
#line 30 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
                           Write(Html.LabelFor(m => Model.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 31 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
                           Write(Html.TextBoxFor(m => Model.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 32 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
                           Write(Html.ValidationMessageFor(m => Model.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                <br />\n                                ");
#nullable restore
#line 34 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
                           Write(Html.LabelFor(m => Model.Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 35 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
                           Write(Html.TextBoxFor(m => Model.Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 36 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
                           Write(Html.ValidationMessageFor(m => Model.Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                <br />\n                                ");
#nullable restore
#line 38 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
                           Write(Html.LabelFor(m => Model.DateDeNaissance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 39 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
                           Write(Html.TextBoxFor(m => Model.DateDeNaissance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 40 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
                           Write(Html.ValidationMessageFor(m => Model.DateDeNaissance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                <br />\n                                ");
#nullable restore
#line 42 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
                           Write(Html.LabelFor(m => Model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 43 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
                           Write(Html.TextBoxFor(m => Model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 44 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
                           Write(Html.ValidationMessageFor(m => Model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                <br />\n                                ");
#nullable restore
#line 46 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
                           Write(Html.LabelFor(m => Model.Tel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 47 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
                           Write(Html.TextBoxFor(m => Model.Tel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 48 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
                           Write(Html.ValidationMessageFor(m => Model.Tel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                <br />\n\n                                <br />\n                                <input type=\"submit\" value=\"Modifier\" />\n                            </fieldset>\n");
#nullable restore
#line 54 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Admin\ModifierVillageois.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \n            </div>\n        </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projet2Homechef.Models.Villageois> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591