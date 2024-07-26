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
    public class ProductCategoriesController : Controller
    {
        readonly private CmsContext db = new CmsContext();

        readonly ProductCategoryService _ProductCategoryService;
        public ProductCategoriesController()
        {
            _ProductCategoryService = new ProductCategoryService(db);
        }


        public ActionResult Index()
        {
            var productCategoryList = _ProductCategoryService.GetAll().ToList();
            var productCategoryListViewModel = AutoMapperConfig.mapper.Map<List<ProductCategory>, List<ProductCategoryViewModel>>(productCategoryList);
            return View(productCategoryListViewModel);
        }




        public ActionResult Create()
        {
            //ViewBag.productCategoryList = new SelectList(_ProductCategoryService.GetAll().Where(t => t.ParentCategoryId == 0), "Id", "CategoryName");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ParentCategoryId,CategoryName")] ProductCategoryViewModel productCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                ProductCategory productCategory = AutoMapperConfig.mapper.Map<ProductCategoryViewModel, ProductCategory>(productCategoryViewModel);
                _ProductCategoryService.Add(productCategory);
                _ProductCategoryService.Save();
                return RedirectToAction("Index");
            }
            return View(productCategoryViewModel);
        }





        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductCategory productCategory = _ProductCategoryService.GetEntity(id.Value);
            if (productCategory == null)
            {
                return HttpNotFound();
            }
            var productCategoryViewModel = AutoMapperConfig.mapper.Map<ProductCategory, ProductCategoryViewModel>(productCategory);

            ViewBag.ParentId = productCategory.ParentCategoryId;
            return View(productCategoryViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ParentCategoryId,CategoryName")] ProductCategoryViewModel productCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                var productCategory = AutoMapperConfig.mapper.Map<ProductCategoryViewModel, ProductCategory>(productCategoryViewModel);
                _ProductCategoryService.Update(productCategory);
                _ProductCategoryService.Save();
                return RedirectToAction("Index");
            }
            return View(productCategoryViewModel);
        }




        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductCategory productCategory = _ProductCategoryService.GetEntity(id.Value);
            if (productCategory == null)
            {
                return HttpNotFound();
            }
            var productCategoryViewModel = AutoMapperConfig.mapper.Map<ProductCategory, ProductCategoryViewModel>(productCategory);
            return View(productCategoryViewModel);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            ProductCategory productCategory = _ProductCategoryService.GetEntity(id);
            _ProductCategoryService.Delete(productCategory);
            _ProductCategoryService.Save();
            return RedirectToAction("Index");
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
