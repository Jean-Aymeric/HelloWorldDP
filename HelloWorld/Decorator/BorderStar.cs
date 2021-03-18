namespace HelloWorld.Decorator {
    class BorderStar : Border {
        public BorderStar(AbstractCountry country) : base(country, '*') {
        }
    }
}
