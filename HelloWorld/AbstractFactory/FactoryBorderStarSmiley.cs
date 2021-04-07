using HelloWorld.Countries;
using HelloWorld.Decorator;

namespace HelloWorld.AbstractFactory {
    class FactoryBorderStarSmiley : FactoryDecorated {
        public override ICountry makeFrance() {
            return new BorderStar(new Smiley(FactorySimple.makeFrance()));
        }

        public override ICountry makeIndonesia() {
            return new BorderStar(new Smiley(FactorySimple.makeIndonesia()));
        }

        public override ICountry makeLatin() {
            return new BorderStar(new Smiley(FactorySimple.makeLatin()));
        }

        public override ICountry makeUnitedKingdom() {
            return new BorderStar(new Smiley(FactorySimple.makeUnitedKingdom()));
        }

        public override ICountry makeUnitedStatesOfAmerica() {
            return new BorderStar(new Smiley(FactorySimple.makeUnitedStatesOfAmerica()));
        }
    }
}
