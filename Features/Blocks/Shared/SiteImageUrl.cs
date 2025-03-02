namespace Backend.Features.Blocks.Shared
{
    public class SiteImageUrl : ImageUrlAttribute
    {
        public SiteImageUrl() : base("")
        {
        }

        public SiteImageUrl(string path) : base(path)
        {
        }
    }
}
