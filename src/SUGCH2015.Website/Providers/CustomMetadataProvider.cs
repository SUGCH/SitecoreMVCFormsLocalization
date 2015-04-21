namespace SUGCH2015.Website.Providers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web.Mvc;
    using Models;
    using Sitecore.Globalization;

    public class CustomMetadataProvider : DataAnnotationsModelMetadataProvider
    {
        protected override ModelMetadata CreateMetadata(
            IEnumerable<Attribute> attributes,
            Type containerType,
            Func<object> modelAccessor,
            Type modelType,
            string propertyName)
        {
            var propertyAttributes = attributes.ToList();
            var modelMetadata = base.CreateMetadata(propertyAttributes, containerType, modelAccessor, modelType, propertyName);

            if (IsTransformRequired(modelMetadata, propertyAttributes))
            {
                modelMetadata.DisplayName = Translate.Text(modelMetadata.PropertyName);
            }

            return modelMetadata;
        }

        private static bool IsTransformRequired(ModelMetadata modelMetadata, IList<Attribute> propertyAttributes)
        {
            if (modelMetadata.ModelType != typeof (DisplayNameViewModel)) return false;
            if (string.IsNullOrEmpty(modelMetadata.PropertyName)) return false;
            if (propertyAttributes.OfType<DisplayNameAttribute>().Any()) return false;
            return !propertyAttributes.OfType<DisplayAttribute>().Any();
        }
    }
}