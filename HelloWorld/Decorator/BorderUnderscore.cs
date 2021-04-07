namespace HelloWorld.Decorator {
    class BorderUnderscore : Border {
        public BorderUnderscore(ICountry country) : base(country, '_', 80) {
        }
    }
}
