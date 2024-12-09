using Common_API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Services2.ServiceInterface
{
    public interface IRoleService
    {
        Task<IEnumerable<RoleDTO>> GetRoleDetails();
    }
}
