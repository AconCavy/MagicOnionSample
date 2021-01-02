using System.Threading.Tasks;
using MagicOnion;

namespace MagicOnionSample.Shared
{
    public interface ISampleHub : IStreamingHub<ISampleHub, ISampleHubReceiver>
    {
        Task JoinAsync(string name, string room);
        Task LeaveAsync();
    }
}