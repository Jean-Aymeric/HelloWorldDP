using HelloWorld;
using System;

namespace Main {
    abstract class HelloWorld {
        static void Main() {
            FacadeHelloWorld facadeHelloWorld = FacadeHelloWorld.getInstance();
            facadeHelloWorld.setFactory(FactoryType.BorderUnderscoreSmiley);
            ICountry france = facadeHelloWorld.makeFrance();
            ICountry franceclone = (ICountry)france.Clone();
            Console.WriteLine(france.getHelloMessage());
            Console.WriteLine(franceclone.getHelloMessage());

            ICountry unitedKingdom = facadeHelloWorld.makeUnitedKingdom();
            Console.WriteLine(unitedKingdom.getHelloMessage());

            ICountry unitedStatesOfAmerica = facadeHelloWorld.makeUnitedStatesOfAmerica();
            Console.WriteLine(unitedStatesOfAmerica.getHelloMessage());

            ICountry indonesia = facadeHelloWorld.makeIndonesia();
            Console.WriteLine(indonesia.getHelloMessage());

            ICountry latin = facadeHelloWorld.makeLatin();
            Console.WriteLine(latin.getHelloMessage());

            Console.ReadLine();
        }
    }
}
