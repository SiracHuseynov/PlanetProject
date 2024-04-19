using Ccore.DataAccessLayer;
using Ccore.Enums;
using Ccore.Models;
using Ccore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ccore.Services.Concrets
{
    public class CountryService : ICountryService
    {
        public int CountTryByRegion(Region region)
        {
            return AppDb.Countries.Where(item => item.RegionType == region).ToList().Count;
        }

        public void CreateCountry(Country country)
        {
            AppDb.Countries.Add(country);
        }

        public List<Country> GetAllContries()
        {
            return AppDb.Countries;
        }

        public void RemoveCountry(string name)
        {
            Country country = AppDb.Countries.Find(item => item.CountryName == name);
            AppDb.Countries.Remove(country);

        }

        public void UpdateCountry(string name)
        {
            int choice;
            string newName;
            double newArea;
            string anthem;
            byte region;
            foreach (Country item in AppDb.Countries)
            {
                if (item.CountryName == name)
                {
                    Console.WriteLine("1.Name deyis");
                    Console.WriteLine("2.Area deyis");
                    Console.WriteLine("3.Anthem deyis");
                    Console.WriteLine("4.Region deyis");

                    do
                    {
                        Console.Write("Secim edin: ");
                    }
                    while (!int.TryParse(Console.ReadLine(), out choice));

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Deyismek istediyiniz adi daxil edin: ");
                            newName = Console.ReadLine();

                            item.CountryName = newName;
                            break;
                        case 2:
                            do
                            {
                                Console.WriteLine("Deyismek istediyiniz area  daxil edin: ");
                            }
                            while (!double.TryParse(Console.ReadLine(), out newArea));
                            item.Area = newArea;
                            break;
                        case 3:
                            Console.WriteLine("Deyismek istediyiniz anthem  daxil edin: ");
                            anthem = Console.ReadLine();
                            item.Anthem = anthem;

                            break;
                        case 4:
                            do
                            {
                                Console.WriteLine("Deyismek istediyiniz region daxil edin: ");
                            }
                            while (!byte.TryParse(Console.ReadLine(), out region));

                            item.RegionType = (Region)region;

                            break;
                    }

                }
            }
        }


    }
}
