using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace Labb.Models.Pages
{
    [ContentType(DisplayName = "BasePage", GUID = "1d7f0b86-7bb5-4235-88c5-ac3c4cf4a654", Description = "")]
    public class BasePage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Rubrik",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Brödtext",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual XhtmlString MainBody { get; set; }
    }
}