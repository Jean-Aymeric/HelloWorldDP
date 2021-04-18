using HelloWorld.Decorator;

namespace HelloWorld.AbstractFactory {
    class FactoryBorderUnderscore : FactoryDecorator {
        public FactoryBorderUnderscore(IAbstractFactoryHelloWorld factoryHelloWorld) : base(factoryHelloWorld) {
        }

        protected override ICountry makeExtended(ICountry country) {
            return new BorderUnderscore(country);
        }
    }
}

