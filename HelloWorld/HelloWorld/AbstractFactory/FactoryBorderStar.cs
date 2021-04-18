using HelloWorld.Decorator;

namespace HelloWorld.AbstractFactory {
    class FactoryBorderStar : FactoryDecorator {
        public FactoryBorderStar(IAbstractFactoryHelloWorld factoryHelloWorld) : base(factoryHelloWorld) {
        }

        protected override ICountry makeExtended(ICountry country) {
            return new BorderStar(country);
        }
    }
}

