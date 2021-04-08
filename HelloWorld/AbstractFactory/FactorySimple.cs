using HelloWorld.Countries;

namespace HelloWorld.AbstractFactory {
    class FactorySimple : AbstractFactoryHelloWorld {
        public override ICountry makeFrance() {
            return new France();
        }

        public override ICountry makeIndonesia() {
            return new Indonesia();
        }

        public override ICountry makeLatin() {
            return new LatinAdapted();
        }

        public override ICountry makeUnitedKingdom() {
            return new UnitedKingdom();
        }

        public override ICountry makeUnitedStatesOfAmerica() {
            return new UnitedStatesOfAmerica();
        }
    }
}
