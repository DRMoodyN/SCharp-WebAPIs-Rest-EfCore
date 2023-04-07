namespace Services
{
    public interface IServiceManager
    {
        ITypePersonLogic TypePersonLogic { get; }

        IAuthenticationLogic AuthenticationLogic { get; }
    }
}
