#pragma checksum "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Gestionnaire\Gestionnaire.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01cc30ca0eb022b917d40c28e04de7d36f6c4a15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gestionnaire_Gestionnaire), @"mvc.1.0.view", @"/Views/Gestionnaire/Gestionnaire.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01cc30ca0eb022b917d40c28e04de7d36f6c4a15", @"/Views/Gestionnaire/Gestionnaire.cshtml")]
    #nullable restore
    public class Views_Gestionnaire_Gestionnaire : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Projet2Homechef.Models.Villageois>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \n\n\n");
#nullable restore
#line 5 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Gestionnaire\Gestionnaire.cshtml"
  
    ViewBag.Title = "Gestionnaire";
    Layout = "_LayoutHomeChefVuesSecondaires";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3 class=""titre"">Page réservée aux HomeChefs</h3>



 <h4>Liste des nouveaux inscrits à vérifier</h4>
 
 <table border=""1"">
      <tr>
          <th>Nom</th>    
          <th>Prenom</th>  
          <th>DateDeNaissance</th>
          <th>Email</th> 
          <th>Tel</th> 
          <th>Role</th> 
          <th>   </th>
          <th> </th>
         
       </tr>
");
#nullable restore
#line 28 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Gestionnaire\Gestionnaire.cshtml"
     foreach(var villageois in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <tr>\n          <td>");
#nullable restore
#line 31 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Gestionnaire\Gestionnaire.cshtml"
         Write(villageois.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>    \n          <td>");
#nullable restore
#line 32 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Gestionnaire\Gestionnaire.cshtml"
         Write(villageois.Prenom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \n          <td>");
#nullable restore
#line 33 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Gestionnaire\Gestionnaire.cshtml"
         Write(villageois.DateDeNaissance.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \n          <td>");
#nullable restore
#line 34 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Gestionnaire\Gestionnaire.cshtml"
         Write(villageois.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \n          <td>");
#nullable restore
#line 35 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Gestionnaire\Gestionnaire.cshtml"
         Write(villageois.Tel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \n          <td>");
#nullable restore
#line 36 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Gestionnaire\Gestionnaire.cshtml"
         Write(villageois.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \n          <td> <button1 class=\"btn btn-success btn-xl\" type=\"submit\">");
#nullable restore
#line 37 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Gestionnaire\Gestionnaire.cshtml"
                                                                Write(Html.ActionLink("Valider", "ValiderVillageois", "Gestionnaire",new{@id = @villageois.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </button1> </td>\n          <td> <button2 class=\"btn btn-danger btn-xl\" type=\"submit\">");
#nullable restore
#line 38 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Gestionnaire\Gestionnaire.cshtml"
                                                               Write(Html.ActionLink("Rejeter", "DeleteVillageois", "Gestionnaire", new{@id = @villageois.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button2> </td>\n         \n\n      </tr>\n");
#nullable restore
#line 42 "D:\codeur\workspace\csharp\Projet2Homechef\Projet2Homechef\Views\Gestionnaire\Gestionnaire.cshtml"
      
  
      
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </table>\n\n");
            WriteLiteral("  \n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Projet2Homechef.Models.Villageois>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
