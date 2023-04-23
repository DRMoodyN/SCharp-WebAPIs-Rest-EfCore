using System;

namespace Services
{
    public interface ITypeEmailLogic
    {
        public Task<Object> AddAsync(TypeEmailDTO email, string user);
        public Task<List<Object>> GetList();
        public Task<string> DeleteLogic(int id, string user);
        public Task<string> Update(int id, TypePersonEntity model, string user);
    }
}
