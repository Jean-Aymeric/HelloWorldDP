using System;

namespace HelloWorld.Interpreter.ChainOfResponsability {
    abstract class TokenHandler {
        protected string Token { get; set; }
        public TokenHandler Next { get; set; }

        protected TokenHandler(string token) {
            Token = token;
        }

        public abstract IExpression execute(string token, IExpression expression);
    }
}
