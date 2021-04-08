using HelloWorld.Builder;
using HelloWorld.Countries;

namespace HelloWorld.AbstractFactory {
    class FactorySimple : AbstractFactoryHelloWorld {

        protected override ICountry makeExtended(string name, ICountry country) {
            return country;
        }
    }
}
