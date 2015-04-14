namespace SUGCH2015.Website.Controllers
{
    using System.Web.Mvc;
    using Models;

    public class TraditionalController : Controller
    {
        public ActionResult Index(TraditionalViewModel model = null)
        {
            return this.View(model ?? new TraditionalViewModel());
        }
    }
}