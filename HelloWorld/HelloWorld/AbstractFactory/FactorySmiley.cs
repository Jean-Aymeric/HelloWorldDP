using HelloWorld.Decorator;

namespace HelloWorld.AbstractFactory {
    class FactorySmiley : FactoryDecorator {
        public FactorySmiley(IAbstractFactoryHelloWorld factoryHelloWorld) : base(factoryHelloWorld) {
        }

        protected override ICountry makeExtended(ICountry country) {
            return new Smiley(country);
        }
    }
}

