using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;

namespace AssetManagementUI.Controllers
{
    public class OrganizationsController : Controller
    {
        // GET: Organizations
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
            return PartialView("PartialView/Organizations/_CreatePartial" );
        }
    }
}