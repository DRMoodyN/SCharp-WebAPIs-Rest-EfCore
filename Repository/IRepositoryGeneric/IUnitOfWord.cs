namespace Repository.IRepositoryGeneric
{
    public interface IUnitOfWord : IDisposable
    {
        IRepositoryGeneric<PersonEntity> Person { get; }
        IRepositoryGeneric<RegionEntity> Region { get; }
        IRepositoryGeneric<TypeEmailEntity> TypeEmail { get; }
        IRepositoryGeneric<TypePersonEntity> TypePerson { get; }
        IRepositoryGeneric<TypePhoneEntity> TypePhone { get; }

        Task SaveAsync();
    }
}
