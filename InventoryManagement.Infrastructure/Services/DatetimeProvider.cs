

using InventoryManagement.Application.Commons.Interfaces.Services;

namespace InventoryManagement.Infrastructure.Services
{
    public class DatetimeProvider : IDataTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
