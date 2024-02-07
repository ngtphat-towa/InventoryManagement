using InventoryManagement.Domain.Entities;

namespace InventoryManagement.Application.Commons.Interfaces.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);

    }
}
