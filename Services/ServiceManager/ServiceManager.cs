namespace Services
{
    public class ServiceManager : IServiceManager
    {
        // Person
        private readonly Lazy<TypePersonLogic> _typePersonLogic;
        private readonly Lazy<TypeEmailLogic> _typeEmailLogic;
        private readonly Lazy<AuthenticacionLogic> _authenticacionLogic;
        public ServiceManager(IUnitOfWord unit, UserManager<User> userManager, IMapper mapper)
        {
            // Person
            _typePersonLogic = new Lazy<TypePersonLogic>(() =>
                new TypePersonLogic(unit));

            _typeEmailLogic = new Lazy<TypeEmailLogic>(() =>
            new TypeEmailLogic(unit));

            _authenticacionLogic = new Lazy<AuthenticacionLogic>(() =>
                new AuthenticacionLogic(userManager, mapper));
        }

        public ITypePersonLogic TypePersonLogic => _typePersonLogic.Value;
        public IAuthenticationLogic AuthenticationLogic => _authenticacionLogic.Value;
        public ITypeEmailLogic TypeEmailLogic => _typeEmailLogic.Value;
    }
}
