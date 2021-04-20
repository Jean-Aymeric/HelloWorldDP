using System;namespace HelloWorld.Countries {
    class ProxyCountry : ICountry {
        private ICountry Country { get; set; }

        public ProxyCountry(ICountry country) {
            Country = country;
        }

        public object Clone() {
            return (ICountry)this.MemberwiseClone();
        }

        public string getHelloMessage() {
            return Country.getHelloMessage();
        }
    }
}
