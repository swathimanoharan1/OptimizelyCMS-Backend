using Backend.Features.Pages.Shared.Interfaces;
using Backend.Infrastructure.Cms;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Backend.Features.Pages.Shared
{
	public class SeoPageData : PageData, ISeoPageData
	{

        #region "MetaTags

        [CultureSpecific]
        [Display(
            GroupName = GroupNames.MetaData,
            Order = 10)]
        public virtual string? MetaTitle
        {
            get
            {
                var metaTitle = this.GetPropertyValue(p => p.MetaTitle);
                return string.IsNullOrEmpty(metaTitle) ? this.Name : metaTitle;
            }
            set => this.SetPropertyValue(p => p.MetaTitle, value);
        }

        [CultureSpecific]
        [Display(
            GroupName = GroupNames.MetaData,
            Order = 20)]
        [UIHint(UIHint.Textarea)]
        public virtual string? MetaDescription { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = GroupNames.MetaData,
            Order = 30)]
        public virtual IList<string>? MetaKeywords { get; set; }

        #endregion

    }
}
