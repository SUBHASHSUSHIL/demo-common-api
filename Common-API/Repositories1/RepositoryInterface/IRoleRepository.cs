using Common_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Repositories1.RepositoryInterface
{
    public interface IRoleRepository
    {
        Task<Role> GetById(int id);
        Task<IEnumerable<Role>> GetAllRole();
    }
}
