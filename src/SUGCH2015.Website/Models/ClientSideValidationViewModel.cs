namespace SUGCH2015.Website.Models
{
    using System.ComponentModel.DataAnnotations;

    public class ClientSideValidationViewModel
    {
        [Required]
        public string MessageByAttribute { get; set; }
        
        [Required(ErrorMessage = "Field is required")]
        public string MessageByAttributeKey { get; set; }
    }
}