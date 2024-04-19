using Ccore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ccore.Models
{
    public class Country
    {
        public string CountryName { get; set; }
        public double Area { get; set; }
        public string Anthem { get; set; }
        public Region RegionType { get; set; }

        public Country(string countryName, double area, string anthem, Region regionType)
        {
            CountryName = countryName;
            Area = area;
            Anthem = anthem;
            RegionType = regionType;
        }


        public override string? ToString()
        {
            return $"Name: {CountryName}; Area: {Area}; Anthem: {Anthem}; Region Type {RegionType}";
        }



    }
}
