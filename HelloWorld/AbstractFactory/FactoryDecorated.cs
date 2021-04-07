using HelloWorld.Countries;
using HelloWorld.Decorator;

namespace HelloWorld.AbstractFactory {
    abstract class FactoryDecorated : AbstractFactoryHelloWorld {
        protected AbstractFactoryHelloWorld FactorySimple { get; } = new FactorySimple();
    }
}
