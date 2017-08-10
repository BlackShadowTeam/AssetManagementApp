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


        [HttpGet]
        public PartialViewResult Create()
        {
            return PartialView("PartialView/Branchs/_CreatePartialView");
        }
    }
}