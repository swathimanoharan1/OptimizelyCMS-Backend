using System;
using System.ComponentModel.DataAnnotations;
using Backend.Infrastructure.Cms;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Backend.Features.Blocks.Shared.PropertyBlocks
{
    [ContentType(GUID = "e893da47-17bf-4857-afd2-36bfdcef9132", 
        GroupName = GroupNames.Content,
        AvailableInEditMode = false)]
    [SiteImageUrl]
    public class ContactUsFooterPropertyBlock : SitePropertyBlockData
    {

        [Display(
            GroupName = GroupNames.Content,
            Order = 10)]
        [CultureSpecific]
        [Required]
        [StringLength(100)]
        public virtual string? Title { get; set; }


        [Display(
            GroupName = GroupNames.Content,
            Order = 20)]
        public virtual ContentReference? ImageLinks { get; set; }

        [Display(
            GroupName = GroupNames.Content,
            Order = 30)]
        public virtual ButtonPropertyBlock? CTAButton { get; set; }

    }
}