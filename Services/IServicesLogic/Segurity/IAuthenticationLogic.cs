namespace Services
{
    public interface IAuthenticationLogic
    {
        Task<bool> ValidateUserAsync(Login model);
        Task<string> CreateTokenAsync();
    }
}
