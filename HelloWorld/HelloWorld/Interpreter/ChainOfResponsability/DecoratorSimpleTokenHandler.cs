namespace HelloWorld.Interpreter.ChainOfResponsability {
    class DecoratorSimpleTokenHandler : TokenHandler {
        public DecoratorSimpleTokenHandler() : base("SinpleDecorator") { }

        public override IExpression execute(string token, IExpression expression) {
            if (token.Length == 1) { 
                return new DecoratorExpression(token, expression); 
            }
            return Next.execute(token, expression);
        }
    }
}
