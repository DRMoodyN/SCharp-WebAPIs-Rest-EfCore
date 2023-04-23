namespace Services
{
    public sealed class TypeEmailLogic : ITypeEmailLogic
    {
        private IUnitOfWord _unit;
        public TypeEmailLogic(IUnitOfWord unit)
        {
            _unit = unit;
        }

        public async Task<object> AddAsync(TypeEmailDTO email, string user)
        {
            TypeEmailEntity emailModel = new TypeEmailEntity()
            {
                TypeEmailName = email.TypeEmailName,
                UserCreate = user,
                UserModify = user,
                DateCreate = DateTime.UtcNow,
                DateModify = DateTime.UtcNow,
                IsActive = true
            };

            await _unit.TypeEmail.AddAsync(emailModel);
            await _unit.SaveAsync();

            return new
            {
                TypeEmailName = emailModel.TypeEmailID,
                UserCreate = emailModel.TypeEmailName,
            };
        }

        public Task<string> DeleteLogic(int id, string user)
        {
            throw new NotImplementedException();
        }

        public async Task<List<object>> GetList()
        {
            List<TypeEmailEntity> list = await _unit.TypeEmail.GetAllAsync(
                x => x.IsActive == true,
                x => x.TypeEmailName
            );

            var result = list.Select(x => new
            {
                TypeEmailNameID = x.TypeEmailID,
                TypeEmailName = x.TypeEmailName,
            });

            return (List<object>)result;
        }

        public Task<string> Update(int id, TypePersonEntity model, string user)
        {
            throw new NotImplementedException();
        }
    }
}
