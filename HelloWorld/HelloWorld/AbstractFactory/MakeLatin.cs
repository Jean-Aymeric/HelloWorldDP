using HelloWorld.Builder;

namespace HelloWorld.AbstractFactory {
    class MakeLatin : FactoryMake {
        public MakeLatin() : base("Latin") { }

        public override ICountry make() {
            return new BuilderLatin().getCountry();
        }
    }
}
