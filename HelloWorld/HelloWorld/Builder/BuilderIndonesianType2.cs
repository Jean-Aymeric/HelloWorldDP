using HelloWorld.BehaviorGetDate;
using HelloWorld.BehaviorGetHello;

namespace HelloWorld.Builder {
    class BuilderIndonesianType2 : BuilderClassicCountry {
        public override IBehaviorGetDate buildBehaviorGetDate() {
            return FactoryBehaviorGetDate.Create(BehaviorGetDateType.Type2);
        }

        public override IBehaviorGetHello buildBehaviorGetHello() {
            return FactoryBehaviorGetHello.Create(BehaviorGetHelloType.Indonesian);
        }
    }
}
