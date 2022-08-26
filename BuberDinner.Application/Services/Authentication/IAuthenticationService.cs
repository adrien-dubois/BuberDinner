namespace BuberDinner.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Login(string firstName, string lastName, string email, string password);
    AuthenticationResult Register(string email, string password);
}