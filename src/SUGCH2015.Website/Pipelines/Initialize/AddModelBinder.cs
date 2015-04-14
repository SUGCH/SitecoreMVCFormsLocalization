namespace SUGCH2015.Website.Pipelines.Initialize
{
    using System.Web.Mvc;
    using ModelBinder;
    using Models;
    using Sitecore.Pipelines;

    public class AddModelBinder
    {
        public void Process(PipelineArgs args)
        {
            ModelBinders.Binders.Add(typeof(ServerSideValidationViewModel), new SitecoreModelBinder());
        }
    }
}