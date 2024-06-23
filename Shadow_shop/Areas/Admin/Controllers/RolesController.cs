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

        public ActionResult Details(int? id)
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
            return View(role);
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title")] Role role)
        {
            if (ModelState.IsValid)
            {
                _RoleService.Add(role);
                _RoleService.Save();
                return RedirectToAction("Index");
            }

            return View(role);
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
            return View(role);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title")] Role role)
        {
            if (ModelState.IsValid)
            {
                _RoleService.Update(role);
                _RoleService.Save();
                return RedirectToAction("Index");
            }
            return View(role);
        }

        public ActionResult Delete(int? id)
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
            return View(role);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Role role = _RoleService.GetEntity(id);
            _RoleService.Delete(role);
            _RoleService.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _RoleService.Dispose();
        }
    }
}
