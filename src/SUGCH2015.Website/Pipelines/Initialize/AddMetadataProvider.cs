namespace SUGCH2015.Website.Pipelines.Initialize
{
    using System.Web.Mvc;
    using Providers;
    using Sitecore.Pipelines;

    public class AddMetadataProvider
    {
        public void Process(PipelineArgs args)
        {
            ModelMetadataProviders.Current = new CustomMetadataProvider();
        }
    }
}