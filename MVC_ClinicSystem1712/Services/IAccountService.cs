using Microsoft.AspNetCore.Identity;
using MVC_ClinicSystem1712.Models;

namespace MVC_ClinicSystem1712.Services
{
    public interface IAccountService
    {
        Task<IdentityResult> CreateAccount(SignUpDTO signUpDTO);

        Task<SignInResult> SignIn(SignInDTO signInDTO);

        Task<IdentityResult> CreateRole(RoleDTO dto);

        Task<List<UserDTO>> GetUsers();

        Task<List<UserRolesDTO>> GetRoles(string UserId);

        Task UpdateUserRoles(List<UserRolesDTO> userRoles);

        Task Logout();
    }
}
