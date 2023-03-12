﻿using IMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.PluginInterfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsersByName(string name);
    }
}
