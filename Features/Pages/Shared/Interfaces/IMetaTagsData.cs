namespace Backend.Features.Pages.Shared.Interfaces
{
    public interface IMetaTagsData
    {
        string? MetaTitle { get; set; }
        string? MetaDescription { get; set; }
        IList<string>? MetaKeywords { get; set; }
    }
}
