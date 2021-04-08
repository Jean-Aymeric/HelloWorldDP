using HelloWorld.AbstractFactory;

namespace HelloWorld {
    class FacadeHelloWorld : IAbstractFactoryHelloWorld {
        private static FacadeHelloWorld instance;
        private AbstractFactoryHelloWorld factory;

        private FacadeHelloWorld() {
            this.setFactory(FactoryType.Simple);
        }

        public void setFactory(FactoryType type) {
            switch (type) {
                case FactoryType.BorderStarSmiley:
                    this.factory = new FactoryBorderStarSmiley();
                    break;
                case FactoryType.BorderUnderscoreSmiley:
                    this.factory = new FactoryBorderUnderscoreSmiley();
                    break;
                default:
                    this.factory = new FactorySimple();
                    break;
            }
        }

        public static FacadeHelloWorld getInstance() {
            if (instance == null) {
                instance = new FacadeHelloWorld();
            }
            return instance;
        }

        public ICountry make() {
            return this.makeFrance();
        }

        public ICountry makeFrance() {
            return this.factory.makeFrance();
        }

        public ICountry makeIndonesia() {
            return this.factory.makeIndonesia();
        }

        public ICountry makeLatin() {
            return this.factory.makeLatin();
        }

        public ICountry makeUnitedKingdom() {
            return this.factory.makeUnitedKingdom();
        }

        public ICountry makeUnitedStatesOfAmerica() {
            return this.factory.makeUnitedStatesOfAmerica();
        }
    }
}
