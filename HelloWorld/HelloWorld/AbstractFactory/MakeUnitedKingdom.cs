using HelloWorld.Builder;

namespace HelloWorld.AbstractFactory {
    class MakeUnitedKingdom : FactoryMake {
        public MakeUnitedKingdom() : base("UnitedKingdom") { }

        public override ICountry make() {
            return new BuilderEnglishType1().getCountry();
        }
    }
}
