using System;
using System.ComponentModel.DataAnnotations;
using Backend.Features.Blocks.Shared.PropertyBlocks.Interfaces;
using Backend.Infrastructure.Cms;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace Backend.Features.Blocks.Shared.PropertyBlocks
{
    [ContentType(GUID = "f852121d-d3aa-40ae-8729-a82095db099e",
        GroupName = GroupNames.Content,
        AvailableInEditMode = false)]
    [SiteImageUrl]
    public class ButtonPropertyBlock : SitePropertyBlockData, IButtonPropertyBlock
    {

        [Display(GroupName = GroupNames.Content,
            Order = 10)]
        [CultureSpecific]
        public virtual LinkItem? Link { get; set; }

    }
}