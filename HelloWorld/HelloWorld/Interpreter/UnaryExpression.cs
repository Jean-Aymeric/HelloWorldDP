namespace HelloWorld.Interpreter {
    abstract class UnaryExpression : IExpression {
        protected IExpression Expression { get; set; }
        protected string Name { get; set; }

        public abstract void Interpreter(Context context);

        public UnaryExpression(string name, IExpression expression) {
            Expression = expression;
            Name = name;
        }
    }
}
