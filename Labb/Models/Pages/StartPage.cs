using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace Labb.Models.Pages
{
    [ContentType(DisplayName = "Startsida", GUID = "da9a713c-0635-4992-8ba7-ed2c8e9858dd", Description = "Sitens startsida")]
    [AvailableContentTypes(Include = new[] {typeof(InfoPage)})]
    public class StartPage : BasePage
    {        
        [CultureSpecific]
        [Display(Name = "Blockyta",
            Description = "Lägg in block här",
            Order = 30)]
        public virtual ContentArea Blocks { get; set; }
    }
}