namespace SUGCH2015.Website.ModelBinder
{
    using System.Linq;
    using System.Web.Mvc;
    using Sitecore.Globalization;

    public class SitecoreModelBinder : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            // bind the model
            var model = base.BindModel(controllerContext, bindingContext);

            // translate error messages
            if (!bindingContext.ModelState.IsValid)
            {
                foreach (var modelState in bindingContext.ModelState.Values)
                {
                    var allErrors = modelState.Errors.ToList();
                    foreach (var error in allErrors)
                    {
                        modelState.Errors.Remove(error);
                        modelState.Errors.Add(Translate.Text(error.ErrorMessage));
                    }
                }
            }

            // return model
            return model;
        }
    }
}