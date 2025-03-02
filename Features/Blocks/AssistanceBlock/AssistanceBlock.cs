using System;
using System.ComponentModel.DataAnnotations;
using Backend.Features.Blocks.AssistanceBlock.Interfaces;
using Backend.Features.Blocks.Shared;
using Backend.Infrastructure.Cms;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Microsoft.CodeAnalysis;

namespace Backend.Features.Blocks.AssistanceBlock
{
    [ContentType(DisplayName = "AssistanceBlock", GUID = "e9599fac-c023-41d5-a300-5a511bc75a3e", Description = "")]
    [SiteImageUrl]
    public class AssistanceBlock : SiteBlockData, IAssistanceBlock
    {

        [CultureSpecific]
        [Display(
            GroupName = GroupNames.Content,
            Order = 10)]
        [Required]
        public virtual string? Title1 { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = GroupNames.Content,
            Order = 20)]
        public virtual XhtmlString? Description1 { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = GroupNames.Content,
            Order = 30)]
        public virtual string? Title2 { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = GroupNames.Content,
            Order = 40)]
        public virtual string? LocationSelection { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = GroupNames.Content,
            Order = 50)]
        public virtual string? LanguageSelection { get; set; }

    }
}