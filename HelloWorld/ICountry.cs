namespace HelloWorld {
    interface ICountry : IGetDate, IGetHello {
        string getHelloMessage();
    }
}
