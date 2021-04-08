using HelloWorld.BehaviorGetDate;
using HelloWorld.BehaviorGetHello;

namespace HelloWorld.Builder {
    class BuilderUnitedStatesOfAmericaType2 : BuilderClassicCountry {
        public override IBehaviorGetDate buildBehaviorGetDate() {
            return FactoryBehaviorGetDate.Create(BehaviorGetDateType.Type2);
        }

        public override IBehaviorGetHello buildBehaviorGetHello() {
            return FactoryBehaviorGetHello.Create(BehaviorGetHelloType.English);
        }
    }
}
