using System;
using MagicOnion;
using MagicOnion.Server;
using MagicOnionSample.Shared;

namespace MagicOnionSample.Server.Services
{
    public class SampleService : ServiceBase<ISampleService>, ISampleService
    {
        public async UnaryResult<string> GreetAsync(string name)
        {
            await Console.Out.WriteLineAsync(name);
            return $"Welcome {name}!";
        }
    }
}