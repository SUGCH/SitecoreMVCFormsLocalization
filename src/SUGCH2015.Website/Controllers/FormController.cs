namespace SUGCH2015.Website.Controllers
{
    using System.Web.Mvc;
    using Models;

    public class FormController : Controller
    {
        public ActionResult Traditional(TraditionalViewModel model = null)
        {
            return this.View(model ?? new TraditionalViewModel());
        }

        public ActionResult ServerSideValidation(ServerSideValidationViewModel model = null)
        {
            return this.View(model ?? new ServerSideValidationViewModel());
        }
    }
}