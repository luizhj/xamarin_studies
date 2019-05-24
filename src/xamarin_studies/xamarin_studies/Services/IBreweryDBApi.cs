using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Refit;
using xamarin_studies.Models;

namespace xamarin_studies.Services
{
    public interface IBreweryDBApi
    {
        [Get("/v2/menu/countries?key={Apikey}")]
        Task<CountryMessage> GetCountriesMenu(string Apikey);
    }
}
