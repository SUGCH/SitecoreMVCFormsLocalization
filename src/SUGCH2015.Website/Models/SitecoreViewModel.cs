namespace SUGCH2015.Website.Models
{
    using Attributes;

    public class SitecoreViewModel
    {
        public string SimplePropertyName { get; set; }

        [SitecoreDisplayName("CustomAttributePropertyName")]
        public string CustomAttributePropertyName { get; set; }

        public string MetadataProviderPropertyName { get; set; }
    }
}