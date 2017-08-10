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

        //public ActionResult Create()
        //{
        //    return View();
        //}

        [HttpGet]
        public PartialViewResult Create()
        {
            return PartialView("PartialView/Departments/_CreatePartialView");
        }
    }
}