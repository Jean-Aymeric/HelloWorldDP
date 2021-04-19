using HelloWorld.BehaviorGetDate;
using HelloWorld.BehaviorGetHello;

namespace HelloWorld.Countries {
    class Country : BridgeCountry {
        public Country(IBehaviorGetHello behaviorGetHello, IBehaviorGetDate behaviorGetDate) : base(behaviorGetHello, behaviorGetDate) { }

        public override string getHelloMessage() {
            return getDate() + " : " + getHello();
        }
    }
}

