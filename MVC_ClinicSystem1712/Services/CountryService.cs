using AutoMapper;
using MVC_ClinicSystem1712.data;
using MVC_ClinicSystem1712.Models;
using System.Collections.Generic;

namespace MVC_ClinicSystem1712.Services
{
    public class CountryService : ICountryService
    {
        ClinicContext context;
        IMapper mapper;
        public CountryService(ClinicContext _context,IMapper _mapper)
        {
            //context = new ClinicContext();
            context = _context;
            mapper = _mapper;
        }

        public void Insert(CountryDTO countryDTO)
        {
            //Country newCountry = new Country();
            //newCountry.Id = countryDTO.Id;
            //newCountry.Name = countryDTO.Name;

            Country newCountry = mapper.Map<Country>(countryDTO);

            context.countries.Add(newCountry);
            context.SaveChanges();
        }

        public List<CountryDTO> GetAll()
        {
            //List<Country> allcountries = (from cnt in context.countries
            //                              select cnt).ToList();


            List<Country> allcountries = context.countries.ToList();

            List<CountryDTO> countries = new List<CountryDTO>();
            countries = mapper.Map<List<CountryDTO>>(allcountries);
            
            //foreach (Country item in allcountries)
            //{
            //    CountryDTO dto = new CountryDTO();
            //    dto.Id = item.Id;
            //    dto.Name = item.Name;
            //    countries.Add(dto);
            //}

            return countries;
        }

        public void Delete(int Id)
        {
            Country country = context.countries.Find(Id);
            context.countries.Remove(country);
            context.SaveChanges();


        }

    }
}
