using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TV.Models.ViewModels;

namespace TV.Controllers
{
    public class AcController : Controller
    {
        // GET: Ac
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginVM model)
        {
            //Kontrollerar om alla fält har fyllts i
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}