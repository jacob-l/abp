using Volo.Abp.ObjectExtending;

namespace Volo.Abp.Identity.Blazor.Pages.Identity
{
    public partial class RoleManagement 
    {
        protected override IIdentityRoleAppService AppService => RoleAppService;

        protected override void CreateUpdateInput(IdentityRoleDto entityDto)
        {
            _editingRole = new IdentityRoleUpdateDto
            {
                Name = entityDto.Name,
                ConcurrencyStamp = entityDto.ConcurrencyStamp,
                IsDefault = entityDto.IsDefault,
                IsPublic = entityDto.IsPublic
            };

            entityDto.MapExtraPropertiesTo(_editingRole);
        }
    }
}
