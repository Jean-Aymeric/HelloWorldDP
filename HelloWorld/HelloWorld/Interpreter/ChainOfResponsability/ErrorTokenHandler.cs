namespace HelloWorld.Interpreter.ChainOfResponsability {
    class ErrorTokenHandler : TokenHandler {
        public ErrorTokenHandler() : base("ERROR") { }

        public override IExpression execute(string token, IExpression expression) {
            return new ErrorExpression();
        }
    }
}
