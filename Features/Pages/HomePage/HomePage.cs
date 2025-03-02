using Backend.Features.Blocks.Shared;
using Backend.Features.Blocks.Shared.PropertyBlocks;
using Backend.Features.Pages.HomePage.Interfaces;
using Backend.Features.Pages.Shared;
using Backend.Infrastructure.Cms;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Backend.Features.Pages.HomePage
{
    [ContentType(GUID = "3c289849-fd6e-469a-884b-2394d4263151", 
        GroupName = GroupNames.Content,
        AvailableInEditMode = true)]
    [SiteImageUrl]
    [AvailableContentTypes(Availability.Specific, Include = new[] { typeof(ProductPage.ProductPage), typeof(HomePage) })]
	public class HomePage : SeoPageData, IHomePage
	{

        [Display(
            GroupName = GroupNames.Content,
            Order = 10)]
        public virtual ContentArea? MainContentArea { get; set; }

        #region "Footer"

        [Display(
            GroupName = GroupNames.Footer,
            Order = 10)]
        public virtual ContentArea? LinkArea { get; set; }

        [Display(
            GroupName = GroupNames.Footer,
            Order = 20)]
        public virtual ContentArea? SocialIcons { get; set; }

        [Display(
            GroupName = GroupNames.Footer,
            Order = 30)]
        public virtual LinkItemCollection? UtilityLinks { get; set; }

        [Display(
            GroupName = GroupNames.Footer,
            Order = 40)]
        public virtual ContactUsFooterPropertyBlock? ContactUs { get; set; }

        #endregion

        #region Header

        [Display(
            GroupName = GroupNames.Header,
            Order = 60)]
        public virtual string? SearchPlaceholderText { get; set; }

        #endregion
    }
}
