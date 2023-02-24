using System.Collections.Generic;
using CED.Roles.Dto;

namespace CED.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
