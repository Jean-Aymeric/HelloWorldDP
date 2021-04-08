using System.Collections.Generic;

namespace HelloWorld.AbstractFactory {
    abstract class AbstractFactoryHelloWorld : IAbstractFactoryHelloWorld {
        private readonly List<FactoryMake> factoryMakes = new List<FactoryMake>();
        protected abstract ICountry makeExtended(string name, ICountry country);

        public ICountry make(string name) {
            foreach (FactoryMake factoryMake in factoryMakes) {
                if (factoryMake.isName(name)) {
                    return makeExtended(name, factoryMake.make());
                }
            }
            return null;
        }

        public List<string> getFactoryNames() { 
            List<string> listNames = new List<string>();
            foreach (FactoryMake factoryMake in factoryMakes) {
                listNames.Add(factoryMake.Name);
            }
            return listNames;
        }

        public void add(FactoryMake factoryMake) {
            factoryMakes.Add(factoryMake);
        }
    }
}
