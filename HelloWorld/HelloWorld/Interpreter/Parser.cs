namespace HelloWorld.Interpreter {
    abstract class Parser {
        public static ICountry parse(string text) {
            IExpression expression = null;
            Context context = new Context();
            foreach (string token in text.Split(' ')) {
                expression = parseToken(token, expression);
            }
            expression.Interpreter(context);
            return context.Country;
        }

        private static IExpression parseToken(string token, IExpression expression) {
            switch (token) {
                case "France":
                case "FR":
                case "UnitedKingdom":
                case "UK":
                case "UnitedStatesOfAmerica":
                case "US":
                case "Indonesia":
                case "IN":
                case "Latin":
                case "LA":
                    return new CountryExpression(token);

                case "Smiley":
                case ":)":
                case "Underscore":
                case "_":
                case "Star":
                case "*":
                    return new DecoratorExpression(token, expression);

                default:
                    if (token.Length == 1) {
                        return new DecoratorExpression(token, expression);
                    }
                    return new ErrorExpression();
            }
        }
    }
}
