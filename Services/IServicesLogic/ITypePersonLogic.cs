namespace Services
{
    public interface ITypePersonLogic
    {
        public Task<Object> AddAsync(TypePersonEntity model);
        public Task<List<TypePersonEntity>> GetList();
        public Task<string> DeleteLogic(int id);
        public Task<string> Update(int id, TypePersonEntity model);
    }
}
