using System;
namespace HelloWorld.Countries {
    class ProxyCountry : ICountry {
        private ICountry Country { get; set; }

        public ProxyCountry(ICountry country) {
            Country = country;
        }

        public object Clone() {
            return (ICountry)this.MemberwiseClone();
        }

        public string getHelloMessage() {
            Console.WriteLine("____Acces to country___");
            return Country.getHelloMessage();
        }
    }
}
