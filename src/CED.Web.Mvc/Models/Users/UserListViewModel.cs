using System.Collections.Generic;
using CED.Roles.Dto;

namespace CED.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
