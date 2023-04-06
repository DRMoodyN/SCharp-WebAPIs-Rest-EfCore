using System;

namespace Services.ServiceLogic
{
    public class TypePersonLogic : ITypePersonLogic
    {
        private readonly IUnitOfWord _unit;
        public TypePersonLogic(IUnitOfWord unit)
        {
            _unit = unit;
        }

        public async Task<object> AddAsync(TypePersonEntity model)
        {
            var result = await _unit.TypePerson.AddAsync(model);
            await _unit.SaveAsync();
            return result;
        }
    }
}
