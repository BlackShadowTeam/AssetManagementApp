﻿using System.Web.Mvc;

namespace AssetManagementUI.Controllers
{
    public class AssetManufacturersController : Controller
    {
        // GET: AssetManufacturers
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Create()
        //{
        //    return View();
        //}

        [HttpGet]
        public PartialViewResult Create()
        {
            return PartialView("PartialView/AssetManufacturers/_CreatePartialView");
        }
    }
}