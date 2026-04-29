using Microsoft.AspNetCore.Identity;
namespace ApiConcertHub.Interfaces;

public interface IAuthService
{
    public Task<IdentityResult> Register(string mail, string password, string role);
}