using HelloWorld;
using HelloWorld.Interpreter;
using System;

namespace Main {
    abstract class HelloWorld {
        static void Main() {
            Context context = new Context();

            IExpression e = new DecoratorExpression("_", new DecoratorExpression("*", new CountryExpression("UK")));
            e.Interpreter(context);
            Console.WriteLine(context.Country.getHelloMessage());

            /*
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

            facadeHelloWorld.setFactory(FactoryType.BorderStarUnderscoreSmiley);
            foreach (string countryName in facadeHelloWorld.getFactoryNames()) {
                Console.WriteLine(facadeHelloWorld.make(countryName).getHelloMessage());
            }
            */
            Console.ReadLine();
        }
    }
}
