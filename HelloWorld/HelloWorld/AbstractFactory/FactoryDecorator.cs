using System.Collections.Generic;

namespace HelloWorld.AbstractFactory {
    abstract class FactoryDecorator : IAbstractFactoryHelloWorld {
        private IAbstractFactoryHelloWorld FactoryHelloWorld { get; }
        
        public FactoryDecorator(IAbstractFactoryHelloWorld factoryHelloWorld) {
            this.FactoryHelloWorld = factoryHelloWorld;
        }

        public List<string> getFactoryNames() {
            return FactoryHelloWorld.getFactoryNames();
        }

        public ICountry make(string name) {
            return makeExtended(FactoryHelloWorld.make(name));
        }

        protected abstract ICountry makeExtended(ICountry country);
    }
}
