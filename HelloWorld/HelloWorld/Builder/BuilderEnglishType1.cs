using HelloWorld.BehaviorGetDate;
using HelloWorld.BehaviorGetHello;

namespace HelloWorld.Builder {
    class BuilderEnglishType1 : BuilderClassicCountry {
        public override IBehaviorGetDate buildBehaviorGetDate() {
            return FactoryBehaviorGetDate.Create(BehaviorGetDateType.Type1);
        }

        public override IBehaviorGetHello buildBehaviorGetHello() {
            return FactoryBehaviorGetHello.Create(BehaviorGetHelloType.English);
        }
    }
}
