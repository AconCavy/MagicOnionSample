using MagicOnionSample.Shared;
using UnityEngine;

namespace MagicOnionSample.Unity
{
    public class SampleHubReceiver : ISampleHubReceiver
    {
        public void OnJoin(Player player)
        {
            Debug.Log($"{player.Name}, {player.Room}");
        }

        public void OnLeave(Player player)
        {
            Debug.Log($"{player.Name}, {player.Room}");
        }
    }
}