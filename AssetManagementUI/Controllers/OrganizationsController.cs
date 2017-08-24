using OrganizationModelsLibrary;
using OrgnationManagersLibrary;
using System.Web.Mvc;

namespace AssetManagementUI.Controllers
{
    public class OrganizationsController : Controller
    {
        private readonly OrgnationManager _orgnationManager = new OrgnationManager();

        // GET: Organizations
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult Create()
        {
            return PartialView("PartialView/Organizations/_CreatePartial");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(
            [Bind(Include = "Id, Name, ShortName, Location, Description")] Organization aOrganization)
        {
            if (ModelState.IsValid)
            {

                return PartialView("PartialView/Organizations/_CreatePartial");

            }
            return View("Index");
        }


    }
}