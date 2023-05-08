namespace Services
{
    public sealed class PersonLogic : IPersonLogic
    {
        private readonly IUnitOfWord _unit;
        private readonly IMapper _mapper;
        public PersonLogic(IUnitOfWord unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
        }

        public async Task<List<Object>> GetListTypeEmail()
        {
            List<TypeEmailEntity> list = await _unit.TypeEmail.GetAllAsync(
             x => x.IsActive == true,
             x => x.TypeEmailName
         );

            IEnumerable<Object> result = list.Select(x => new
            {
                TypeEmailNameID = x.TypeEmailID,
                TypeEmailName = x.TypeEmailName,
            }).ToList();

            return result.ToList();
        }
        public async Task<List<Object>> GetListTypePhone()
        {
            List<TypePhoneEntity> list = await _unit.TypePhone.GetAllAsync(
             x => x.IsActive == true,
             x => x.TypePhoneName
         );

            IEnumerable<Object> result = list.Select(x => new
            {
                x.TypePhoneID,
                x.TypePhoneName,
            }).ToList();

            return result.ToList();
        }
        public async Task<List<Object>> GetListTypePerson()
        {
            List<TypePersonEntity> list = await _unit.TypePerson.GetAllAsync(
             x => x.IsActive == true,
             x => x.TypePersonName
         );

            IEnumerable<Object> result = list.Select(x => new
            {
                x.TypePersonID,
                x.TypePersonName
            }).ToList();

            return result.ToList();
        }
    }
}