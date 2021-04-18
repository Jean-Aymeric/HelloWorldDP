namespace HelloWorld.Interpreter {
    abstract class UnaryExpression : IExpression {
        protected IExpression Expression { get; set; }
        protected string Name { get; set; }

        public abstract void Interpreter(Context context);

        public UnaryExpression(string name, IExpression expression) {
            if (expression == null) {
                Expression = new ErrorExpression();
            } else {
                Expression = expression;
            }
            Name = name;
        }
    }
}
