using HelloWorld.Builder;
using HelloWorld.Countries;

namespace HelloWorld.AbstractFactory {
    class FactorySimple : AbstractFactoryHelloWorld {
        public override ICountry makeFrance() {
            return new BuilderFrenchType1().getCountry();
        }

        public override ICountry makeIndonesia() {
            return new BuilderIndonesianType2().getCountry();
        }

        public override ICountry makeLatin() {
            return new LatinAdapted();
        }

        public override ICountry makeUnitedKingdom() {
            return new BuilderUnitedKingdomType1().getCountry();
        }

        public override ICountry makeUnitedStatesOfAmerica() {
            return new BuilderUnitedStatesOfAmericaType2().getCountry();
        }
    }
}
