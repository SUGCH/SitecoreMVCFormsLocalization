namespace SUGCH2015.Website.Models
{
    using System.ComponentModel.DataAnnotations;
    using Attributes;

    public class ServerSideValidationViewModel
    {
        [Required(ErrorMessage = "Field is required")]
        public string MessageByModelBinder { get; set; }
        
        [SitecoreRequired]
        public string MessageByAttribute { get; set; }

        [SitecoreRequired(ErrorMessage = "Field is required")]
        public string MessageByAttributeKey { get; set; }
    }
}