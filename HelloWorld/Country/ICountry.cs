namespace HelloWorld.Country {
    interface ICountry : IGetDate, IGetHello {
        string getHelloMessage();
    }
}
