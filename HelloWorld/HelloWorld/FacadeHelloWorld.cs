using HelloWorld.AbstractFactory;

namespace HelloWorld {
    class FacadeHelloWorld : IAbstractFactoryHelloWorld {
        private AbstractFactoryHelloWorld factory { get; set; }
        public ICountry makeFrance() {
            throw new System.NotImplementedException();
        }

        public ICountry makeIndonesia() {
            throw new System.NotImplementedException();
        }

        public ICountry makeLatin() {
            throw new System.NotImplementedException();
        }

        public ICountry makeUnitedKingdom() {
            throw new System.NotImplementedException();
        }

        public ICountry makeUnitedStatesOfAmerica() {
            throw new System.NotImplementedException();
        }
    }
}
