namespace Services
{
    public interface IPersonLogic
    {
        public Task<List<Object>> GetListTypeEmail();
        public Task<List<Object>> GetListTypePhone();
        public Task<List<Object>> GetListTypePerson();
    }
}
