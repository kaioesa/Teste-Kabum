using IMS.CoreBusiness;
using IMS.UseCases.Interfaces;
using IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases
{
    public class ViewUsersByNameUseCase : IViewUsersByNameUseCase
    {
        private readonly IUserRepository _userRepository;

        public ViewUsersByNameUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> ExecuteAsync(string name = "")
        {
            return await _userRepository.GetAllUsersByName(name);
        }
    }
}
