using MVC_ClinicSystem1712.Models;

namespace MVC_ClinicSystem1712.Services
{
    public interface ICountryService
    {
        void Insert(CountryDTO countryDTO);

        List<CountryDTO> GetAll();

        void Delete(int Id);

    }
}
