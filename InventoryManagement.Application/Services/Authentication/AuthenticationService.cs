

using InventoryManagement.Application.Commons.Interfaces.Authentication;
using InventoryManagement.Application.Commons.Interfaces.Services;
using InventoryManagement.Domain.Entities;

namespace InventoryManagement.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IDataTimeProvider _dataTimeProvider;

        public AuthenticationService(
            IJwtTokenGenerator jwtTokenGenerator,
            IDataTimeProvider dataTimeProvider)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _dataTimeProvider = dataTimeProvider;
        }

        public Task<AuthenticationResult> Login(string Email, string Password)
        {
            // 1. Check if the email exist or not
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "This is tempolary first name",
                LastName = "This is tempolary last name",
                Email = Email,
                Password = Password
            };
            // 2. Check hashed password is valid
            // 3. Generate token 
            var token = _jwtTokenGenerator.GenerateToken(user);

            return Task.FromResult(new AuthenticationResult(
                user.Id,
                user.FirstName,
                user.LastName,
                user.Email,
                token));
        }

        public Task<AuthenticationResult> Register(
            string FirstName,
            string LastName,
            string Email,
            string Password,
            string PhoneNumber)
        {
            // 1. Check if email exists not
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = FirstName,
                LastName =LastName,
                Email = Email,
                Password = Password,
                PhoneNumber = PhoneNumber
            };
            // 2. Create UID and save into database

            // 3. Generate token  
            var token = _jwtTokenGenerator.GenerateToken(user);
            return Task.FromResult(new AuthenticationResult(
                user.Id,
                user.FirstName,
                user.LastName,
                user.Email,
                token));
        }  
    }
}
