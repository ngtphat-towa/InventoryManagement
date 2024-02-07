using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Application.Commons.Interfaces.Services
{
    public interface IDataTimeProvider
    {
        DateTime UtcNow { get; }
    }
}
