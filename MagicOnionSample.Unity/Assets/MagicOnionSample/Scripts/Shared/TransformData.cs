using MessagePack;
using UnityEngine;

namespace MagicOnionSample.Shared
{
    [MessagePackObject]
    public class TransformData
    {
        [Key(0)] public Vector3 Position { get; set; }

        [Key(1)] public Quaternion Rotation { get; set; }
    }
}