using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Plugins.EFCore
{
    public class UserRepository : IUserRepository
    {
        private readonly IMSContext _db;

        public UserRepository(IMSContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<User>> GetAllUsersByName(string name)
        {
            return await _db.Users.Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase) ||
                                        string.IsNullOrWhiteSpace(name)).ToListAsync();

        }
    }
}
