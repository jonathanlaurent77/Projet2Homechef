using Microsoft.AspNetCore.Mvc;
using Projet2Homechef.Models;
using Projet2Homechef.Models.Prestation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Projet2Homechef.Controllers
{
    public class VillageoisController : Controller
    {
        public IActionResult Villageois()

        {
            Dal dal = new Dal();
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            Villageois villageoisConnected = dal.ObtientUnVillageois(Convert.ToInt32(userId));
            return View(villageoisConnected);
        }

        public IActionResult VillageoisServices()

        {
            Dal dal = new Dal();
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            int userIdInt = Convert.ToInt32(userId);
            List<Villageois> listeDesVillageois = dal.ObtientTousLesVillageois().ToList();
            List<Service> listeDesServices = dal.ObtientTousLesServices().Where(v => v.Chef.Id == userIdInt).ToList();
            return View(listeDesServices);
        }

        public IActionResult DeleteService(int id)
        {
            Dal dal = new Dal();
            dal.SupprimerService(id);
            return RedirectToAction("VillageoisServices");
        }

        public IActionResult ModifierService(int id)
        {
            if (id != 0)
            {
                using (Dal dal = new Dal())
                {
                    Service service = dal.ObtientTousLesServices().Where(r => r.Id == id).FirstOrDefault();
                    if (service == null)
                    {
                        ViewData["message"] = "Ce service n'est pas dans la base";
                        return View("Error");
                    }
                    return View(service);
                }
            }
            return View("Error");
        }

        [HttpPost]
        public IActionResult ModifierService(int id, string Titre, string Description)
        {

            if (id != 0)
            {
                using (Dal dal = new Dal())
                {
                    var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                    dal.ModifierService(id, Titre, Description, Convert.ToInt32(userId));
                    return RedirectToAction("ModifierService", new { @id = id });
                }
            }
            else
            {
                ViewData["message"] = "ce service n'est pas dans la base";
                return View("Error");
            }
        }

    }
}
