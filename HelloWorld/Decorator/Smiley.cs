namespace HelloWorld.Decorator {
    class Smiley : Decorator {
        public Smiley(ICountry country) : base(country) {
        }

        public override string getHelloMessage() {
            return base.getHelloMessage() + " :)";
        }
    }
}
