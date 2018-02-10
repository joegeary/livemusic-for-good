using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LiveMusicForGood.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string GivenName { get; set; }
    }
}
