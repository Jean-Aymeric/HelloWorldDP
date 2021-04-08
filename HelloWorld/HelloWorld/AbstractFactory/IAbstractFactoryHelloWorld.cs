using System.Collections.Generic;

namespace HelloWorld.AbstractFactory {
    interface IAbstractFactoryHelloWorld {
        ICountry make(string name);
        List<string> getFactoryNames();
    }
}
