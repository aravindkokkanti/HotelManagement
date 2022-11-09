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

        [HttpPost]
        public ActionResult Create(AddressTypeModel addressTypeModel)
        {
            AddressTypeBusiness atb = new AddressTypeBusiness();
            atb.AddAddressType(addressTypeModel);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            AddressTypeBusiness addressTypeBussiness = new AddressTypeBusiness();
            AddressTypeModel addressTypeModel = addressTypeBussiness.GetAddressTypeById(Id);
            return View(addressTypeModel);
        }

        [HttpPost]
        public ActionResult Edit(AddressTypeModel addressTypeModel)
        {
            AddressTypeBusiness addressTypeBussiness = new AddressTypeBusiness();
            addressTypeBussiness.UpdateAddressType(addressTypeModel);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            AddressTypeBusiness addressTypeBussiness = new AddressTypeBusiness();
            addressTypeBussiness.DeleteAddressType(Id);
            return RedirectToAction("Index");
        }



    }
}