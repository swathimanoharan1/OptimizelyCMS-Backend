using System.Runtime.Serialization;

namespace Backend.Features.Core.Enums
{
    public enum OpenGraphType
    {
        [EnumMember(Value = "article")]
        Article,
        [EnumMember(Value = "profile")]
        Profile,
        [EnumMember(Value = "website")]
        Website
    }
}
