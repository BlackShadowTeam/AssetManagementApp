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

        public ActionResult Create()
        {
            return View();
        }
    }
}