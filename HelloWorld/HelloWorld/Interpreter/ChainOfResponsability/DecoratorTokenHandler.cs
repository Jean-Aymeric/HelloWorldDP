using System;

namespace HelloWorld.Interpreter.ChainOfResponsability {
    class DecoratorTokenHandler : TokenHandler {
        public DecoratorTokenHandler(string token) : base(token) { }

        public override IExpression execute(string token, IExpression expression) {
            if (String.Equals(Token, token, StringComparison.OrdinalIgnoreCase)) { 
                return new DecoratorExpression(this.Token, expression); 
            }
            return Next.execute(token, expression);
        }
    }
}
