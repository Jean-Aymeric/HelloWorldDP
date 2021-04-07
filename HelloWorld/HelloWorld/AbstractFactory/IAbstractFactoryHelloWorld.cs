namespace HelloWorld.AbstractFactory {
    interface IAbstractFactoryHelloWorld {
        ICountry makeLatin();
        ICountry makeFrance();
        ICountry makeUnitedKingdom();
        ICountry makeUnitedStatesOfAmerica();
        ICountry makeIndonesia();
    }
}
