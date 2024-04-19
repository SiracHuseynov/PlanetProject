using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ccore.Models
{
    public class Planet
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public Planet(string name, double area)
        {
            Name = name;
            Area = area;    
        }

        public override string? ToString()
        {
            return $"Name: {Name}; Area: {Area}";
        }
    }
}
