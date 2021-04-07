using HelloWorld.AbstractFactory;
using HelloWorld;
using System;

namespace Main {
    abstract class HelloWorld {
        static void Main() {
            AbstractFactoryHelloWorld factoryHelloWorld = new FactoryBorderStarSmiley();
            ICountry france = factoryHelloWorld.makeFrance();
            Console.WriteLine(france.getHelloMessage());

            ICountry unitedKingdom = factoryHelloWorld.makeUnitedKingdom();
            Console.WriteLine(unitedKingdom.getHelloMessage());

            ICountry unitedStatesOfAmerica = factoryHelloWorld.makeUnitedStatesOfAmerica();
            Console.WriteLine(unitedStatesOfAmerica.getHelloMessage());

            ICountry indonesia = factoryHelloWorld.makeIndonesia();
            Console.WriteLine(indonesia.getHelloMessage());

            ICountry latin = factoryHelloWorld.makeLatin();
            Console.WriteLine(latin.getHelloMessage());

            Console.ReadLine();
        }
    }
}
