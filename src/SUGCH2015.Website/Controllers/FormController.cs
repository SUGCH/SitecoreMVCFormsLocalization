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

        public ActionResult Sitecore(SitecoreViewModel model = null)
        {
            return this.View(model ?? new SitecoreViewModel());
        }

        public ActionResult ServerSideValidation(ServerSideValidationViewModel model = null)
        {
            return this.View(model ?? new ServerSideValidationViewModel());
        }

        public ActionResult ClientSideValidation(ClientSideValidationViewModel model = null)
        {
            // enable client validation and unobtrusive javascript only for this action
            HtmlHelper.ClientValidationEnabled = true;
            HtmlHelper.UnobtrusiveJavaScriptEnabled = true;

            return this.View(model ?? new ClientSideValidationViewModel());
        }

        public ActionResult Ultimate(UltimateViewModel model = null)
        {
            return this.View(model ?? new UltimateViewModel());
        }
    }
}