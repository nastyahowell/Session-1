using Microsoft.AspNetCore.Identity;

namespace vstrechashop.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
