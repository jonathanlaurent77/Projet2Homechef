using Microsoft.AspNetCore.Mvc;
using Projet2Homechef.Models;
using Projet2Homechef.Models.Prestation;
using System.Collections.Generic;
using System.Linq;

namespace Projet2Homechef.Controllers
{
    public class GestionnaireController : Controller
    {
        Dal dal = new Dal();
        public IActionResult Gestionnaire()

        {
           // Dal dal = new Dal();
            List<Villageois> listeDesVillageoisAValider = dal.ObtientTousLesVillageois().Where(v=>v.Valider==0).ToList();
            return View(listeDesVillageoisAValider);
        }

        public IActionResult DeleteVillageois(int id)

        {
            //Dal dal = new Dal();
            dal.SupprimerVillageois(id);

            return RedirectToAction("Gestionnaire");
        }
    
        public IActionResult ValiderVillageois(int id)

        {
            //Dal dal = new Dal();
            dal.ValiderVillageois(id);

            return RedirectToAction("Gestionnaire");
        }

        public IActionResult GestionService()

        {
            //Dal dal = new Dal();
            List<Service> listeDesServicesAValider = dal.ObtientTousLesServices().Where(v => v.Valider == 0).ToList();
            List<Villageois> listeDesVillageois = dal.ObtientTousLesVillageois();
            return View(listeDesServicesAValider);
        }


        public IActionResult DeleteService(int id)

        {
            //Dal dal = new Dal();
            dal.SupprimerService(id);

            return RedirectToAction("GestionService");
        }

        public IActionResult ValiderService(int id)

        {
            //Dal dal = new Dal();
            dal.ValiderService(id);

            return RedirectToAction("GestionService");
        }


    }
}
