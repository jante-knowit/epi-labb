using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace Labb.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "da9a713c-0635-4992-8ba7-ed2c8e9858dd", Description = "Sitens startsida")]
    public class StartPage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Rubrik",
            Description ="Startsidans rubrik",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Brödtext",
            Description = "Texten på startsidan",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual XhtmlString MainBody { get; set; }

    }
}