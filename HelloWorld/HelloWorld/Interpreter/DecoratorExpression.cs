using HelloWorld.Decorator;

namespace HelloWorld.Interpreter {
    class DecoratorExpression : UnaryExpression {
        public DecoratorExpression(string name, IExpression expression) : base(name, expression) { }

        public override void Interpreter(Context context) {
            Expression.Interpreter(context);
            switch (Name) {
                case "Smiley":
                case ":)":
                    context.Country = new Smiley(context.Country);
                    break;
                case "Underscore":
                case "_":
                    context.Country = new BorderUnderscore(context.Country);
                    break;
                case "Star":
                case "*":
                    context.Country = new BorderStar(context.Country);
                    break;
            }
        }
    }
}
