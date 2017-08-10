using System.Web.Mvc;

namespace AssetManagementUI.Controllers
{
    public class AssetGroupsController : Controller
    {
        // GET: AssetGroups
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult Create()
        {
            return PartialView("PartialView/AssetGroups/_CreatePartialView");
        }
    }
}