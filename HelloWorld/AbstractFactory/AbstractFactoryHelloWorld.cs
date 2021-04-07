namespace HelloWorld.AbstractFactory {
    abstract class AbstractFactoryHelloWorld {
        public abstract ICountry makeLatin();
        public abstract ICountry makeFrance();
        public abstract ICountry makeUnitedKingdom();
        public abstract ICountry makeUnitedStatesOfAmerica();
        public abstract ICountry makeIndonesia();
    }
}
