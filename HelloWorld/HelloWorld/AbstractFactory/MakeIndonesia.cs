using HelloWorld.Builder;
namespace HelloWorld.AbstractFactory {
    class MakeIndonesia : FactoryMake {
        public MakeIndonesia() : base("Indonesia") { }

        public override ICountry make(string Name) {
            return new BuilderIndonesianType2().getCountry();
        }
    }
}
