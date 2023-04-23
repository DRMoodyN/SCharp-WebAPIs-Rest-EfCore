namespace Services
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

        public async Task<List<TypePersonEntity>> GetList()
        {
            var result = await _unit.TypePerson.GetAllAsync(
                x => x.IsActive == true,
                x => x.TypePersonName,
                "");

            return result;
        }

        public async Task<string> DeleteLogic(int id)
        {
            if (await _unit.TypePerson.AnyPropertyAsync(x => x.TypePersonID == id && x.IsActive == true))
            {
                TypePersonEntity model = await _unit.TypePerson.GetIdAsync(x => x.TypePersonID == id);
                model.IsActive = false;

                _unit.TypePerson.Update(model);
                await _unit.SaveAsync();

                return "El tipo de Persona fue borrada correctamente";
            }
            return "El Type de Persona No existe";
        }

        public async Task<string> Update(int id, TypePersonEntity model)
        {
            if (await _unit.TypePerson.AnyPropertyAsync(x => x.TypePersonID == id && x.IsActive == true))
            {
                TypePersonEntity typePerson = await _unit.TypePerson.GetIdAsync(x => x.TypePersonID == id);
                typePerson.TypePersonName = model.TypePersonName;
                typePerson.UserModify = model.UserModify;
                typePerson.DateModify = DateTime.UtcNow;

                _unit.TypePerson.Update(model);
                await _unit.SaveAsync();

                return "El tipo de Persona fue Actualizada correctamente";
            }
            return "El Tipo de Persona No existe";
        }
    }
}
