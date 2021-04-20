using HelloWorld.Interpreter.ChainOfResponsability;

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
            return TokenHandlerChain.getInstance().execute(token, expression);
        }
    }
}
