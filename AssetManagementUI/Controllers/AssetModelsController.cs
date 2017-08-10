using System.Web.Mvc;

namespace AssetManagementUI.Controllers
{
    public class AssetModelsController : Controller
    {
        // GET: AssetModels
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
            return PartialView("PartialView/AssetModels/_CreatePartialView");
        }
    }
}