using System.Web.Mvc;

namespace AssetManagementUI.Controllers
{
    public class DesignationsController : Controller
    {
        // GET: Designations
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public PartialViewResult Create()
        {
            return PartialView("PartialView/Designations/_CreatePartiaView");
        }
    }
}