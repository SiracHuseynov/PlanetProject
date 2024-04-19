using Ccore.DataAccessLayer;
using Ccore.Enums;
using Ccore.Models;
using Ccore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ccore.Services.Concrets
{
    public class PlanetService : IPlanetService
    {
        public void CreatePlanet(Planet planet)
        {
            AppDb.Planets.Add(planet);
        }

        public List<Planet> GetAllPlanets()
        {
            return AppDb.Planets;
        }
    }
}
