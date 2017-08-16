using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using OrganizationModelsLibrary;
using OrgnationManagersLibrary;

namespace AssetManagementUI.Controllers
{
    public class OrganizationsController : Controller
    {
       private readonly OrgnationManager _orgnationManager=new OrgnationManager();
        
        // GET: Organizations
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult Create()
        {
            return PartialView("PartialView/Organizations/_CreatePartial" );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(
            [Bind(Include = "Id, Name, ShortName, Location, Description")] Organization aOrganization)
        {
            if (ModelState.IsValid)
            {
                int rowAffected = _orgnationManager.Save(aOrganization);
                if (rowAffected>0)
                {
                    return PartialView("PartialView/Organizations/_CreatePartial");
                }
            }
            return View("Index");
        }

        public string FindById()
        {
            string name="";
            var orgnation = _orgnationManager.FindOrganizationById(1);
            if (orgnation != null)
            {
                name = orgnation.Name;
            }
            return name;
        }
    }
}