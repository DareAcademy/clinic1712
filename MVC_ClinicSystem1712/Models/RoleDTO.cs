using System.ComponentModel.DataAnnotations;

namespace MVC_ClinicSystem1712.Models
{
    public class RoleDTO
    {
        [Required(ErrorMessage ="Please fill out the role name")]
        public string Name { get; set; }
    }
}
