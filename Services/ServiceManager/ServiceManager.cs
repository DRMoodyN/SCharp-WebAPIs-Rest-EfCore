using System;

namespace Services.ServiceManager
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<TypePersonLogic> _typePersonLogic;
        public ServiceManager(IUnitOfWord unit)
        {
            _typePersonLogic = new Lazy<TypePersonLogic>(() =>
                new TypePersonLogic(unit));
        }

        public ITypePersonLogic TypePersonLogic => _typePersonLogic.Value;
    }
}
