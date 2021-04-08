using HelloWorld.Builder;

namespace HelloWorld.AbstractFactory {
    class MakeUnitedKingdom : FactoryMake {
        public MakeUnitedKingdom() : base("UnitedKingdom") { }

        public override ICountry make(string Name) {
            return new BuilderUnitedKingdomType1().getCountry();
        }
    }
}
