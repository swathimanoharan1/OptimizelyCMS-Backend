using Backend.Features.Pages.Shared.Interfaces;
using Backend.Infrastructure.Cms;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Backend.Features.Pages.Shared
{
    /// <summary>
    /// Base class for all seo/non-seo page types
    /// </summary>
	public class SitePageData : PageData, ISitePageData
	{

        #region

        [Display(
            GroupName = GroupNames.Breadcrumbs,
            Order = 40)]
        [Searchable]
        [Editable(false)]
        public virtual IList<string>? BreadcrumbsData { get; set; }

        #endregion
    }
}
