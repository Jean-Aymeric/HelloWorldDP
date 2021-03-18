namespace HelloWorld.Decorator {
    abstract class Decorator : AbstractCountry {
        public AbstractCountry Country { get; set; }

        public Decorator(AbstractCountry country) => this.Country = country;

        public override string getHelloMessage() {
            return this.Country.getHelloMessage();
        }
    }
}
