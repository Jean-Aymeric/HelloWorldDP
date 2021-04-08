using HelloWorld.BehaviorGetDate;
using HelloWorld.BehaviorGetHello;

namespace HelloWorld.Builder {
    class BuilderUnitedKingdomType1 : BuilderClassicCountry {
        public override IBehaviorGetDate buildBehaviorGetDate() {
            return FactoryBehaviorGetDate.Create(BehaviorGetDateType.Type1);
        }

        public override IBehaviorGetHello buildBehaviorGetHello() {
            return FactoryBehaviorGetHello.Create(BehaviorGetHelloType.English);
        }
    }
}
