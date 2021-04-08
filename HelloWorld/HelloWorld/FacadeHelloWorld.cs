using HelloWorld.AbstractFactory;
using System.Collections.Generic;

namespace HelloWorld {
    class FacadeHelloWorld : IAbstractFactoryHelloWorld {
        private static FacadeHelloWorld instance;
        private IAbstractFactoryHelloWorld factory;

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
            return this.factory.make("France");
        }

        public ICountry makeIndonesia() {
            return this.factory.make("Indonesia");
        }

        public ICountry makeLatin() {
            return this.factory.make("Latin");
        }

        public ICountry makeUnitedKingdom() {
            return this.factory.make("UnitedKingdom");
        }

        public ICountry makeUnitedStatesOfAmerica() {
            return this.factory.make("UnitedStatesOfAmerica");
        }

        public ICountry make(string name) {
            return this.factory.make(name);
        }

        public List<string> getFactoryNames() {
            return this.factory.getFactoryNames();
        }
    }
}
