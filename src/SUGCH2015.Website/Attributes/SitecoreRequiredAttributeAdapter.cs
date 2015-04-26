namespace SUGCH2015.Website.Attributes
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Web.Mvc;
    using Models;
    using Sitecore.Globalization;

    public class SitecoreRequiredAttributeAdapter : RequiredAttributeAdapter
    {
        public SitecoreRequiredAttributeAdapter(ModelMetadata metadata, ControllerContext context, RequiredAttribute attribute) : base(metadata, context, attribute)
        {
        }

        public override IEnumerable<ModelValidationResult> Validate(object container)
        {
            var context = new ValidationContext(container ?? this.Metadata.Model, null, null)
                          {
                              DisplayName = this.Metadata.GetDisplayName()
                          };

            var result = this.Attribute.GetValidationResult(this.Metadata.Model, context);
            if (result == ValidationResult.Success) yield break;
            
            yield return new ModelValidationResult
                         {
                             Message = this.GetMessage(context, result)
                         };
        }

        private string GetMessage(ValidationContext context, ValidationResult result)
        {
            // the next line is for demo purpose
            if (context.ObjectType != typeof (UltimateViewModel)) return result.ErrorMessage;

            var name = this.Attribute.ErrorMessage;
            if (string.IsNullOrWhiteSpace(name))
            {
                name = this.Attribute.GetType().Name;
            }

            return string.Format(CultureInfo.CurrentCulture, Translate.Text(name), context.DisplayName);
        }
    }
}