namespace SUGCH2015.Website.Models
{
    using System.ComponentModel.DataAnnotations;

    public class UltimateViewModel
    {
        [Required]
        public string MetadataProviderPropertyName { get; set; }
    }
}