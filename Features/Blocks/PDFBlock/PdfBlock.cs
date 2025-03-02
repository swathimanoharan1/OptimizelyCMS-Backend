using Backend.Features.Blocks.PDFBlock.Interfaces;
using Backend.Features.Blocks.Shared;
using Backend.Infrastructure.Cms;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System;
using System.ComponentModel.DataAnnotations;

namespace Backend.Features.Blocks.PDFBlock
{
    [ContentType(GUID = "74c8d3d5-5140-4deb-83a0-4636f474967c", 
        GroupName = GroupNames.Content)]
    [SiteImageUrl]
    public class PdfBlock : SiteBlockData, IPDFBlock
    {
        [Display(GroupName = GroupNames.Content,
            Order = 10)]
        [CultureSpecific]
        [Searchable]
        [Required]
        public virtual string? Title { get; set; }

        [Display(GroupName = GroupNames.Content, 
            Order = 20)]
        public virtual string? Description { get; set; }
    }
}