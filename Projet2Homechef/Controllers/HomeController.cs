using Microsoft.AspNetCore.Mvc;
using Projet2Homechef.Models;
using Projet2Homechef.ViewModels;
using System;
using System.Linq;
using System.Security.Claims;

namespace Projet2Homechef.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Dal dal = new Dal();
            HomeViewModel hvm = new HomeViewModel();
            if (User.Identity.IsAuthenticated)
            {
                var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                hvm.VillageoisConnected = dal.ObtientUnVillageois(Convert.ToInt32(userId));
                hvm.ListeDesServices2 = dal.ObtientTousLesServices().Where(v => v.Valider == 1).ToList();

                hvm.ListeDesVillageois = dal.ObtientTousLesVillageois();
                hvm.ListeDesServices = dal.ObtientTousLesServices().Where(v => v.Chef.Id == (Convert.ToInt32(userId))).ToList();
                
                return View(hvm);

            }
            else
            {
                hvm.ListeDesVillageois = dal.ObtientTousLesVillageois();
                hvm.ListeDesServices = dal.ObtientTousLesServices();
                hvm.VVM= new VillageoisViewModel();
                return View(hvm);
            }
        }
        public IActionResult CreerAdhesion()
        {

           return View("Index");
        }

        [HttpPost]
        public IActionResult CreerAdhesion(string userName, string password, string nom, string prenom, DateTime dateDeNaissance, string email, string tel)
        {

            using (Dal dal = new Dal())
            {
                dal.AjouterVillageois(userName, password, nom, prenom, dateDeNaissance, email, tel);
            }

            return RedirectToAction("Index");
        }




    }
}
