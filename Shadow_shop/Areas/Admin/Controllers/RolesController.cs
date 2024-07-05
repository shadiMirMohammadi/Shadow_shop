using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Shadow_shop.ModelsLayer;
using Shadow_shop.ModelsLayer.Context;
using Shadow_shop.ServicesLayer;
using Shadow_shop.App_Start;
using Shadow_shop.Views.ViewModels;

namespace Shadow_shop.Areas.Admin.Controllers
{
    public class RolesController : Controller
    {
        readonly private CmsContext db = new CmsContext();
        readonly RoleService _RoleService;
        public RolesController()
        {
            _RoleService = new RoleService(db);
        }


        public ActionResult Index()
        {
            var roleList = _RoleService.GetAll().ToList();
            var roleListViewModel = AutoMapperConfig.mapper.Map<List<Role>, List<RoleViewModel>>(roleList);
            return View(roleListViewModel);
        }

       


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title")] RoleViewModel roleViewModel)
        {
            if (ModelState.IsValid)
            {
                Role role = AutoMapperConfig.mapper.Map<RoleViewModel, Role>(roleViewModel);
                _RoleService.Add(role);
                _RoleService.Save();
                return RedirectToAction("Index");
            }

            return View(roleViewModel);
        }




        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Role role = _RoleService.GetEntity(id.Value);
            if (role == null)
            {
                return HttpNotFound();
            }
            var roleViewModel = AutoMapperConfig.mapper.Map<Role, RoleViewModel>(role);
            return View(roleViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title")] RoleViewModel roleViewModel)
        {
            if (ModelState.IsValid)
            {
                var role = AutoMapperConfig.mapper.Map<RoleViewModel, Role>(roleViewModel);
                _RoleService.Update(role);
                _RoleService.Save();
                return RedirectToAction("Index");
            }
            return View(roleViewModel);
        }




        protected override void Dispose(bool disposing)
        {
            _RoleService.Dispose();
        }
    }
}
