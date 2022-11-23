using BusinessLogicLayer;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    public class RoleController : Controller
    {
        // GET: Role
        public ActionResult Index()
        {
            
            RoleBusiness rb = new RoleBusiness();
            var roleList = rb.GetAllRoles ();

            return View(roleList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RoleModel roleModel)
        {
            if(ModelState.IsValid)
            {
                RoleBusiness rb = new RoleBusiness();
                rb.AddRole(roleModel);
                return RedirectToAction("Index");
            }
            return View();
            
        }

        public ActionResult Edit(int Id)
        {
            RoleBusiness rb = new RoleBusiness();
            RoleModel roleModel = rb.GetRoleById(Id);
            return View(roleModel);
        }

        [HttpPost]
        public ActionResult Edit(RoleModel roleModel)
        {
            RoleBusiness rb = new RoleBusiness();
            rb.UpdateRole(roleModel);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            RoleBusiness rb = new RoleBusiness();
            rb.DeleteRole(Id);
            return RedirectToAction("Index");
        }
    }
}