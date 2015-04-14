namespace SUGCH2015.Website.Models
{
    using System.ComponentModel.DataAnnotations;

    public class ServerSideValidationViewModel
    {
        [Required(ErrorMessage = "Field is required")]
        public string MessageByKey { get; set; }
    }
}