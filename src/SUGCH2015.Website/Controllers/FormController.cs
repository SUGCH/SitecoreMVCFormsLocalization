namespace SUGCH2015.Website.Controllers
{
    using System.Web.Mvc;
    using Models;
    using Providers;

    public class FormController : Controller
    {
        public FormController()
        {
            ModelMetadataProviders.Current = new CustomMetadataProvider();
        }

        public ActionResult Traditional(TraditionalViewModel model = null)
        {
            return this.View(model ?? new TraditionalViewModel());
        }

        public ActionResult Sitecore(SitecoreViewModel model = null)
        {
            return this.View(model ?? new SitecoreViewModel());
        }

        public ActionResult ServerSideValidation(ServerSideValidationViewModel model = null)
        {
            return this.View(model ?? new ServerSideValidationViewModel());
        }
    }
}