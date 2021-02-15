using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using VetClinic.DAL.Entities;

namespace VetClinic.BLL.Services.Interfaces
{
    public interface IUserService
    {
        public Task<(bool, string)> CreateUserAsync(User inputUser, params IdentityRole[] inputRoles);
        public Task<bool> UpdateUserAsync(string id, User inputUser, params IdentityRole[] inputRoles);
        public Task<bool> DeleteUserAsync(string id);
        public Task<bool> UserNameExistsAsync(string userName);
        public Task<User> GetUser(string id);
        public Task<bool> ChangePassword(string id, string oldPassword, string newPassword);
        public Task<bool> OldPasswordExists(string id, string passwordToCheck);
    }
}
