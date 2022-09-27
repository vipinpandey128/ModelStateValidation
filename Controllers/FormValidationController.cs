using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FormValidationController : Controller
    {
        // GET: FormValidation
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Create(Person model)
        {
            if (ModelState.IsValid)
            {
                return Json(new { message = "Success", name = model.Name });
            }
            return Json(new { message = "Error", name = string.Empty });
        }
    }
}