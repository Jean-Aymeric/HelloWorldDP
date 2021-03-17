using HelloWorld.Country;
using HelloWorld.Country.Countries;
using System;

namespace HelloWorld {
    abstract class HelloWorld {
        static void Main(string[] args) {
            ICountry france = new France();
            Console.WriteLine(france.getHelloMessage());
            ICountry unitedKingdom = new UnitedKingdom();
            Console.WriteLine(unitedKingdom.getHelloMessage());
            ICountry unitedStatesOfAmerica = new UnitedStatesOfAmerica();
            Console.WriteLine(unitedStatesOfAmerica.getHelloMessage());
            ICountry indonesia = new Indonesia();
            Console.WriteLine(indonesia.getHelloMessage());
            Console.ReadLine();
        }
    }
}
