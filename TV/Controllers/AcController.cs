using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
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
        public ActionResult Login(LoginVM model, string ReturnUrl)
        {
            //Kontrollerar om alla fält har fyllts i
            if (ModelState.IsValid)
            {
                //Skapar en cookie som inte är persistent. Den försvinner när browsern stängs ner.
                FormsAuthentication.SetAuthCookie(model.Username, false);
                return Redirect(ReturnUrl);
            }
            return View();
        }
    }
}