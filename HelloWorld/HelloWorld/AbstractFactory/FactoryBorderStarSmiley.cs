using HelloWorld.Decorator;

namespace HelloWorld.AbstractFactory {
    class FactoryBorderStarSmiley : FactoryDecorated {
        protected override ICountry makeExtended(string name, ICountry country) {
            return new BorderStar(new Smiley(this.FactorySimple.make(name)));
        }
    }
}
