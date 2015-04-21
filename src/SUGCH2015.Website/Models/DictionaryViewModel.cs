namespace SUGCH2015.Website.Models
{
    using System.ComponentModel.DataAnnotations;

    public class DictionaryViewModel
    {
        [Required]
        public string PropertyName { get; set; }
    }
}