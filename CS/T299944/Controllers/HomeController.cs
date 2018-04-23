using DevExpress.Web;
using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using T299944.Models;

namespace T299944.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View(new SimpleModel());
        }

        
        public JsonResult CheckUserName(string Name)
        {
            bool isValid = !string.Equals(Name, "admin", StringComparison.OrdinalIgnoreCase);
            return Json(isValid, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult PostForm(SimpleModel m) {
            //additional server side-validation
            if (m.Name.StartsWith("X"))
                ModelState.AddModelError("Name", "Name cannot start with X");
            if (ModelState.IsValid)
                return PartialView("Success");
            else
                return PartialView("FormLayoutPartial", m);
        }
        
    }
   
}