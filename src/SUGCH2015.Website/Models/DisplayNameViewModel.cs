﻿namespace SUGCH2015.Website.Models
{
    using System.ComponentModel.DataAnnotations;
    using Attributes;

    public class DisplayNameViewModel
    {
        [Required]
        [SitecoreDisplayName("PropertyName")]
        public string PropertyName { get; set; }
    }
}