namespace Services
{
    public interface IServiceManager
    {
        // Person
        IPersonLogic PersonLogic { get; }
        IAuthenticationLogic AuthenticationLogic { get; }
    }
}
