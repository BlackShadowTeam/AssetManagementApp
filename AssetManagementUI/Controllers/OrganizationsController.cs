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
            var orgnationList = _orgnationManager.GetAllOrganization();
            return View(orgnationList);
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
                bool isShortNameExist = _orgnationManager.IsShortNameExist(aOrganization.ShortName);

                if (isShortNameExist)
                {
                    ViewBag.Message = "This Organization Short Name Already Exist in Database";
                }
                else
                {
                    int successCount = _orgnationManager.Save(aOrganization);
                    if (successCount > 0)
                    {
                        ViewBag.Message = "Organation Successfully Save in Database";
                        ViewBag.Success = 1;
                    }
                    else
                    {
                        ViewBag.Message = "Organation Save Fail";
                        ViewBag.Success = 0;
                    }

                }
                return PartialView("PartialView/Organizations/_CreatePartial");

            }
            return View("Index");
            //return PartialView("PartialView/Organizations/_CreatePartial");
        }


        public JsonResult Save(Organization aOrganization)
        {
            if (ModelState.IsValid)
            {
                bool isShortNameExist = _orgnationManager.IsShortNameExist(aOrganization.ShortName);

                if (isShortNameExist)
                {
                    ViewBag.Message = "This Organization Short Name Already Exist in Database";
                }
                else
                {
                    int successCount = _orgnationManager.Save(aOrganization);
                    if (successCount > 0)
                    {

                        ViewBag.Message = "Organation Successfully Save in Database";
                        ViewBag.Success = 1;
                        return Json(successCount, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        ViewBag.Message = "Organation Save Fail";
                        ViewBag.Success = 0;
                        return Json(0, JsonRequestBehavior.AllowGet);
                    }

                }
            }
            return Json(0, JsonRequestBehavior.AllowGet);
        }

    }
}