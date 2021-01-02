using System;
using System.Threading.Tasks;
using MagicOnion.Server.Hubs;
using MagicOnionSample.Shared;

namespace MagicOnionSample.Server.Hubs
{
    public class SampleHub : StreamingHubBase<ISampleHub, ISampleHubReceiver>, ISampleHub
    {
        private Player _player;
        private IGroup _room;

        public async Task JoinAsync(string name, string room)
        {
            _player = new Player {Name = name, Room = room};
            await Console.Out.WriteLineAsync($"Join {_player.Name} to the {_player.Room}");
            (_room, _) = await Group.AddAsync(_player.Room, _player);
            Broadcast(_room).OnJoin(_player);
        }

        public async Task LeaveAsync()
        {
            await _room.RemoveAsync(Context);
            Broadcast(_room).OnLeave(_player);
        }
    }
}