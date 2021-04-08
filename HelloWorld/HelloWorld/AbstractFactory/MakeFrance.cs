using HelloWorld.Builder;

namespace HelloWorld.AbstractFactory {
    class MakeFrance : FactoryMake {
        public MakeFrance() : base("France") { }

        public override ICountry make() {
            return new BuilderFrenchType1().getCountry();
        }
    }
}
