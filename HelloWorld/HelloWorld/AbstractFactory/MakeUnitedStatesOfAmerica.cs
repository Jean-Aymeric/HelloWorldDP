using HelloWorld.Builder;

namespace HelloWorld.AbstractFactory {
    class MakeUnitedStatesOfAmerica : FactoryMake {
        public MakeUnitedStatesOfAmerica() : base("UnitedStatesOfAmerica") { }

        public override ICountry make() {
            return new BuilderEnglishType2().getCountry();
        }
    }
}
