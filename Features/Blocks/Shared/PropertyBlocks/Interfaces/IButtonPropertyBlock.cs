using Backend.Features.Blocks.Shared.Interfaces;
using EPiServer.SpecializedProperties;

namespace Backend.Features.Blocks.Shared.PropertyBlocks.Interfaces
{
    public interface IButtonPropertyBlock : ISitePropertyBlockData
    {
        LinkItem? Link { get; set; }
    }
}
