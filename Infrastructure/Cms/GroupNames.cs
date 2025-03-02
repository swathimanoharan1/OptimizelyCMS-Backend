using System.ComponentModel.DataAnnotations;

namespace Backend.Infrastructure.Cms
{
    [GroupDefinitions]
    public class GroupNames
    {
        [Display(Name = "Default", Order = 10)]
        public const string Theme = "Default";

        [Display(Name = SystemTabNames.Content, Order = 20)]
        public const string Content = SystemTabNames.Content;

        [Display(Name = "Header", Order = 30)]
        public const string Header = "Header";

        [Display(Name = "Footer", Order = 40)]
        public const string Footer = "Footer";

        [Display(Name = "MetaData", Order = 50)]
        public const string MetaData = "MetaData";

        [Display(Name = "Breadcrumbs", Order = 60)]
        public const string Breadcrumbs = "Breadcrumbs";

        [Display(Name = SystemTabNames.Content, Order = 70)]
        public const string Settings = SystemTabNames.Settings;
    }
}
