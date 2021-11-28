using System.Collections.Generic;
using System.Threading.Tasks;
using LoginExample.Models;
using Models;

namespace LoginExample.Data
{
    public interface IAdultData
    {
        Task<IList<Adult>> GetAdultsAsync();
        Task AddAdultAsync(Adult adult);

        Task RemoveAdultAsync(int id);

        Task<IList<User>> GetUsersAsync();

        Task AddUserAsync(User user);
    }
}