using System.Threading.Tasks;
using Grpc.Core;
using MagicOnion.Client;
using MagicOnionSample.Shared;
using UnityEngine;

namespace MagicOnionSample.Unity
{
    public class SampleEntryPoint : MonoBehaviour
    {
        public string host = "localhost";
        public int port = 5000;

        public string user = "Foo";
        public string room = "Bar";

        private Channel _channel;
        private ISampleHub _hub;
        private ISampleHubReceiver _receiver;

        private async Task Start()
        {
            _channel = new Channel(host, port, ChannelCredentials.Insecure);

            var client = MagicOnionClient.Create<ISampleService>(_channel);
            var greet = await client.GreetAsync(user);
            Debug.Log(greet);

            _receiver = new SampleHubReceiver();
            _hub = StreamingHubClient.Connect<ISampleHub, ISampleHubReceiver>(_channel, _receiver);
            await _hub.JoinAsync(user, room);
        }

        private async Task OnDestroy()
        {
            await _hub.DisposeAsync();
            await _channel.ShutdownAsync();
        }
    }
}