using HelloWorld.Decorator;

namespace HelloWorld.AbstractFactory {
    class FactoryBorderUnderscoreSmiley : FactoryDecorated {
        protected override ICountry makeExtended(ICountry country) {
            return new BorderUnderscore(new Smiley(country));
        }
    }
}

