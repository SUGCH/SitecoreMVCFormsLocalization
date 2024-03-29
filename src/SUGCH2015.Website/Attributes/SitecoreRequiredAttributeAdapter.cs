﻿namespace SUGCH2015.Website.Attributes
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

        public override IEnumerable<ModelClientValidationRule> GetClientValidationRules()
        {
            // consider the error message as a key, fall back to the attribute type name
            var key = this.Attribute.ErrorMessage;
            if (string.IsNullOrWhiteSpace(key))
            {
                key = this.Attribute.GetType().Name;
            }

            // translate with the calculated key
            var errorMessage = string.Format(CultureInfo.CurrentCulture, Translate.Text(key), this.Metadata.GetDisplayName());
            
            return new[] { new ModelClientValidationRequiredRule(errorMessage) };
        }

        #region hide for now

        public override IEnumerable<ModelValidationResult> Validate(object container)
        {
            // create the validation context
            var context = new ValidationContext(container ?? this.Metadata.Model, null, null)
                          {
                              DisplayName = this.Metadata.GetDisplayName()
                          };

            // handle the validation process 
            var result = this.Attribute.GetValidationResult(this.Metadata.Model, context);
            if (result == ValidationResult.Success) yield break;
            
            // override the result message
            yield return new ModelValidationResult
                         {
                             Message = this.GetMessage(context, result)
                         };
        }

        private string GetMessage(ValidationContext context, ValidationResult result)
        {
            // the next line is for demo purpose
            if (context.ObjectType != typeof(ClientSideValidationViewModel) && context.ObjectType != typeof(UltimateViewModel)) return result.ErrorMessage;

            // consider the error message as a key, fall back to the attribute type name
            var key = this.Attribute.ErrorMessage;
            if (string.IsNullOrWhiteSpace(key))
            {
                key = this.Attribute.GetType().Name;
            }

            // translate with the calculated key
            return string.Format(CultureInfo.CurrentCulture, Translate.Text(key), context.DisplayName);
        }

        #endregion
    }
}