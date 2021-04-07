using HelloWorld.Countries;
using HelloWorld.Decorator;

namespace HelloWorld.AbstractFactory {
    class FactoryBorderUnderscoreSmiley : FactoryDecorated {
        public override ICountry makeFrance() {
            return new BorderUnderscore(new Smiley(FactorySimple.makeFrance()));
        }

        public override ICountry makeIndonesia() {
            return new BorderUnderscore(new Smiley(FactorySimple.makeIndonesia()));
        }

        public override ICountry makeLatin() {
            return new BorderUnderscore(new Smiley(FactorySimple.makeLatin()));
        }

        public override ICountry makeUnitedKingdom() {
            return new BorderUnderscore(new Smiley(FactorySimple.makeUnitedKingdom()));
        }

        public override ICountry makeUnitedStatesOfAmerica() {
            return new BorderUnderscore(new Smiley(FactorySimple.makeUnitedStatesOfAmerica()));
        }
    }
}
