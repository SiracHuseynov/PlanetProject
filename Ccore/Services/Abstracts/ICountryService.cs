using Ccore.Enums;
using Ccore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ccore.Services.Interfaces
{
    public interface ICountryService
    {
        void CreateCountry(Country country);
        void UpdateCountry(string name);
        void RemoveCountry(string name);
        List<Country> GetAllContries();
        int CountTryByRegion(Region region);

    }
}
