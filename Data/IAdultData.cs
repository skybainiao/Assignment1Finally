using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace LoginExample.Data
{
    public interface IAdultData
    {
        Task<IList<Adult>> GetAdultsAsync();
        Task AddAdultAsync(Adult adult);

        Task RemoveAdultAsync(int id);
    }
}