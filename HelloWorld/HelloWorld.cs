using HelloWorld;
using System;

namespace Main {
    abstract class HelloWorld {
        static void Main() {
            FacadeHelloWorld facadeHelloWorld = FacadeHelloWorld.getInstance();
            foreach (string countryName in facadeHelloWorld.getFactoryNames()) {
                Console.WriteLine(facadeHelloWorld.make(countryName).getHelloMessage());
            }

            facadeHelloWorld.setFactory(FactoryType.BorderStarSmiley);
            foreach (string countryName in facadeHelloWorld.getFactoryNames()) {
                Console.WriteLine(facadeHelloWorld.make(countryName).getHelloMessage());
            }

            facadeHelloWorld.setFactory(FactoryType.BorderUnderscoreSmiley);
            foreach (string countryName in facadeHelloWorld.getFactoryNames()) {
                Console.WriteLine(facadeHelloWorld.make(countryName).getHelloMessage());
            }
            Console.ReadLine();
        }
    }
}
