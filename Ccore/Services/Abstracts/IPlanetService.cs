using Ccore.Enums;
using Ccore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ccore.Services.Interfaces
{
    public interface IPlanetService
    {
        void CreatePlanet(Planet planet);
        List<Planet> GetAllPlanets();

    }
}
