using HelloWorld;
using HelloWorld.Command;
using System;

namespace Main {
    abstract class HelloWorld {
        static void Main() {
            FacadeHelloWorld facadeHelloWorld = FacadeHelloWorld.getInstance();
            facadeHelloWorld.displayPopup(facadeHelloWorld.makeByParse("uk Smiley * - *"));
            facadeHelloWorld.displayPopup(facadeHelloWorld.makeByParse("Indonesia Smiley / /"));

            foreach (string countryName in facadeHelloWorld.getFactoryNames()) {
                facadeHelloWorld.displayConsole(facadeHelloWorld.make(countryName));
            }

            facadeHelloWorld.setFactory(FactoryType.BorderStarSmiley);
            foreach (string countryName in facadeHelloWorld.getFactoryNames()) {
                facadeHelloWorld.displayConsole(facadeHelloWorld.make(countryName));
            }

            facadeHelloWorld.setFactory(FactoryType.BorderUnderscoreSmiley);
            foreach (string countryName in facadeHelloWorld.getFactoryNames()) {
                facadeHelloWorld.displayConsole(facadeHelloWorld.make(countryName));
            }

            facadeHelloWorld.setFactory(FactoryType.BorderStarUnderscoreSmiley);
            foreach (string countryName in facadeHelloWorld.getFactoryNames()) {
                facadeHelloWorld.displayConsole(facadeHelloWorld.make(countryName));
            }
            
            Console.ReadLine();
        }
    }
}
