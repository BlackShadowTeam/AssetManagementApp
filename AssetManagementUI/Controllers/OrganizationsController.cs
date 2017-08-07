using System.Web.Mvc;

namespace AssetManagementUI.Controllers
{
    public class OrganizationsController : Controller
    {
        // GET: Organizations
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