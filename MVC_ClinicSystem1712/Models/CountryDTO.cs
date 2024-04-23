using AutoMapper;
using MVC_ClinicSystem1712.data;
using System.ComponentModel.DataAnnotations;

namespace MVC_ClinicSystem1712.Models
{
    [AutoMap(typeof(Country),ReverseMap =true)]
    public class CountryDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please fill out the country name")]
        public string Name { get; set; }
    }
}
