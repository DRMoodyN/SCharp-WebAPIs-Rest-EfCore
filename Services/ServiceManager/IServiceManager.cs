using System;

namespace Services.ServiceManager
{
    public interface IServiceManager
    {
        ITypePersonLogic TypePersonLogic { get; }
    }
}
