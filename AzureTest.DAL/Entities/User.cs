using Microsoft.AspNetCore.Identity;

namespace VetClinic.DAL.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsDeleted { get; set; }

        public Client? Client { get; set; }
        public Doctor? Doctor { get; set; }
    }
}
