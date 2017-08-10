using System.Web.Mvc;

namespace AssetManagementUI.Controllers
{
    public class DepartmentsController : Controller
    {
        // GET: Departments
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public PartialViewResult Create()
        {
            return PartialView("PartialView/Departments/_CreatePartialView");
        }
    }
}