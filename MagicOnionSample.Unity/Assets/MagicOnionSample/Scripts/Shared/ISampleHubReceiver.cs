namespace MagicOnionSample.Shared
{
    public interface ISampleHubReceiver
    {
        void OnJoin(Player player);
        void OnLeave(Player player);
    }
}