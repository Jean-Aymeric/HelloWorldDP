using HelloWorld.Builder;

namespace HelloWorld.AbstractFactory {
    class MakeFrance : FactoryMake {
        public MakeFrance() : base("France") { }

        public override ICountry make(string Name) {
            return new BuilderFrenchType1().getCountry();
        }
    }
}
