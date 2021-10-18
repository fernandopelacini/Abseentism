using Abseentism.Clases.Interfaces;
using Abseentism.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abseentism.Clases.Repository
{
    public class CountryRepository : ICountry
    {

        private AbseentismEntities _context = new AbseentismEntities();

        public async Task<bool> AddCountry(string country)
        {
            bool validate = await ValidateCountry(country);
            if (!validate)
            {

                var countryToSave = new Countries();

                countryToSave.country = country;

                _context.Countries.Add(countryToSave);
               await _context.SaveChangesAsync();

                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> EditCountry(Country country)
        {
            bool validate = await ValidateCountry(country.Pais);
            if (!validate)
            {
                var countryToUpdate = await _context.Countries.FindAsync(country.Id);
                if (countryToUpdate != null)
                {
                    countryToUpdate.country = country.Pais;

                    await _context.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public async Task<IEnumerable<Country>> GetCountries()
        {
            try
            {

                var countries = await _context.Countries
                    .AsNoTracking()
                    .OrderBy(x => x.country)
                    .ToListAsync();

                var model = new List<Country>();
                Country temp = new Country();
                temp.Id = 0;
                temp.Pais = Constants.SELECT_A_COUNTRY;
                model.Add(temp);

                foreach (var country in countries)
                {
                    Country pais = new Country();
                    pais.Id = country.id;
                    pais.Pais = country.country;
                    model.Add(pais);
                }
                return model;

            }
            catch (Exception ex)
            {
                //Regisrar el error
                return null;
            }
        }


       
        /// <summary>
        /// Validates the country doesn't exist in the repository 
        /// It returns true country does not exists
        /// </summary>
        /// <param name="countryname">country to be search</param>

        /// <returns></returns>
        private async Task<bool> ValidateCountry(string countryname)
        {
            return await _context.Countries.Where(c => c.country == countryname).AnyAsync();
        }


        public async Task<IEnumerable<Countries>> GetAll(string searchpattern)
        {
            var countries = from c in _context.Countries
                            select c;

            if (!string.IsNullOrEmpty(searchpattern))
            {
                countries = countries.Where(x => x.country.Contains(searchpattern));

            }
            
            return await countries.ToListAsync();


        }
    }
}
