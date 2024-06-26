﻿using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Interfaces
{
    public interface IPermissionRepository : IRepository<Permission>
    {
        Task<List<Permission>> GetAllPermissionsByEmployeeID(int id);
        Task<List<Permission>> GetPermissionsWithEmployees();

    }
}
