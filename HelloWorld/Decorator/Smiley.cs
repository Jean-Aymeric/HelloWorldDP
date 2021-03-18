namespace HelloWorld.Decorator {
    class Smiley : Decorator {
        public Smiley(AbstractCountry country) : base(country) {
        }

        public override string getHelloMessage() {
            return base.getHelloMessage() + " :)";
        }
    }
}
