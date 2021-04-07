namespace HelloWorld.Decorator {
    class BorderStar : Border {
        public BorderStar(ICountry country) : base(country, '*') {
        }
    }
}
