namespace Services
{
    public interface IServiceManager
    {

        // Person
        ITypePersonLogic TypePersonLogic { get; }
        ITypeEmailLogic TypeEmailLogic { get; }

        IAuthenticationLogic AuthenticationLogic { get; }
    }
}
