﻿using System.Threading.Tasks;
using Abp.Application.Services;
using MobileVisit.Roles.Dto;

namespace MobileVisit.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
