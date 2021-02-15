using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetClinic.BLL.Services.Interfaces;
using VetClinic.DAL.Entities;

namespace VetClinic.BLL.Services.Realizations
{
    public class UserService : IUserService
    {
        public UserService(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            UserManager = userManager;
            RoleManager = roleManager;
        }

        public UserManager<User> UserManager { get; }
        public RoleManager<IdentityRole> RoleManager { get; }

        public async Task<(bool, string)> CreateUserAsync(User inputUser, params IdentityRole[] inputRoles)
        {
            var user = UserManager.FindByNameAsync(inputUser.UserName).Result;
            if (user == null)
            {
                //create user
                var result = UserManager.CreateAsync(inputUser, inputUser.PasswordHash).Result;

                if (!result.Succeeded)
                {
                    return (false, string.Empty);
                }

                //whitelist roles
                foreach (IdentityRole role in inputRoles)
                {
                    if (RoleManager.RoleExistsAsync(role.Name).Result)
                    {
                        _ = await UserManager.AddToRoleAsync(inputUser, role.Name);
                    }
                }

                return (true, UserManager.FindByNameAsync(inputUser.UserName).Result.Id);
            }
            return (false, string.Empty);
        }

        public async Task<bool> UpdateUserAsync(string id, User inputUser, params IdentityRole[] inputRoles)
        {
            var user = UserManager.FindByIdAsync(id).Result;

            if (user != null)
            {
                user.UserName = inputUser.UserName;
                user.FirstName = inputUser.FirstName;
                user.LastName = inputUser.LastName;
                user.Email = inputUser.Email;
                user.PhoneNumber = inputUser.PhoneNumber;
                user.IsDeleted = inputUser.IsDeleted;

                //We need to pull roles explicitly because they are in a different table
                var MyRoles = await UserManager.GetRolesAsync(user);

                _ = await UserManager.UpdateAsync(user);

                if (!Equals(MyRoles, inputRoles))
                {
                    _ = await UserManager.RemoveFromRolesAsync(user, MyRoles);
                    foreach (IdentityRole role in inputRoles)
                    {
                        if (RoleManager.RoleExistsAsync(role.Name).Result)
                        {
                            _ = await UserManager.AddToRoleAsync(user, role.Name);
                        }
                    }
                }

                _ = await UserManager.UpdateSecurityStampAsync(user);

                return true;
            }
            return false;
        }

        public async Task<bool> DeleteUserAsync(string id)
        {
            var user = await UserManager.FindByIdAsync(id);
            var result = await UserManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                return true;
            }

            return false;
        }

        public async Task<User> GetUser(string id)
        {
            return await UserManager.FindByIdAsync(id);
        }

        public async Task<bool> UserNameExistsAsync(string userName)
        {
            return await UserManager.FindByNameAsync(userName) != null;
        }

        public async Task<bool> ChangePassword(string id, string oldPassword, string newPassword)
        {
            User user = await GetUser(id);
            var result = await UserManager.ChangePasswordAsync(user, oldPassword, newPassword);

            if (result.Succeeded)
            {
                return true;
            }

            return false;
        }

        public async Task<bool> OldPasswordExists(string id, string passwordToCheck)
        {
            var user = await GetUser(id);

            if(user == null)
            {
                return false;
            }

            PasswordVerificationResult passwordMatch = UserManager.PasswordHasher.VerifyHashedPassword(user, user.PasswordHash, passwordToCheck);

            return passwordMatch == PasswordVerificationResult.Success;
        }

        private bool Equals(IEnumerable<string> arr1, IEnumerable<IdentityRole> arr2)
        {
            IEnumerable<string> roles = arr2.Select(arr2 => arr2.Name);

            return !arr1.Except(roles).Any() && !roles.Except(arr1).Any();
        }
    }
}
