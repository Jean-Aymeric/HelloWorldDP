using HelloWorld.Countries;
using HelloWorld.Decorator;

namespace HelloWorld.AbstractFactory {
    class FactoryBorderUnderscoreSmiley : AbstractFactoryHelloWorld {
        public override ICountry makeFrance() {
            return new BorderUnderscore(new Smiley(new France()));
        }

        public override ICountry makeIndonesia() {
            return new BorderUnderscore(new Smiley(new Indonesia()));
        }

        public override ICountry makeLatin() {
            return new BorderUnderscore(new Smiley(new LatinAdapted()));
        }

        public override ICountry makeUnitedKingdom() {
            return new BorderUnderscore(new Smiley(new UnitedKingdom()));
        }

        public override ICountry makeUnitedStatesOfAmerica() {
            return new BorderUnderscore(new Smiley(new UnitedStatesOfAmerica()));
        }
    }
}
