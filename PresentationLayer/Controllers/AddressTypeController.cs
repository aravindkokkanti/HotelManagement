using BusinessLogicLayer;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    public class AddressTypeController : Controller
    {
        // GET: AddressType
       
        public ActionResult Index()
        {
            //BusinessLogicLayer.AddressTypeBusiness atb = new BusinessLogicLayer.AddressTypeBusiness();
            AddressTypeBusiness atb = new AddressTypeBusiness();
            var addressTypeList = atb.GetAllAddressTypes();

            return View(addressTypeList);
        }

        public ActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Create(AddressTypeModel addressTypeModel)
        //{
        //    AddressTypeBusiness atb = new AddressTypeBusiness();
        //   atb.
        //    return RedirectToAction("Index");
        //}

        //[HttpPost]
        //public ActionResult Create(GenderModel genModel)
        //{
        //    GenderBusiness genderBussiness = new GenderBusiness();
        //    genderBussiness.AddGender(genModel);
        //    return RedirectToAction("Index");
        //}

    }
}