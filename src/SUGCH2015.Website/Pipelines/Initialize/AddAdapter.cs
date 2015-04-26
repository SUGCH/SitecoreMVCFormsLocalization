namespace SUGCH2015.Website.Pipelines.Initialize
{
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using Attributes;
    using Sitecore.Pipelines;

    public class AddAdapter
    {
        public void Process(PipelineArgs args)
        {
            DataAnnotationsModelValidatorProvider.RegisterAdapter(typeof(RequiredAttribute), typeof(SitecoreRequiredAttributeAdapter));
        }
    }
}