using HelloWorld.Builder;

namespace HelloWorld.AbstractFactory {
    class MakeLatin : FactoryMake {
        public MakeLatin() : base("Latin") { }

        public override ICountry make(string Name) {
            return new BuilderLatin().getCountry();
        }
    }
}
