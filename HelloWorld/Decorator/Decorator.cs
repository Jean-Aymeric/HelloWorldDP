namespace HelloWorld.Decorator {
    abstract class Decorator : AbstractCountry {
        public ICountry Country { get; set; }

        public Decorator(ICountry country) => this.Country = country;

        public override string getHelloMessage() {
            return this.Country.getHelloMessage();
        }
    }
}
