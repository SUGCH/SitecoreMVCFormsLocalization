namespace SUGCH2015.Website.Models
{
    using Attributes;

    public class ServerSideValidationViewModel
    {
        [SitecoreRequired]
        public string MessageByAttribute { get; set; }

        [SitecoreRequired(ErrorMessage = "Field is required")]
        public string MessageByAttributeKey { get; set; }
    }
}