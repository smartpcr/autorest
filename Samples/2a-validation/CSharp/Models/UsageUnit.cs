// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Storage.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for UsageUnit.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UsageUnit
    {
        [EnumMember(Value = "Count")]
        Count,
        [EnumMember(Value = "Bytes")]
        Bytes,
        [EnumMember(Value = "Seconds")]
        Seconds,
        [EnumMember(Value = "Percent")]
        Percent,
        [EnumMember(Value = "CountsPerSecond")]
        CountsPerSecond,
        [EnumMember(Value = "BytesPerSecond")]
        BytesPerSecond
    }
}
