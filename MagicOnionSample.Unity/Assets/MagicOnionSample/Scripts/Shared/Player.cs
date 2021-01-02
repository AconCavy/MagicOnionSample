using System.Collections.Generic;
using MessagePack;

namespace MagicOnionSample.Shared
{
    [MessagePackObject]
    public class Player
    {
        [Key(0)] public string Name { get; set; }
        [Key(1)] public string Room { get; set; }
        [Key(2)] public List<TransformData> Transforms { get; set; } = new List<TransformData>();
    }
}