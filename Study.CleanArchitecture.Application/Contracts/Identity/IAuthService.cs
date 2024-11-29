using Study.CleanArchitecture.Application.Models.Identity;

namespace Study.CleanArchitecture.Application.Contracts.Identity;

public interface IAuthService
{
    Task<AuthResponse> Login(AuthRequest request);
    Task<RegistrationResponse> Register(RegistrationRequest request);

}