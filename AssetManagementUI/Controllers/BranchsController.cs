using System.Web.Mvc;

namespace AssetManagementUI.Controllers
{
    public class BranchsController : Controller
    {
        // GET: Branchs
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