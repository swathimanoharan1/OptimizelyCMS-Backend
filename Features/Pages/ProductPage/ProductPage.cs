using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Backend.Features.Pages.ProductPage
{
    [ContentType(DisplayName = "ProductPage", GUID = "5e243bb9-4cb7-41d6-86a0-f6f3a25ac5b3", Description = "")]
	public class ProductPage : PageData
	{
/*
        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }
 */
	}
}
