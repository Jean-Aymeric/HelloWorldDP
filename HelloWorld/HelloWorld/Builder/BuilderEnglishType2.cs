using HelloWorld.BehaviorGetDate;
using HelloWorld.BehaviorGetHello;

namespace HelloWorld.Builder {
    class BuilderEnglishType2 : BuilderClassicCountry {
        public override IBehaviorGetDate buildBehaviorGetDate() {
            return FactoryBehaviorGetDate.Create(BehaviorGetDateType.Type2);
        }

        public override IBehaviorGetHello buildBehaviorGetHello() {
            return FactoryBehaviorGetHello.Create(BehaviorGetHelloType.English);
        }
    }
}
