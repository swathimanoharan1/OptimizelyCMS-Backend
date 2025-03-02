using Backend.Features.Blocks.Shared.Interfaces;

namespace Backend.Features.Blocks.Shared
{
    /// <summary>
    /// Base class for all block types on this site
    /// </summary>
    public abstract class SiteBlockData : BlockData, ISiteBlockData
    {
    }
}
