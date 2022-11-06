using BusinessLogicLayer;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    public class GenderController : Controller
    {
        // GET: Gender
        public ActionResult Index()
        {
            GenderBusiness gb = new GenderBusiness();

            var genderList = gb.GetAllGenders();

            return View(genderList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(GenderModel genModel)
        {
            GenderBusiness genderBussiness = new GenderBusiness();
            genderBussiness.AddGender(genModel);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            GenderBusiness genderBussiness = new GenderBusiness();
            GenderModel genderModel = genderBussiness.GetGenderById(Id);
            return View(genderModel);
        }

        [HttpPost]
        public ActionResult Edit(GenderModel genderModel)
        {
            GenderBusiness genderBussiness = new GenderBusiness();
            genderBussiness.UpdateGender(genderModel);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            GenderBusiness genderBussiness = new GenderBusiness();
            genderBussiness.DeleteGender(Id);
            return RedirectToAction("Index");
        }
    }  
}