using System;

namespace Services.IServicesLogic
{
    public interface ITypePersonLogic
    {
        public Task<Object> AddAsync(TypePersonEntity model);
    }
}
