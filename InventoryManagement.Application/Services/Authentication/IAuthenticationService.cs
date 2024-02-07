namespace InventoryManagement.Application.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResult> Register(
            string FirstName,
            string LastName,
            string Email,
            string Password,
            string PhoneNumber
        );
        Task<AuthenticationResult> Login(
          string Email,
          string Password
      );
    }
}
