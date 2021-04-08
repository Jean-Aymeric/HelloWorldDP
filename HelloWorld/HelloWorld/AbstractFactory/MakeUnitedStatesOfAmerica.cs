using HelloWorld.Builder;

namespace HelloWorld.AbstractFactory {
    class MakeUnitedStatesOfAmerica : FactoryMake {
        public MakeUnitedStatesOfAmerica() : base("UnitedStatesOfAmerica") { }

        public override ICountry make(string Name) {
            return new BuilderUnitedStatesOfAmericaType2().getCountry();
        }
    }
}
