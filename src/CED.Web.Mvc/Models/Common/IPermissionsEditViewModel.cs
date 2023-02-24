using System.Collections.Generic;
using CED.Roles.Dto;

namespace CED.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}