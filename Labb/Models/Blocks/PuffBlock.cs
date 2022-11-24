using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System;
using System.ComponentModel.DataAnnotations;

namespace Labb.Models.Blocks
{
    [ContentType(DisplayName = "Puff-block", GUID = "d6da379c-cec0-480e-b35b-cffda55af418", Description = "Block för att visa information")]
    public class PuffBlock : BlockData
    {   
        [CultureSpecific]
        [Display(
            Name = "Rubrik",
            Description = "Blockets rubrik",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Innehåll",
            Description = "Blockets Innehåll",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        [UIHint(UIHint.Textarea)]
        public virtual string Content { get; set; }

    }
}