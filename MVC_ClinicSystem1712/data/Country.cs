using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_ClinicSystem1712.data
{
    [Table("Countries")]
    public class Country
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public virtual List<Patient> patients { get; set; }
    }
}
