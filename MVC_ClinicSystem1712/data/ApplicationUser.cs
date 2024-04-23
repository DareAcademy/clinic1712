using Microsoft.AspNetCore.Identity;

namespace MVC_ClinicSystem1712.data
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }

        public DateTime DOB { get; set; }
    }
}
