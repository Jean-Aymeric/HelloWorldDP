using HelloWorld.Decorator;

namespace HelloWorld.AbstractFactory {
    class FactoryBorderUnderscoreSmiley : FactoryDecorated {
        protected override ICountry makeExtended(string name, ICountry country) {
            return new BorderUnderscore(new Smiley(this.FactorySimple.make(name)));
        }
    }
}

