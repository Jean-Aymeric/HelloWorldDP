using HelloWorld.Decorator;

namespace HelloWorld.AbstractFactory {
    class FactoryBorderStarSmiley : FactoryDecorated {
        protected override ICountry makeExtended(ICountry country) {
            return new BorderStar(new Smiley(country));
        }
    }
}
