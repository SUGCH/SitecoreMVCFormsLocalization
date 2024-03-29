﻿namespace SUGCH2015.Website.Models
{
    using System.ComponentModel.DataAnnotations;
    using Properties;

    public class TraditionalViewModel
    {
        [Required]
        public string PropertyName { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [Display(Name = "This is a static name")]
        public string StaticName { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Required")]
        [Display(ResourceType = typeof(Resources), Name = "DisplayName")]
        public string ResourcesName { get; set; }
    }
}