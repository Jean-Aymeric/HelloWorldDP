namespace HelloWorld.Decorator {
    class BorderUnderscore : Border {
        public BorderUnderscore(AbstractCountry country) : base(country, '_', 80) {
        }
    }
}
