using Microsoft.AspNetCore.Mvc;
using Projet2Homechef.Models;
using System;
using Microsoft.AspNetCore.Authentication;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using Projet2Homechef.ViewModels;

namespace Projet2Homechef.Controllers
{
    public class LoginController : Controller
    {
        private Dal dal;

        public LoginController()
        { 
            this.dal = new Dal();
        }


        public IActionResult Login()
        {
            VillageoisViewModel viewModel = new VillageoisViewModel { Authentifie = HttpContext.User.Identity.IsAuthenticated };
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                viewModel.Villageois = dal.ObtientUnVillageois(Convert.ToInt32(userId));
                return Redirect("/Villageois/Villageois");                
            }
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Login(VillageoisViewModel viewModel, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                Villageois villageois = dal.Authentifier(viewModel.Villageois.UserName, viewModel.Villageois.Password);
                if (villageois != null)
                {
                    var userClaims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name, villageois.UserName),
                        new Claim(ClaimTypes.NameIdentifier, villageois.Id.ToString()),
                        new Claim("ClefUser", villageois.Id.ToString()),
                       // new Claim(ClaimTypes.Role, villageois.Role.ToString()),
                    };

                    var ClaimIdentity = new ClaimsIdentity(userClaims, "User Identity");

                    var userPrincipal = new ClaimsPrincipal(new[] { ClaimIdentity });
                    HttpContext.SignInAsync(userPrincipal);



                    if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                        return Redirect(returnUrl);                        
                    //return Redirect("/");
                    return Redirect("/Home");
                }
                ModelState.AddModelError("Villageois.UserName", "UserName et/ou Password incorrect(s)");
            }
            return View(viewModel);
        }

        public IActionResult Deconnexion()
        {
            HttpContext.SignOutAsync();
            return Redirect("/Home");
        }



    }
}
