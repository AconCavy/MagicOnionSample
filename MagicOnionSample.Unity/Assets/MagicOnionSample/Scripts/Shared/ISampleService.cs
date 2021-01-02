using MagicOnion;

namespace MagicOnionSample.Shared
{
    public interface ISampleService : IService<ISampleService>
    {
        UnaryResult<string> GreetAsync(string name);
    }
}