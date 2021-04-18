using HelloWorld.AbstractFactory;

namespace HelloWorld.Interpreter {
    class CountryExpression : IExpression {
        private FactoryMake Factory { get; set; }

        public CountryExpression(string name) {
            switch (name) {
                case "France":
                case "FR":
                    Factory = new MakeFrance();
                    break;
                case "UnitedKingdom":
                case "UK":
                    Factory = new MakeUnitedKingdom();
                    break;
                case "UnitedStatesOfAmerica":
                case "US":
                    Factory = new MakeUnitedStatesOfAmerica();
                    break;
                case "Indonesia":
                case "IN":
                    Factory = new MakeIndonesia();
                    break;
                case "Latin":
                case "LA":
                    Factory = new MakeLatin();
                    break;
                default:
                    Factory = new MakeFrance();
                    break;
            }
        }

        public void Interpreter(Context context) {
            context.Country = Factory.make();
        }
    }
}
