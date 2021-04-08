using System.Collections.Generic;

namespace HelloWorld.AbstractFactory {
    abstract class FactoryDecorated : IAbstractFactoryHelloWorld {
        private IAbstractFactoryHelloWorld FactoryHelloWorld { get; } = new FactorySimple();
        
        protected abstract ICountry makeExtended(ICountry country);

        public List<string> getFactoryNames() {
            return FactoryHelloWorld.getFactoryNames();
        }

        public ICountry make(string name) {
            return makeExtended(FactoryHelloWorld.make(name));
        }
    }
}
