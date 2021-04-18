using HelloWorld.AbstractFactory;

namespace HelloWorld.Interpreter {
    class ErrorExpression : IExpression {

        public void Interpreter(Context context) {
            context.Country = new Error();
        }
    }
}
