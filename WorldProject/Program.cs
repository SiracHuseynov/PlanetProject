using Ccore.DataAccessLayer;
using Ccore.Enums;
using Ccore.Models;
using Ccore.Services.Concrets;

namespace WorldProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountryService countryService = new CountryService();
            PlanetService planetService = new PlanetService();

            bool f = false;
            bool check = true;
            bool checkSub = true;
            byte choice;
            string planetName;
            double area;
            string countryName;
            double areaCountry;
            string anthem;
            byte regionCountry;

            do
            {
            l1:
                Console.WriteLine("1.Sisteme Giris");
                Console.WriteLine("0.Cixis");
                do
                {
                    Console.WriteLine("Secim edin: ");
                }
                while (!byte.TryParse(Console.ReadLine(), out choice));

                switch (choice)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("1.Planet Yarat");
                            Console.WriteLine("2.Butun planetleri gor");
                            Console.WriteLine("3.Planet Sec");
                            Console.WriteLine("0.Exit");

                            do
                            {
                                Console.Write("Secim edin: ");
                            }
                            while (!byte.TryParse(Console.ReadLine(), out choice));

                            switch (choice)
                            {
                                case 1:
                                    Console.Write("Planet adini daxil edin: ");
                                    planetName = Console.ReadLine();

                                    do
                                    {
                                        Console.Write("Area daxil edin: ");
                                    }
                                    while (!double.TryParse(Console.ReadLine(), out area));

                                    Planet planet = new Planet(planetName, area);
                                    planetService.CreatePlanet(planet);
                                    break;
                                case 2:
                                    planetService.GetAllPlanets().ForEach(item => Console.WriteLine(item));
                                    break;
                                case 3:
                                    Console.Write("Secmek Planet adini daxil edin: ");
                                    planetName = Console.ReadLine();

                                    foreach (var item in planetService.GetAllPlanets())
                                    {
                                        if (item.Name == planetName)
                                        {
                                            Console.WriteLine(item);
                                            f = true;
                                        }
                                    }

                                    if (f == false)
                                    {
                                        goto l1;
                                    }

                                    do
                                    {
                                        Console.WriteLine("1.Olke Yarat");
                                        Console.WriteLine("2.Olke gor");
                                        Console.WriteLine("3.Evvelki Menu qayit");
                                        Console.WriteLine("0.Exit");

                                        do
                                        {
                                            Console.Write("Secim edin: ");
                                        }
                                        while (!byte.TryParse(Console.ReadLine(), out choice));

                                        switch (choice)
                                        {
                                            case 1:
                                                Console.Write("Olke adi daxil edin: ");
                                                countryName = Console.ReadLine();

                                                do
                                                {
                                                    Console.Write("Country Area daxil edin: ");
                                                }
                                                while (!double.TryParse(Console.ReadLine(), out areaCountry));
                                                Console.Write("Anthem daxil edin: ");
                                                anthem = Console.ReadLine();
                                                do
                                                {
                                                    Console.WriteLine("1.Avropa");
                                                    Console.WriteLine("2.Asiya");
                                                    Console.WriteLine("3.Afrika");
                                                    Console.WriteLine("4.Avstraliya");
                                                    Console.WriteLine("5.SimaliAmerika");
                                                    Console.WriteLine("6.CenubiAmerika");
                                                    Console.Write("Region Country daxil  edin: ");

                                                }
                                                while (!byte.TryParse(Console.ReadLine(), out regionCountry));

                                                Country country = new Country(countryName, areaCountry, anthem, (Region)regionCountry);
                                                countryService.CreateCountry(country);

                                                break;
                                            case 2:
                                                countryService.GetAllContries().ForEach(item => Console.WriteLine(item));
                                                break;
                                            case 3:
                                                checkSub = false;
                                                break;
                                            case 0:
                                                check = false;
                                                break;
                                        }

                                    }
                                    while (checkSub);

                                    break;
                                case 4:
                                    checkSub = false;
                                    break;
                            }

                        }
                        while (checkSub);


                        break;
                    case 0:
                        check = false;
                        break;
                }
            }
            while (check);
        }
    }
}