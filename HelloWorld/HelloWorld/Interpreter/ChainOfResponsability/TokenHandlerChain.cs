using System.Collections.Generic;

namespace HelloWorld.Interpreter.ChainOfResponsability {
    class TokenHandlerChain : TokenHandler {
        private static TokenHandlerChain instance;

        private TokenHandlerChain() : base("START") {
            List<string> countryTokens = new List<string> { "France", "FR",
                                                            "UnitedKingdom", "UK",
                                                            "UnitedStatesOfAmerica", "US",
                                                            "Indonesia", "IN",
                                                            "Latin", "LA" };
            TokenHandler last = this;
            foreach (string token in countryTokens) {
                last.Next = new CountryTokenHandler(token); ;
                last = last.Next;
            }
            List<string> decoratorTokens = new List<string> { "Smiley", ":)",
                                                              "Underscore", "_",
                                                              "Star", "*" };
            foreach (string token in decoratorTokens) {
                last.Next = new DecoratorTokenHandler(token);
                last = last.Next;
            }
            last.Next = new DecoratorSimpleTokenHandler();
            last = last.Next;
            last.Next = new ErrorTokenHandler();
        }

        public override IExpression execute(string token, IExpression expression) {
            return Next.execute(token, expression);
        }

        public static TokenHandlerChain getInstance() {
            if (instance == null) {
                instance = new TokenHandlerChain();
            }
            return instance;
        }
    }
}
