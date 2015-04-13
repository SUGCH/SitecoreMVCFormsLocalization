namespace SUGCH2015.Website.Controllers
{
    using System.Web.Mvc;
    using Models;

    public class TraditionalController : Controller
    {
        public ActionResult Index()
        {
            return this.View(new TraditionalViewModel());
        }

        [HttpPost]
        public ActionResult Index(TraditionalViewModel model)
        {
            return this.View(model);
        }
    }
}