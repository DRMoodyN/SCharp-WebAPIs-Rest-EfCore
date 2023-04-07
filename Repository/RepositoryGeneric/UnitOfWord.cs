using System;

namespace Repository.RepositoryGeneric
{
    public class UnitOfWord : IUnitOfWord
    {
        private readonly WmsDbContext _context;
        public UnitOfWord(WmsDbContext context)
        {
            _context = context;
        }

        private IRepositoryGeneric<PersonEntity> _person;
        private IRepositoryGeneric<RegionEntity> _region;
        private IRepositoryGeneric<TypeEmailEntity> _typeEmail;
        private IRepositoryGeneric<TypePersonEntity> _typePerson;
        private IRepositoryGeneric<TypePhoneEntity> _typePhone;
        //
        public IRepositoryGeneric<PersonEntity> Person
        => _person ??= new RepositoryGeneric<PersonEntity>(_context);

        public IRepositoryGeneric<RegionEntity> Region
        => _region ??= new RepositoryGeneric<RegionEntity>(_context);

        public IRepositoryGeneric<TypeEmailEntity> TypeEmail
        => _typeEmail ??= new RepositoryGeneric<TypeEmailEntity>(_context);

        public IRepositoryGeneric<TypePersonEntity> TypePerson
        => _typePerson ??= new RepositoryGeneric<TypePersonEntity>(_context);

        public IRepositoryGeneric<TypePhoneEntity> TypePhone
        => _typePhone ??= new RepositoryGeneric<TypePhoneEntity>(_context);

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}