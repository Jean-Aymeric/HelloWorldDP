using System;

namespace HelloWorld.Decorator {
    class Decorator : ICountry {
        public ICountry Country { get; set; }

        public Decorator(ICountry country) => this.Country = country;

        public string getDate() {
            throw new NotImplementedException();
        }

        public string getHello() {
            throw new NotImplementedException();
        }

        public string getHelloMessage() {
            throw new NotImplementedException();
        }
    }
}
