using System.Web.Mvc;

namespace AssetManagementUI.Controllers
{
    public class AssetLocationsController : Controller
    {
        // GET: AssetLocations
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public PartialViewResult Create()
        {
            return PartialView("PartialView/AssetLocations/_CreatePartialView");
        }
    }
}