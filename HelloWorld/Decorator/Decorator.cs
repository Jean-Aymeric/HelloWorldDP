using System;

namespace HelloWorld.Decorator {
    class Decorator : ICountry {
        private ICountry _country;

        public Decorator(ICountry country) => this.Country = country;

        internal ICountry Country { get => _country; set => _country = value; }

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
