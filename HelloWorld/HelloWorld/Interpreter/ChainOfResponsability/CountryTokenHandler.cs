using System;

namespace HelloWorld.Interpreter.ChainOfResponsability {
    class CountryTokenHandler : TokenHandler {
        public CountryTokenHandler(string token) : base(token) { }

        public override IExpression execute(string token, IExpression expression) {
            if (String.Equals(Token, token,StringComparison.OrdinalIgnoreCase)) {
                return new CountryExpression(this.Token);
            }
            return Next.execute(token, expression);
        }
    }
}
