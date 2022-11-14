using Microsoft.AspNetCore.Identity;

namespace fiorello_project.Models
{
    public class User: IdentityUser
    {
        public string Fullname { get; set; }

    }
}
