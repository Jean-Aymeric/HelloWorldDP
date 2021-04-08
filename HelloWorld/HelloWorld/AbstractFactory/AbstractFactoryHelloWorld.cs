using System.Collections.Generic;

namespace HelloWorld.AbstractFactory {
    abstract class AbstractFactoryHelloWorld : IAbstractFactoryHelloWorld {
        private List<FactoryMake> factoryMakes;

        public ICountry make(string name) {
            throw new System.NotImplementedException();
        }

        List<string> IAbstractFactoryHelloWorld.getFactoryNames() {
            List<string> listNames = new List<string>();
            foreach (FactoryMake factoryMake in factoryMakes) {
                listNames.Add(factoryMake.Name);
            }
            return listNames;
        }
    }
}
