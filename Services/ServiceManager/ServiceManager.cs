namespace Services
{
    public class ServiceManager : IServiceManager
    {
        // Person
        private readonly Lazy<PersonLogic> _personLogic;
        private readonly Lazy<AuthenticacionLogic> _authenticacionLogic;
        public ServiceManager(IUnitOfWord unit, UserManager<User> userManager, IMapper mapper)
        {
            // Person
            _personLogic = new Lazy<PersonLogic>(() =>
                new PersonLogic(unit, mapper));

            _authenticacionLogic = new Lazy<AuthenticacionLogic>(() =>
                new AuthenticacionLogic(userManager, mapper));
        }

        public IAuthenticationLogic AuthenticationLogic => _authenticacionLogic.Value;

        public IPersonLogic PersonLogic => _personLogic.Value;
    }
}
