using System.Web.Mvc;

namespace AssetManagementUI.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public PartialViewResult Create()
        {
            return PartialView("PartialView/Employees/_CreatePartialView");
        }
    }
}