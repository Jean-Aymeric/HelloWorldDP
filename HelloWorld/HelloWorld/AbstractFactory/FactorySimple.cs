using HelloWorld.Builder;
using HelloWorld.Countries;

namespace HelloWorld.AbstractFactory {
    class FactorySimple : AbstractFactoryHelloWorld {
        public override ICountry makeFrance() {
            return (Country) new BuilderFrenchType1().getCountry();
        }

        public override ICountry makeIndonesia() {
            return (Country)new BuilderIndonesianType2().getCountry();
        }

        public override ICountry makeLatin() {
            return new LatinAdapted();
        }

        public override ICountry makeUnitedKingdom() {
            return (Country)new BuilderUnitedKingdomType1().getCountry();
        }

        public override ICountry makeUnitedStatesOfAmerica() {
            return (Country)new BuilderUnitedStatesOfAmericaType2().getCountry();
        }
    }
}
