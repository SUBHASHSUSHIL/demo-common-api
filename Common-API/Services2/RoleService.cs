using Common_API.DTOs;
using Common_API.Repositories1;
using Common_API.Services2.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Services2
{
    public class RoleService : IRoleService
    {
        private readonly RoleRepository _repository;

        public RoleService(RoleRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<RoleDTO>>GetRoleDetails()
        {
            var role = await _repository.GetAllRole();
            return role.Select(x => new RoleDTO
            {
                Name = x.Name,
                Description = x.Description,
                Status = x.Status
            });
        }
    }
}
