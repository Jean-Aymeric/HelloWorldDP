using HelloWorld.Countries;
using HelloWorld.Decorator;

namespace HelloWorld.AbstractFactory {
    class FactoryBorderStarSmiley : AbstractFactoryHelloWorld {
        public override ICountry makeFrance() {
            return new BorderStar(new Smiley(new France()));
        }

        public override ICountry makeIndonesia() {
            return new BorderStar(new Smiley(new Indonesia()));
        }

        public override ICountry makeLatin() {
            return new BorderStar(new Smiley(new LatinAdapted()));
        }

        public override ICountry makeUnitedKingdom() {
            return new BorderStar(new Smiley(new UnitedKingdom()));
        }

        public override ICountry makeUnitedStatesOfAmerica() {
            return new BorderStar(new Smiley(new UnitedStatesOfAmerica()));
        }
    }
}
