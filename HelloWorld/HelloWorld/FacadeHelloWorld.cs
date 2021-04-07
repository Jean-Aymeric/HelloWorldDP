using HelloWorld.AbstractFactory;

namespace HelloWorld {
    class FacadeHelloWorld : IAbstractFactoryHelloWorld {
        private AbstractFactoryHelloWorld factory;

        public FacadeHelloWorld() {
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
