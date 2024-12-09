using Common_API.Data;
using Common_API.Models;
using Common_API.Repositories1.RepositoryInterface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Repositories1
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _context;

        public RoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Role>> GetAllRole()
        {
            return await _context.Roles.ToListAsync();
        }

        public Task<Role> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
