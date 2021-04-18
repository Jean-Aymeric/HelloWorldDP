using HelloWorld.Builder;
using HelloWorld.Countries;

namespace HelloWorld.AbstractFactory {
    class FactorySimple : AbstractFactoryHelloWorld {

        public FactorySimple() {
            this.add(new MakeFrance());
            this.add(new MakeUnitedKingdom());
            this.add(new MakeUnitedStatesOfAmerica());
            this.add(new MakeIndonesia());
            this.add(new MakeLatin());
        }
    }
}
