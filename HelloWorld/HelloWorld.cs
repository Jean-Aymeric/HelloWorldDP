using HelloWorld.Countries;
using HelloWorld.Decorator;
using System;

namespace HelloWorld {
    abstract class HelloWorld {
        static void Main() {
            ICountry france = new Smiley(new France());
            Console.WriteLine(france.getHelloMessage());
            ICountry unitedKingdom = new Border(new UnitedKingdom());
            Console.WriteLine(unitedKingdom.getHelloMessage());
            ICountry unitedStatesOfAmerica = new BorderStar(new Smiley(new UnitedStatesOfAmerica()));
            Console.WriteLine(unitedStatesOfAmerica.getHelloMessage());
            ICountry indonesia = new BorderUnderscore(new BorderStar(new Smiley(new Smiley(new Indonesia()))));
            Console.WriteLine(indonesia.getHelloMessage());
            Console.ReadLine();
        }
    }
}
