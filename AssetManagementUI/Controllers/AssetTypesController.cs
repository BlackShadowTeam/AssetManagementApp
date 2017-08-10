using System.Web.Mvc;

namespace AssetManagementUI.Controllers
{
    public class AssetTypesController : Controller
    {
        // GET: AssetTypes
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Create()
        //{
        //    return View();
        //}

        public PartialViewResult Create()
        {
            return PartialView("PartialView/AssetTypes/_CreatePartialView");
        }
    }
}