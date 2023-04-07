namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<TypePersonLogic> _typePersonLogic;
        private readonly Lazy<AuthenticacionLogic> _authenticacionLogic;
        public ServiceManager(IUnitOfWord unit, UserManager<User> userManager, IMapper mapper)
        {
            _typePersonLogic = new Lazy<TypePersonLogic>(() =>
                new TypePersonLogic(unit));

            _authenticacionLogic = new Lazy<AuthenticacionLogic>(() =>
                new AuthenticacionLogic(userManager, mapper));
        }

        public ITypePersonLogic TypePersonLogic => _typePersonLogic.Value;
        public IAuthenticationLogic AuthenticationLogic => _authenticacionLogic.Value;
    }
}
